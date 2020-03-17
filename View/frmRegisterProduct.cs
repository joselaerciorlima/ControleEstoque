﻿using System;
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
      public frmRegisterProduct(ProductModel product,ActivityModel activity) //Carrega o formulário com o objeto Produto e a ação a ser realizada
      {
         InitializeComponent();

         btnUpload.BackgroundImage = Properties.Resources.upload;
         pcbImage.BackgroundImage = Properties.Resources.no_image;
         btnSave.BackgroundImage = Properties.Resources.save;
         btnCancel.BackgroundImage = Properties.Resources.cancel;
         pcbIcon.BackgroundImage = Properties.Resources.icon_form;

         switch (activity)
         {
            case ActivityModel.Register:
               lbltitleForm.Text = "CADASTRAR PRODUTO";
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

      private void btnSave_Click(object sender, EventArgs e)
      {
         Validation();
      }
   }
}