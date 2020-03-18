namespace View
{
   partial class frmFieldRegister
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFieldRegister));
         this.label2 = new System.Windows.Forms.Label();
         this.lbltitleForm = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.pnlRodape = new System.Windows.Forms.Panel();
         this.groupBoxStatus = new System.Windows.Forms.GroupBox();
         this.rbtInactive = new System.Windows.Forms.RadioButton();
         this.rbtActive = new System.Windows.Forms.RadioButton();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.PictureBox();
         this.pcbIcon = new System.Windows.Forms.PictureBox();
         this.btnSave = new System.Windows.Forms.PictureBox();
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.groupBoxStatus.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.SuspendLayout();
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
         this.label2.TabIndex = 129;
         this.label2.Text = "CONTROLE DE ESTOQUE";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lbltitleForm
         // 
         this.lbltitleForm.AutoSize = true;
         this.lbltitleForm.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbltitleForm.ForeColor = System.Drawing.Color.White;
         this.lbltitleForm.Location = new System.Drawing.Point(194, 109);
         this.lbltitleForm.Margin = new System.Windows.Forms.Padding(0);
         this.lbltitleForm.Name = "lbltitleForm";
         this.lbltitleForm.Size = new System.Drawing.Size(299, 29);
         this.lbltitleForm.TabIndex = 128;
         this.lbltitleForm.Text = "CADASTRO DE CAMPOS";
         this.lbltitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel2
         // 
         this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel2.BackColor = System.Drawing.Color.White;
         this.panel2.Location = new System.Drawing.Point(185, 155);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(820, 14);
         this.panel2.TabIndex = 133;
         // 
         // pnlRodape
         // 
         this.pnlRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pnlRodape.BackColor = System.Drawing.Color.White;
         this.pnlRodape.Location = new System.Drawing.Point(0, 461);
         this.pnlRodape.Name = "pnlRodape";
         this.pnlRodape.Size = new System.Drawing.Size(1005, 20);
         this.pnlRodape.TabIndex = 134;
         // 
         // groupBoxStatus
         // 
         this.groupBoxStatus.Controls.Add(this.radioButton1);
         this.groupBoxStatus.Controls.Add(this.rbtInactive);
         this.groupBoxStatus.Controls.Add(this.rbtActive);
         this.groupBoxStatus.Enabled = false;
         this.groupBoxStatus.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
         this.groupBoxStatus.ForeColor = System.Drawing.Color.White;
         this.groupBoxStatus.Location = new System.Drawing.Point(22, 205);
         this.groupBoxStatus.Name = "groupBoxStatus";
         this.groupBoxStatus.Size = new System.Drawing.Size(460, 88);
         this.groupBoxStatus.TabIndex = 135;
         this.groupBoxStatus.TabStop = false;
         this.groupBoxStatus.Text = "Tipo";
         // 
         // rbtInactive
         // 
         this.rbtInactive.AutoSize = true;
         this.rbtInactive.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtInactive.Location = new System.Drawing.Point(166, 39);
         this.rbtInactive.Name = "rbtInactive";
         this.rbtInactive.Size = new System.Drawing.Size(110, 29);
         this.rbtInactive.TabIndex = 1;
         this.rbtInactive.TabStop = true;
         this.rbtInactive.Text = "Estoque";
         this.rbtInactive.UseVisualStyleBackColor = true;
         // 
         // rbtActive
         // 
         this.rbtActive.AutoSize = true;
         this.rbtActive.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtActive.Location = new System.Drawing.Point(14, 39);
         this.rbtActive.Name = "rbtActive";
         this.rbtActive.Size = new System.Drawing.Size(119, 29);
         this.rbtActive.TabIndex = 0;
         this.rbtActive.TabStop = true;
         this.rbtActive.Text = "Tamanho";
         this.rbtActive.UseVisualStyleBackColor = true;
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Font = new System.Drawing.Font("Arial", 16F);
         this.radioButton1.Location = new System.Drawing.Point(309, 39);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(141, 29);
         this.radioButton1.TabIndex = 1;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "Fornecedor";
         this.radioButton1.UseVisualStyleBackColor = true;
         // 
         // txtDescription
         // 
         this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtDescription.Font = new System.Drawing.Font("Arial", 20F);
         this.txtDescription.Location = new System.Drawing.Point(21, 349);
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(461, 38);
         this.txtDescription.TabIndex = 136;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.White;
         this.label8.Location = new System.Drawing.Point(17, 316);
         this.label8.Margin = new System.Windows.Forms.Padding(0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(126, 29);
         this.label8.TabIndex = 137;
         this.label8.Text = "Descrição";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCancel.Location = new System.Drawing.Point(798, 88);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(176, 50);
         this.btnCancel.TabIndex = 132;
         this.btnCancel.TabStop = false;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // pcbIcon
         // 
         this.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.pcbIcon.Location = new System.Drawing.Point(22, 35);
         this.pcbIcon.Name = "pcbIcon";
         this.pcbIcon.Size = new System.Drawing.Size(144, 142);
         this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pcbIcon.TabIndex = 130;
         this.pcbIcon.TabStop = false;
         // 
         // btnSave
         // 
         this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSave.Location = new System.Drawing.Point(634, 88);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(158, 50);
         this.btnSave.TabIndex = 131;
         this.btnSave.TabStop = false;
         // 
         // dgvData
         // 
         this.dgvData.AllowUserToAddRows = false;
         this.dgvData.AllowUserToDeleteRows = false;
         this.dgvData.AllowUserToResizeColumns = false;
         this.dgvData.AllowUserToResizeRows = false;
         this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.type,
            this.description});
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvData.DefaultCellStyle = dataGridViewCellStyle4;
         this.dgvData.Location = new System.Drawing.Point(504, 214);
         this.dgvData.MultiSelect = false;
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.RowHeadersVisible = false;
         this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvData.Size = new System.Drawing.Size(488, 221);
         this.dgvData.TabIndex = 138;
         // 
         // code
         // 
         this.code.DataPropertyName = "code";
         this.code.HeaderText = "codigo";
         this.code.Name = "code";
         this.code.ReadOnly = true;
         this.code.Visible = false;
         // 
         // type
         // 
         this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
         this.type.DataPropertyName = "type";
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         this.type.DefaultCellStyle = dataGridViewCellStyle2;
         this.type.HeaderText = "TIPO";
         this.type.Name = "type";
         this.type.ReadOnly = true;
         this.type.Width = 71;
         // 
         // description
         // 
         this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.description.DataPropertyName = "description";
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         this.description.DefaultCellStyle = dataGridViewCellStyle3;
         this.description.HeaderText = "DESCRIÇÃO";
         this.description.Name = "description";
         this.description.ReadOnly = true;
         // 
         // frmSettingsProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.ClientSize = new System.Drawing.Size(1004, 481);
         this.Controls.Add(this.dgvData);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.groupBoxStatus);
         this.Controls.Add(this.pnlRodape);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pcbIcon);
         this.Controls.Add(this.lbltitleForm);
         this.Controls.Add(this.btnSave);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frmSettingsProduct";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Controle de Estoque - Projeto Piloto";
         this.groupBoxStatus.ResumeLayout(false);
         this.groupBoxStatus.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lbltitleForm;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtInactive;
        private System.Windows.Forms.RadioButton rbtActive;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}