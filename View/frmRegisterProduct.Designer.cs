namespace View
{
   partial class frmRegisterProduct
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterProduct));
         this.pnlRodape = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.txtCode = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.cbxType = new System.Windows.Forms.ComboBox();
         this.label7 = new System.Windows.Forms.Label();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.groupBoxStatus = new System.Windows.Forms.GroupBox();
         this.rbtInactive = new System.Windows.Forms.RadioButton();
         this.rbtActive = new System.Windows.Forms.RadioButton();
         this.btnUpload = new System.Windows.Forms.PictureBox();
         this.pcbImage = new System.Windows.Forms.PictureBox();
         this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
         this.btnSave = new System.Windows.Forms.PictureBox();
         this.lbltitleForm = new System.Windows.Forms.Label();
         this.pcbIcon = new System.Windows.Forms.PictureBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.PictureBox();
         this.groupBoxStatus.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
         this.SuspendLayout();
         // 
         // pnlRodape
         // 
         this.pnlRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pnlRodape.BackColor = System.Drawing.Color.White;
         this.pnlRodape.Location = new System.Drawing.Point(0, 591);
         this.pnlRodape.Name = "pnlRodape";
         this.pnlRodape.Size = new System.Drawing.Size(938, 20);
         this.pnlRodape.TabIndex = 123;
         // 
         // panel2
         // 
         this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel2.BackColor = System.Drawing.Color.White;
         this.panel2.Location = new System.Drawing.Point(185, 155);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(753, 14);
         this.panel2.TabIndex = 120;
         // 
         // txtCode
         // 
         this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         this.txtCode.Font = new System.Drawing.Font("Arial", 20F);
         this.txtCode.Location = new System.Drawing.Point(21, 282);
         this.txtCode.Name = "txtCode";
         this.txtCode.ReadOnly = true;
         this.txtCode.Size = new System.Drawing.Size(99, 38);
         this.txtCode.TabIndex = 129;
         this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(16, 250);
         this.label5.Margin = new System.Windows.Forms.Padding(0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(97, 29);
         this.label5.TabIndex = 128;
         this.label5.Text = "Código";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // cbxType
         // 
         this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxType.Font = new System.Drawing.Font("Arial", 19.5F);
         this.cbxType.FormattingEnabled = true;
         this.cbxType.Items.AddRange(new object[] {
            "CAMISETA LONG",
            "CAMISETA",
            "BIBLÍA"});
         this.cbxType.Location = new System.Drawing.Point(144, 282);
         this.cbxType.Name = "cbxType";
         this.cbxType.Size = new System.Drawing.Size(292, 39);
         this.cbxType.TabIndex = 0;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.White;
         this.label7.Location = new System.Drawing.Point(139, 250);
         this.label7.Margin = new System.Windows.Forms.Padding(0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(200, 29);
         this.label7.TabIndex = 131;
         this.label7.Text = "Tipo de Produto";
         this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtDescription
         // 
         this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtDescription.Font = new System.Drawing.Font("Arial", 20F);
         this.txtDescription.Location = new System.Drawing.Point(21, 394);
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(528, 38);
         this.txtDescription.TabIndex = 1;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.White;
         this.label8.Location = new System.Drawing.Point(17, 361);
         this.label8.Margin = new System.Windows.Forms.Padding(0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(126, 29);
         this.label8.TabIndex = 133;
         this.label8.Text = "Descrição";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.White;
         this.label4.Location = new System.Drawing.Point(575, 198);
         this.label4.Margin = new System.Windows.Forms.Padding(0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(73, 29);
         this.label4.TabIndex = 134;
         this.label4.Text = "Foto:";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // groupBoxStatus
         // 
         this.groupBoxStatus.Controls.Add(this.rbtInactive);
         this.groupBoxStatus.Controls.Add(this.rbtActive);
         this.groupBoxStatus.Enabled = false;
         this.groupBoxStatus.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
         this.groupBoxStatus.ForeColor = System.Drawing.Color.White;
         this.groupBoxStatus.Location = new System.Drawing.Point(21, 472);
         this.groupBoxStatus.Name = "groupBoxStatus";
         this.groupBoxStatus.Size = new System.Drawing.Size(246, 81);
         this.groupBoxStatus.TabIndex = 6;
         this.groupBoxStatus.TabStop = false;
         this.groupBoxStatus.Text = "Situação";
         // 
         // rbtInactive
         // 
         this.rbtInactive.AutoSize = true;
         this.rbtInactive.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtInactive.Location = new System.Drawing.Point(130, 33);
         this.rbtInactive.Name = "rbtInactive";
         this.rbtInactive.Size = new System.Drawing.Size(94, 29);
         this.rbtInactive.TabIndex = 1;
         this.rbtInactive.TabStop = true;
         this.rbtInactive.Text = "Inativo";
         this.rbtInactive.UseVisualStyleBackColor = true;
         // 
         // rbtActive
         // 
         this.rbtActive.AutoSize = true;
         this.rbtActive.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtActive.Location = new System.Drawing.Point(14, 33);
         this.rbtActive.Name = "rbtActive";
         this.rbtActive.Size = new System.Drawing.Size(80, 29);
         this.rbtActive.TabIndex = 0;
         this.rbtActive.TabStop = true;
         this.rbtActive.Text = "Ativo";
         this.rbtActive.UseVisualStyleBackColor = true;
         // 
         // btnUpload
         // 
         this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnUpload.Location = new System.Drawing.Point(662, 519);
         this.btnUpload.Name = "btnUpload";
         this.btnUpload.Size = new System.Drawing.Size(158, 50);
         this.btnUpload.TabIndex = 136;
         this.btnUpload.TabStop = false;
         this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
         this.btnUpload.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
         this.btnUpload.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
         // 
         // pcbImage
         // 
         this.pcbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pcbImage.Location = new System.Drawing.Point(580, 230);
         this.pcbImage.Name = "pcbImage";
         this.pcbImage.Size = new System.Drawing.Size(323, 273);
         this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pcbImage.TabIndex = 135;
         this.pcbImage.TabStop = false;
         // 
         // errorProvider
         // 
         this.errorProvider.ContainerControl = this;
         // 
         // btnSave
         // 
         this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSave.Location = new System.Drawing.Point(564, 88);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(158, 50);
         this.btnSave.TabIndex = 125;
         this.btnSave.TabStop = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
         this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
         // 
         // lbltitleForm
         // 
         this.lbltitleForm.AutoSize = true;
         this.lbltitleForm.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbltitleForm.ForeColor = System.Drawing.Color.White;
         this.lbltitleForm.Location = new System.Drawing.Point(194, 109);
         this.lbltitleForm.Margin = new System.Windows.Forms.Padding(0);
         this.lbltitleForm.Name = "lbltitleForm";
         this.lbltitleForm.Size = new System.Drawing.Size(159, 29);
         this.lbltitleForm.TabIndex = 117;
         this.lbltitleForm.Text = "TITLE FORM";
         this.lbltitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // pcbIcon
         // 
         this.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.pcbIcon.Location = new System.Drawing.Point(22, 35);
         this.pcbIcon.Name = "pcbIcon";
         this.pcbIcon.Size = new System.Drawing.Size(144, 142);
         this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pcbIcon.TabIndex = 121;
         this.pcbIcon.TabStop = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(99, 27);
         this.label2.Margin = new System.Windows.Forms.Padding(0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(407, 37);
         this.label2.TabIndex = 119;
         this.label2.Text = "CONTROLE DE ESTOQUE";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCancel.Location = new System.Drawing.Point(728, 88);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(176, 50);
         this.btnCancel.TabIndex = 127;
         this.btnCancel.TabStop = false;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         this.btnCancel.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
         this.btnCancel.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
         // 
         // frmRegisterProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.ClientSize = new System.Drawing.Size(938, 611);
         this.Controls.Add(this.groupBoxStatus);
         this.Controls.Add(this.btnUpload);
         this.Controls.Add(this.pcbImage);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.cbxType);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.txtCode);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pcbIcon);
         this.Controls.Add(this.pnlRodape);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.lbltitleForm);
         this.Controls.Add(this.btnSave);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frmRegisterProduct";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Controle de Estoque - Projeto Piloto";
         this.groupBoxStatus.ResumeLayout(false);
         this.groupBoxStatus.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnUpload;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton rbtInactive;
        private System.Windows.Forms.RadioButton rbtActive;
      private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lbltitleForm;
        private System.Windows.Forms.PictureBox btnSave;
    }
}