using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
   public partial class frmProduct : Form
   {
      ProductController productController = new ProductController();
      ProductModel productModel = new ProductModel();
      int selectedProduct;
      public frmProduct()
      {
         InitializeComponent();

         //Insere as imagens nos controles quando o formulário é carregado.
         pcbIcon.BackgroundImage = Properties.Resources.icon_form;
         btnRegister.BackgroundImage = Properties.Resources.register;
         btnMovement.BackgroundImage = Properties.Resources.movement;
         btnModify.BackgroundImage = Properties.Resources.modify;
         btnDelete.BackgroundImage = Properties.Resources.delete;
         btnCancel.BackgroundImage = Properties.Resources.cancel;

         Search();
      }
      //####################### MÉTODOS E FUNÇÕES ##################################################
      //Método que adciona o efeito hover nos botoes.
      private void HoverButton(object sender)
      {
         if (sender == btnRegister)
         {
            btnRegister.BackgroundImage = Properties.Resources.register_hover;
         }
         else if (sender == btnMovement)
         {
            btnMovement.BackgroundImage = Properties.Resources.movement_hover;
         }
         else if (sender == btnModify)
         {
            btnModify.BackgroundImage = Properties.Resources.modify_hover;
         }
         else if (sender == btnDelete)
         {
            btnDelete.BackgroundImage = Properties.Resources.delete_hover;
         }
         else if (sender == btnCancel)
         {
            btnCancel.BackgroundImage = Properties.Resources.cancel_hover;
         }
      }
      //=============================================================================================
      //Método que retira o efeito hover nos botoes.
      private void LeaveButton(object sender)
      {
         if (sender == btnRegister)
         {
            btnRegister.BackgroundImage = Properties.Resources.register;
         }
         else if (sender == btnMovement)
         {
            btnMovement.BackgroundImage = Properties.Resources.movement;
         }
         else if (sender == btnModify)
         {
            btnModify.BackgroundImage = Properties.Resources.modify;
         }
         else if (sender == btnDelete)
         {
            btnDelete.BackgroundImage = Properties.Resources.delete;
         }
         else if (sender == btnCancel)
         {
            btnCancel.BackgroundImage = Properties.Resources.cancel;
         }
      }
      //=============================================================================================
      void Clear()
      {
         if (rbtType.Checked)
         {
            txtFilter.Clear();
            txtFilter.Focus();
         }
         else if (rbtDescription.Checked)
         {
            txtFilter.Clear();
            txtFilter.Focus();
         }
         else if (rbtSize.Checked)
         {
            txtFilter.Clear();
            txtFilter.Focus();
         }
      }
      //=============================================================================================
      void Search()
      {
         string filterType = "";

         if (rbtType.Checked)
         {
            filterType = "typeproduct";
         }
         else if (rbtDescription.Checked)
         {
            filterType = "descriptionproduct";
         }
         else if (rbtSize.Checked)
         {
            filterType = "size";
         }

         dgvData.DataSource = productController.Search(txtFilter.Text, filterType);
      }
      //=============================================================================================
      bool SelectData()
      {
         if (dgvData.SelectedRows.Count == 0)
         {
            MessageBox.Show("Você precisa selecionar um produto.", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
         }
         else
         {
            productModel.codproduct = Convert.ToInt32(dgvData.CurrentRow.Cells["codproduct"].Value);
            productModel.typeproduct = dgvData.CurrentRow.Cells["typeproduct"].Value.ToString();
            productModel.descriptionproduct = dgvData.CurrentRow.Cells["descriptionproduct"].Value.ToString();
            productModel.imageproduct = dgvData.CurrentRow.Cells["imageproduct"].Value.ToString();
            productModel.statusproduct = Convert.ToInt32(dgvData.CurrentRow.Cells["statusproduct"].Value);
            return true;
         }
      }
      //=============================================================================================
      //####################### EVENTO DOS CONTROLES ################################################
      private void btnRegister_MouseEnter(object sender, EventArgs e)
      {
         HoverButton(sender);
      }
      //=============================================================================================
      private void btnRegister_MouseLeave(object sender, EventArgs e)
      {
         LeaveButton(sender);
      }
      //=============================================================================================
      private void txtFilter_TextChanged(object sender, EventArgs e)
      {
         Search();
      }
      //=============================================================================================
      private void rbtType_CheckedChanged(object sender, EventArgs e)
      {
         Clear();
      }
      //=============================================================================================
      private void btnRegister_Click(object sender, EventArgs e)
      {
         frmRegisterProduct frmRegisterProduct = new frmRegisterProduct(null, ActivityModel.Register);
         frmRegisterProduct.ShowDialog();
         Search();
      }
      //=============================================================================================
      private void btnModify_Click(object sender, EventArgs e)
      {
         if (SelectData())
         {
            frmRegisterProduct frmRegisterProduct = new frmRegisterProduct(productModel, ActivityModel.Update);
            frmRegisterProduct.ShowDialog();
            Search();
         }
      }
      //=============================================================================================
      private void btnDelete_Click(object sender, EventArgs e)
      {
         if (dgvData.SelectedRows.Count == 0)
         {
            MessageBox.Show("Você precisa selecionar um produto.", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else
         {
            if (MessageBox.Show("Deseja remover o produto " + dgvData.CurrentRow.Cells["typeproduct"].Value.ToString().ToUpper() + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               this.selectedProduct = (int)dgvData.CurrentRow.Cells["codproduct"].Value;

               string imagePath = dgvData.CurrentRow.Cells["imageproduct"].Value.ToString();

               dgvData.Rows.Remove(dgvData.CurrentRow);
               productController.Remove(selectedProduct, imagePath);

               MessageBox.Show("Produto excluído com sucesso!.", "Êxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
      }
      //=============================================================================================
      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      //=============================================================================================
      private void btnMovement_Click(object sender, EventArgs e)
      {
         if (SelectData())
         {
            frmOperation frmOperation = new frmOperation(productModel);
            frmOperation.ShowDialog();
            Search();
         }
      }
   }
}
