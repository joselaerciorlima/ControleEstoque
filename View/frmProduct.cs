using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
   public partial class frmProduct : Form
   {
      public frmProduct()
      {
         InitializeComponent();

         //Insere as imagens nos controles quando o formulário é carregado.
         pcbIcon.BackgroundImage = Properties.Resources.icon_form;
         btnRegister.BackgroundImage = Properties.Resources.register;
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
         else if (rbtModel.Checked)
         {
            txtFilter.Clear();
            txtFilter.Focus();
         }
         else if (rbtProvider.Checked)
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
         else if (rbtModel.Checked)
         {
            filterType = "modelproduct";
         }
         else if (rbtProvider.Checked)
         {
            filterType = "providerproduct";
         }

         
            ProductController productController = new ProductController();
            dgvData.DataSource = productController.Search(txtFilter.Text, filterType);
        
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
         frmRegisterProduct frmRegisterProduct = new frmRegisterProduct(null, Model.ActivityModel.Register);
         frmRegisterProduct.ShowDialog();
      }

      private void btnModify_Click(object sender, EventArgs e)
      {
         if (dgvData.SelectedRows.Count == 0)
         {
            MessageBox.Show("Você precisa selecionar um produto.", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else
         {
            ProductModel productModel = new ProductModel();

            productModel.codproduct = Convert.ToInt32(dgvData.CurrentRow.Cells["codproduct"].Value);
            productModel.typeproduct = dgvData.CurrentRow.Cells["typeproduct"].Value.ToString();
            productModel.descriptionproduct = dgvData.CurrentRow.Cells["descriptionproduct"].Value.ToString();
            productModel.providerproduct = dgvData.CurrentRow.Cells["providerproduct"].Value.ToString();
            productModel.sizeproduct = dgvData.CurrentRow.Cells["sizeproduct"].Value.ToString();
            productModel.valueproduct = Convert.ToDecimal(dgvData.CurrentRow.Cells["valueproduct"].Value);
            productModel.storageproduct =dgvData.CurrentRow.Cells["storageproduct"].Value.ToString();
            productModel.imageproduct = dgvData.CurrentRow.Cells["imageproduct"].Value.ToString();
            productModel.statusproduct = Convert.ToInt32(dgvData.CurrentRow.Cells["statusproduct"].Value);

            frmRegisterProduct frmRegisterProduct = new frmRegisterProduct(productModel,ActivityModel.Update);
            frmRegisterProduct.ShowDialog();
            Search();


            
         }
      }
   }
}
