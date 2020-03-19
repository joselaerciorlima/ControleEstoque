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
      public frmProduct()
      {
         InitializeComponent();

         //Insere as imagens nos controles quando o formulário é carregado.
         pcbIcon.BackgroundImage = Properties.Resources.icon_form;
         btnMovement.BackgroundImage = Properties.Resources.movement;
         btnCancel.BackgroundImage = Properties.Resources.cancel;

         Search();
      }
      //####################### MÉTODOS E FUNÇÕES ##################################################
      //Método que adciona o efeito hover nos botoes.
      private void HoverButton(object sender)
      {
         if (sender == btnMovement)
         {
            btnMovement.BackgroundImage = Properties.Resources.movement_hover;
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

         if (sender == btnMovement)
         {
            btnMovement.BackgroundImage = Properties.Resources.movement;
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
         int operation = 0;

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
            filterType = "descriptionsize";
         }

         if (rbtInput.Checked)
         {
            operation = 1;
         }
         else if (rbtOutput.Checked)
         {
            operation = 2;
         }
         else if (rbtTransfer.Checked)
         {
            operation = 3;
         }
         else if (rbtAll.Checked)
         {
            operation = 0;
         }

         dgvData.DataSource = productController.Search(txtFilter.Text, filterType, operation);
      }
      //=============================================================================================
      //####################### EVENTO DOS CONTROLES ################################################
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
      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      //=============================================================================================
      private void btnMovement_Click(object sender, EventArgs e)
      {
         frmOperation frmOperation = new frmOperation(productModel);
         frmOperation.ShowDialog();
         Search();
      }
      //=============================================================================================
      private void rbtAll_CheckedChanged(object sender, EventArgs e)
      {
         Search();
      }
      //=============================================================================================
      private void btnCancel_MouseEnter(object sender, EventArgs e)
      {
         HoverButton(sender);
      }
      //=============================================================================================
      private void btnCancel_MouseLeave(object sender, EventArgs e)
      {
         LeaveButton(sender);
      }
   }
}
