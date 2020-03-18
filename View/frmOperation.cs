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

         this.selectedProduct = product;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
