using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
   public partial class frmRegisterProduct : Form
   {
      ProductController productController = new ProductController();
      ActivityModel selectedActivity;
      ProductModel selectedProduct;
      UploadImage uploadImage = new UploadImage();
      bool newImage = false;

      //############## ELEMENTOS QUE CARREGAM NA INICIALIZAÇÃO DO FORMULÁRIO #######################
      public frmRegisterProduct(ProductModel product,ActivityModel activity) //Carrega o formulário com o objeto Produto e a ação a ser realizada
      {
         InitializeComponent();

         btnUpload.BackgroundImage = Properties.Resources.upload;
         pcbImage.BackgroundImage = Properties.Resources.no_image;
         btnSave.BackgroundImage = Properties.Resources.save;
         btnCancel.BackgroundImage = Properties.Resources.cancel;
         pcbIcon.BackgroundImage = Properties.Resources.icon_form;

         this.selectedActivity = activity;
         this.selectedProduct = product;

         switch (activity)
         {
            case ActivityModel.Register:
               lbltitleForm.Text = "CADASTRAR PRODUTO";
               txtCode.Text = (productController.GetNewCodProduct() + 1).ToString();
               break;
            case ActivityModel.Update:
               lbltitleForm.Text = "ATUALIZAR CADASTRO DO PRODUTO";
               LoadData();
               groupBoxStatus.Enabled = true;
               break;
            case ActivityModel.Search:
               break;
            case ActivityModel.Select:
               break;
            case ActivityModel.Delete:
               break;
         }
      }
      //####################### MÉTODOS E FUNÇÕES ##################################################
      //Método que adciona o efeito hover nos botoes.
      private void HoverButton(object sender)
      {
         if (sender == btnSave)
         {
            btnSave.BackgroundImage = Properties.Resources.save_hover;
         }
         else if (sender == btnCancel)
         {
            btnCancel.BackgroundImage = Properties.Resources.cancel_hover;
         }
         else if (sender == btnUpload)
         {
            btnUpload.BackgroundImage = Properties.Resources.upload_hover;
         }
      }
      //=============================================================================================
      //Método que retira o efeito hover nos botoes.
      private void LeaveButton(object sender)
      {
         if (sender == btnSave)
         {
            btnSave.BackgroundImage = Properties.Resources.save;
         }
         else if (sender == btnCancel)
         {
            btnCancel.BackgroundImage = Properties.Resources.cancel;
         }
         else if (sender == btnUpload)
         {
            btnUpload.BackgroundImage = Properties.Resources.upload;
         }
      }
      //=============================================================================================
      void LoadData()
      {
         txtCode.Text = this.selectedProduct.codproduct.ToString();
         cbxType.SelectedItem = this.selectedProduct.typeproduct;
         txtDescription.Text = this.selectedProduct.descriptionproduct;
         txtProvider.Text = this.selectedProduct.providerproduct;
         txtStorage.Text = this.selectedProduct.storageproduct;
         cbxSize.SelectedItem = this.selectedProduct.sizeproduct;
         txtValue.Text = this.selectedProduct.valueproduct.ToString();

         pcbImage.ImageLocation = this.selectedProduct.imageproduct;

         _ = this.selectedProduct.statusproduct == 1 ? rbtActive.Checked = true : rbtInactive.Checked = true;
      }
      //=============================================================================================
      //Faz a validação dos campos do formulário.
      bool Validation()
      {
         errorProvider.Clear();

         //Se todos os campos obrigatórios estiverem preenchidos vai retornar TRUE.
         if (cbxType.SelectedIndex <0)
         {
            errorProvider.SetError(cbxType, "Campo obrigatório!");
            cbxType.Focus();
            return false;
         }
         if (String.IsNullOrWhiteSpace(txtDescription.Text))
         {
            errorProvider.SetError(txtDescription, "Campo obrigatório!");
            txtDescription.Focus();
            return false;
         }
         if (String.IsNullOrWhiteSpace(txtProvider.Text))
         {
            errorProvider.SetError(txtProvider, "Campo obrigatório!");
            txtProvider.Focus();
            return false;
         }
         if (cbxSize.SelectedIndex <0)
         {
            errorProvider.SetError(cbxSize, "Campo obrigatório!");
            cbxSize.Focus();
            return false;
         }
         if (String.IsNullOrWhiteSpace(txtValue.Text))
         {
            errorProvider.SetError(txtValue, "Campo obrigatório!");
            txtValue.Focus();
            return false;
         }
         if (String.IsNullOrWhiteSpace(txtStorage.Text))
         {
            errorProvider.SetError(txtStorage, "Campo obrigatório!");
            txtStorage.Focus();
            return false;
         }
         if (pcbImage.Image == null)
         {
            MessageBox.Show("Você esqueceu de cadastrar uma imagem para este produto!", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         
         return true;
      }
      //=============================================================================================
      //Método que cria um novo registro no banco de dados com as informações dos controles.
      void Register()
      {
         if (Validation())
         {
            try
            {
               ProductModel product = new ProductModel();

               product.typeproduct = cbxType.SelectedItem.ToString();
               product.descriptionproduct = txtDescription.Text;
               product.providerproduct = txtProvider.Text;
               product.sizeproduct = cbxSize.SelectedItem.ToString();
               product.valueproduct = Convert.ToDecimal(txtValue.Text);
               product.storageproduct = txtStorage.Text;
               product.imageproduct = uploadImage.SaveImage(txtCode.Text,pcbImage.ImageLocation);
               
               int code = productController.Register(product); //Chama o método de INSERT que está dentro da classe ProductControler passando o objeto controle como parâmetro. Ela foi instânciada globalmente.

               MessageBox.Show("O produto foi cadastrado!", "Êxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
            }
            catch (Exception error)
            {
               MessageBox.Show("Algo deu errado. Detalhes: " + error.Message, "Op's", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
      }
      //=============================================================================================
      void Modify()
      {
         if (Validation())
         {
            try
            {
               ProductModel product = new ProductModel();

               product.codproduct = this.selectedProduct.codproduct;
               product.typeproduct = cbxType.SelectedItem.ToString();
               product.descriptionproduct = txtDescription.Text;
               product.providerproduct = txtProvider.Text;
               product.sizeproduct = cbxSize.SelectedItem.ToString();
               product.valueproduct = Convert.ToDecimal(txtValue.Text);
               product.storageproduct = txtStorage.Text;

               if (!newImage)
               {
                  product.imageproduct = pcbImage.ImageLocation;
               }
               else
               {
                  product.imageproduct = uploadImage.SaveImage(txtCode.Text, pcbImage.ImageLocation);
               }

               if (rbtActive.Checked == true)
               {
                  product.statusproduct = 1;
               }
               else if(rbtInactive.Checked == true)
               {
                  product.statusproduct = 0;
               }

               int code = productController.Modify(product); //Chama o método de UPDATE que está dentro da classe ProductControler passando o objeto controle como parâmetro. Ela foi instânciada globalmente.

               MessageBox.Show("O dados do produto foram atualizados!", "Êxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
            }
            catch (Exception error)
            {
               MessageBox.Show("Algo deu errado. Detalhes: " + error.Message, "Op's", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
      }
      //=============================================================================================
      //####################### EVENTO DOS CONTROLES ################################################
      private void btnSave_MouseEnter(object sender, EventArgs e)
      {
         HoverButton(sender);
      }
      //=============================================================================================
      private void btnSave_MouseLeave(object sender, EventArgs e)
      {
         LeaveButton(sender);
      }
      //=============================================================================================
      private void btnSave_Click(object sender, EventArgs e)
      {
         switch (this.selectedActivity)
         {
            case ActivityModel.Register:
               Register();
               break;
            case ActivityModel.Update:
               Modify();
               break;
         }
      }
      //=============================================================================================
      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      //=============================================================================================
      private void btnUpload_Click(object sender, EventArgs e)
      {
         uploadImage.CreateFolder();
         pcbImage.ImageLocation = uploadImage.Upload();
         newImage = true;
      }
   }
}
