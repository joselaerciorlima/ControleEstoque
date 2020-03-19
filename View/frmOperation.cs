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
   public partial class frmOperation : Form
   {
      ProductModel selectedProduct;
      public frmOperation(ProductModel product)
      {
         InitializeComponent();

         btnSave.BackgroundImage = Properties.Resources.save;
         btnCancel.BackgroundImage = Properties.Resources.cancel;
         pcbIcon.BackgroundImage = Properties.Resources.icon_form;
         btnSearch.BackgroundImage = Properties.Resources.search;

         this.selectedProduct = product;
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
         else if (sender == btnSearch)
         {
            btnSearch.BackgroundImage = Properties.Resources.search_hover;
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
         else if (sender == btnSearch)
         {
            btnSearch.BackgroundImage = Properties.Resources.search;
         }
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnSave_MouseEnter(object sender, EventArgs e)
      {
         HoverButton(sender);
      }

      private void btnSave_MouseLeave(object sender, EventArgs e)
      {
         LeaveButton(sender);
      }
   }
}
