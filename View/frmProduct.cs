using Controller;
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

      private void txtFilter_TextChanged(object sender, EventArgs e)
      {
         Search();
      }
      private void rbtType_CheckedChanged(object sender, EventArgs e)
      {
         Clear();
      }
   }
}
