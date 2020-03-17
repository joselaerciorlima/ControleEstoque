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
      UploadImage uploadImage = new UploadImage();
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
         switch (activity)
         {
            case ActivityModel.Register:
               lbltitleForm.Text = "CADASTRAR PRODUTO";
               txtCode.Text = (productController.GetNewCodProduct() + 1).ToString();
               break;
            case ActivityModel.Update:
               lbltitleForm.Text = "ATUALIZAR CADASTRO DO PRODUTO";
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
         if (String.IsNullOrWhiteSpace(txtModel.Text))
         {
            errorProvider.SetError(txtModel, "Campo obrigatório!");
            txtModel.Focus();
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
               product.modelproduct = txtModel.Text;
               product.providerproduct = txtProvider.Text;
               product.sizeproduct = cbxSize.SelectedItem.ToString();
               product.valueproduct = Convert.ToDecimal(txtValue.Text);
               product.imageproduct = uploadImage.SaveImage(txtCode.Text,pcbImage.ImageLocation);
               product.logproduct = "Usuário logado: GESTOR >>> Data e hora da operação: " + DateTime.Now;

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
               //Modify();
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
      }
   }
}
