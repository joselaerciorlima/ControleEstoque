namespace View
{
   partial class frmOperation
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperation));
         this.label2 = new System.Windows.Forms.Label();
         this.pnlRodape = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.lbltitleForm = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.PictureBox();
         this.pcbIcon = new System.Windows.Forms.PictureBox();
         this.btnSave = new System.Windows.Forms.PictureBox();
         this.groupBoxOperation = new System.Windows.Forms.GroupBox();
         this.rbtOutput = new System.Windows.Forms.RadioButton();
         this.rbtInput = new System.Windows.Forms.RadioButton();
         this.rbtTransfer = new System.Windows.Forms.RadioButton();
         this.cbxStorageSource = new System.Windows.Forms.ComboBox();
         this.label10 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.dtpDate = new System.Windows.Forms.DateTimePicker();
         this.lblDestiny = new System.Windows.Forms.Label();
         this.cbxStorageDestiny = new System.Windows.Forms.ComboBox();
         this.txtCode = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtType = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtValueUnit = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.nudAmount = new System.Windows.Forms.NumericUpDown();
         this.label7 = new System.Windows.Forms.Label();
         this.txtValueTotal = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.cbxSize = new System.Windows.Forms.ComboBox();
         this.cbxProvider = new System.Windows.Forms.ComboBox();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
         this.groupBoxOperation.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(99, 27);
         this.label2.Margin = new System.Windows.Forms.Padding(0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(490, 45);
         this.label2.TabIndex = 130;
         this.label2.Text = "CONTROLE DE ESTOQUE";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // pnlRodape
         // 
         this.pnlRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pnlRodape.BackColor = System.Drawing.Color.White;
         this.pnlRodape.Location = new System.Drawing.Point(0, 591);
         this.pnlRodape.Name = "pnlRodape";
         this.pnlRodape.Size = new System.Drawing.Size(1284, 20);
         this.pnlRodape.TabIndex = 134;
         // 
         // panel2
         // 
         this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel2.BackColor = System.Drawing.Color.White;
         this.panel2.Location = new System.Drawing.Point(212, 155);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1072, 14);
         this.panel2.TabIndex = 131;
         // 
         // lbltitleForm
         // 
         this.lbltitleForm.AutoSize = true;
         this.lbltitleForm.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbltitleForm.ForeColor = System.Drawing.Color.White;
         this.lbltitleForm.Location = new System.Drawing.Point(215, 109);
         this.lbltitleForm.Margin = new System.Windows.Forms.Padding(0);
         this.lbltitleForm.Name = "lbltitleForm";
         this.lbltitleForm.Size = new System.Drawing.Size(374, 29);
         this.lbltitleForm.TabIndex = 128;
         this.lbltitleForm.Text = "MOVIMENTAÇÃO DE ESTOQUE";
         this.lbltitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCancel.Location = new System.Drawing.Point(1073, 93);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(176, 50);
         this.btnCancel.TabIndex = 136;
         this.btnCancel.TabStop = false;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // pcbIcon
         // 
         this.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.pcbIcon.Location = new System.Drawing.Point(22, 35);
         this.pcbIcon.Name = "pcbIcon";
         this.pcbIcon.Size = new System.Drawing.Size(171, 159);
         this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pcbIcon.TabIndex = 132;
         this.pcbIcon.TabStop = false;
         // 
         // btnSave
         // 
         this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnSave.Location = new System.Drawing.Point(909, 93);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(158, 50);
         this.btnSave.TabIndex = 135;
         this.btnSave.TabStop = false;
         // 
         // groupBoxOperation
         // 
         this.groupBoxOperation.Controls.Add(this.rbtTransfer);
         this.groupBoxOperation.Controls.Add(this.rbtOutput);
         this.groupBoxOperation.Controls.Add(this.rbtInput);
         this.groupBoxOperation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
         this.groupBoxOperation.ForeColor = System.Drawing.Color.White;
         this.groupBoxOperation.Location = new System.Drawing.Point(22, 231);
         this.groupBoxOperation.Name = "groupBoxOperation";
         this.groupBoxOperation.Size = new System.Drawing.Size(507, 80);
         this.groupBoxOperation.TabIndex = 137;
         this.groupBoxOperation.TabStop = false;
         this.groupBoxOperation.Text = "Tipo de Movimentação";
         // 
         // rbtOutput
         // 
         this.rbtOutput.AutoSize = true;
         this.rbtOutput.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtOutput.Location = new System.Drawing.Point(172, 35);
         this.rbtOutput.Name = "rbtOutput";
         this.rbtOutput.Size = new System.Drawing.Size(97, 29);
         this.rbtOutput.TabIndex = 1;
         this.rbtOutput.Text = "SAÍDA";
         this.rbtOutput.UseVisualStyleBackColor = true;
         // 
         // rbtInput
         // 
         this.rbtInput.AutoSize = true;
         this.rbtInput.Checked = true;
         this.rbtInput.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtInput.Location = new System.Drawing.Point(20, 35);
         this.rbtInput.Name = "rbtInput";
         this.rbtInput.Size = new System.Drawing.Size(137, 29);
         this.rbtInput.TabIndex = 0;
         this.rbtInput.TabStop = true;
         this.rbtInput.Text = "ENTRADA";
         this.rbtInput.UseVisualStyleBackColor = true;
         // 
         // rbtTransfer
         // 
         this.rbtTransfer.AutoSize = true;
         this.rbtTransfer.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtTransfer.Location = new System.Drawing.Point(284, 35);
         this.rbtTransfer.Name = "rbtTransfer";
         this.rbtTransfer.Size = new System.Drawing.Size(203, 29);
         this.rbtTransfer.TabIndex = 1;
         this.rbtTransfer.Text = "TRANFERÊNCIA";
         this.rbtTransfer.UseVisualStyleBackColor = true;
         // 
         // cbxStorageSource
         // 
         this.cbxStorageSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxStorageSource.Font = new System.Drawing.Font("Arial", 19.5F);
         this.cbxStorageSource.FormattingEnabled = true;
         this.cbxStorageSource.Location = new System.Drawing.Point(744, 272);
         this.cbxStorageSource.Name = "cbxStorageSource";
         this.cbxStorageSource.Size = new System.Drawing.Size(304, 39);
         this.cbxStorageSource.TabIndex = 138;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.ForeColor = System.Drawing.Color.White;
         this.label10.Location = new System.Drawing.Point(739, 240);
         this.label10.Margin = new System.Windows.Forms.Padding(0);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(233, 29);
         this.label10.TabIndex = 139;
         this.label10.Text = "Estoque de Origem";
         this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label12
         // 
         this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label12.AutoSize = true;
         this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label12.ForeColor = System.Drawing.Color.White;
         this.label12.Location = new System.Drawing.Point(543, 240);
         this.label12.Margin = new System.Windows.Forms.Padding(0);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(64, 29);
         this.label12.TabIndex = 141;
         this.label12.Text = "Data";
         this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // dtpDate
         // 
         this.dtpDate.Font = new System.Drawing.Font("Arial", 20F);
         this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtpDate.Location = new System.Drawing.Point(548, 273);
         this.dtpDate.Name = "dtpDate";
         this.dtpDate.Size = new System.Drawing.Size(182, 38);
         this.dtpDate.TabIndex = 142;
         // 
         // lblDestiny
         // 
         this.lblDestiny.AutoSize = true;
         this.lblDestiny.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDestiny.ForeColor = System.Drawing.Color.White;
         this.lblDestiny.Location = new System.Drawing.Point(1058, 240);
         this.lblDestiny.Margin = new System.Windows.Forms.Padding(0);
         this.lblDestiny.Name = "lblDestiny";
         this.lblDestiny.Size = new System.Drawing.Size(238, 29);
         this.lblDestiny.TabIndex = 139;
         this.lblDestiny.Text = "Estoque de Destino";
         this.lblDestiny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.lblDestiny.Visible = false;
         // 
         // cbxStorageDestiny
         // 
         this.cbxStorageDestiny.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.cbxStorageDestiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxStorageDestiny.Font = new System.Drawing.Font("Arial", 19.5F);
         this.cbxStorageDestiny.FormattingEnabled = true;
         this.cbxStorageDestiny.Location = new System.Drawing.Point(1063, 272);
         this.cbxStorageDestiny.Name = "cbxStorageDestiny";
         this.cbxStorageDestiny.Size = new System.Drawing.Size(211, 39);
         this.cbxStorageDestiny.TabIndex = 138;
         this.cbxStorageDestiny.Visible = false;
         // 
         // txtCode
         // 
         this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         this.txtCode.Font = new System.Drawing.Font("Arial", 20F);
         this.txtCode.Location = new System.Drawing.Point(22, 385);
         this.txtCode.Name = "txtCode";
         this.txtCode.ReadOnly = true;
         this.txtCode.Size = new System.Drawing.Size(102, 38);
         this.txtCode.TabIndex = 144;
         // 
         // label8
         // 
         this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.White;
         this.label8.Location = new System.Drawing.Point(17, 352);
         this.label8.Margin = new System.Windows.Forms.Padding(0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(97, 29);
         this.label8.TabIndex = 143;
         this.label8.Text = "Código";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(135, 352);
         this.label3.Margin = new System.Windows.Forms.Padding(0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(65, 29);
         this.label3.TabIndex = 143;
         this.label3.Text = "Tipo";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtType
         // 
         this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         this.txtType.Font = new System.Drawing.Font("Arial", 20F);
         this.txtType.Location = new System.Drawing.Point(140, 385);
         this.txtType.Name = "txtType";
         this.txtType.ReadOnly = true;
         this.txtType.Size = new System.Drawing.Size(301, 38);
         this.txtType.TabIndex = 144;
         // 
         // label4
         // 
         this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.White;
         this.label4.Location = new System.Drawing.Point(454, 352);
         this.label4.Margin = new System.Windows.Forms.Padding(0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(126, 29);
         this.label4.TabIndex = 143;
         this.label4.Text = "Descrição";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         this.txtDescription.Font = new System.Drawing.Font("Arial", 20F);
         this.txtDescription.Location = new System.Drawing.Point(459, 385);
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.ReadOnly = true;
         this.txtDescription.Size = new System.Drawing.Size(589, 38);
         this.txtDescription.TabIndex = 144;
         // 
         // label5
         // 
         this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(544, 467);
         this.label5.Margin = new System.Windows.Forms.Padding(0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(186, 29);
         this.label5.TabIndex = 143;
         this.label5.Text = "Valor Unit. (R$)";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtValueUnit
         // 
         this.txtValueUnit.BackColor = System.Drawing.SystemColors.Window;
         this.txtValueUnit.Font = new System.Drawing.Font("Arial", 20F);
         this.txtValueUnit.Location = new System.Drawing.Point(549, 500);
         this.txtValueUnit.Name = "txtValueUnit";
         this.txtValueUnit.Size = new System.Drawing.Size(181, 38);
         this.txtValueUnit.TabIndex = 144;
         // 
         // label6
         // 
         this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.White;
         this.label6.Location = new System.Drawing.Point(17, 466);
         this.label6.Margin = new System.Windows.Forms.Padding(0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(145, 29);
         this.label6.TabIndex = 143;
         this.label6.Text = "Quantidade";
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // nudAmount
         // 
         this.nudAmount.Font = new System.Drawing.Font("Arial", 20F);
         this.nudAmount.Location = new System.Drawing.Point(22, 500);
         this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.nudAmount.Name = "nudAmount";
         this.nudAmount.Size = new System.Drawing.Size(140, 38);
         this.nudAmount.TabIndex = 145;
         this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // label7
         // 
         this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.White;
         this.label7.Location = new System.Drawing.Point(742, 467);
         this.label7.Margin = new System.Windows.Forms.Padding(0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(195, 29);
         this.label7.TabIndex = 143;
         this.label7.Text = "Valor Total. (R$)";
         this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtValueTotal
         // 
         this.txtValueTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         this.txtValueTotal.Font = new System.Drawing.Font("Arial", 20F);
         this.txtValueTotal.Location = new System.Drawing.Point(747, 500);
         this.txtValueTotal.Name = "txtValueTotal";
         this.txtValueTotal.ReadOnly = true;
         this.txtValueTotal.Size = new System.Drawing.Size(190, 38);
         this.txtValueTotal.TabIndex = 144;
         // 
         // label9
         // 
         this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.ForeColor = System.Drawing.Color.White;
         this.label9.Location = new System.Drawing.Point(1058, 352);
         this.label9.Margin = new System.Windows.Forms.Padding(0);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(118, 29);
         this.label9.TabIndex = 143;
         this.label9.Text = "Tamanho";
         this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label11
         // 
         this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label11.ForeColor = System.Drawing.Color.White;
         this.label11.Location = new System.Drawing.Point(176, 467);
         this.label11.Margin = new System.Windows.Forms.Padding(0);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(145, 29);
         this.label11.TabIndex = 143;
         this.label11.Text = "Fornecedor";
         this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // cbxSize
         // 
         this.cbxSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxSize.Font = new System.Drawing.Font("Arial", 19.5F);
         this.cbxSize.FormattingEnabled = true;
         this.cbxSize.Location = new System.Drawing.Point(1063, 384);
         this.cbxSize.Name = "cbxSize";
         this.cbxSize.Size = new System.Drawing.Size(211, 39);
         this.cbxSize.TabIndex = 138;
         // 
         // cbxProvider
         // 
         this.cbxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbxProvider.Font = new System.Drawing.Font("Arial", 19.5F);
         this.cbxProvider.FormattingEnabled = true;
         this.cbxProvider.Location = new System.Drawing.Point(181, 500);
         this.cbxProvider.Name = "cbxProvider";
         this.cbxProvider.Size = new System.Drawing.Size(348, 39);
         this.cbxProvider.TabIndex = 138;
         // 
         // frmOperation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.ClientSize = new System.Drawing.Size(1284, 611);
         this.Controls.Add(this.nudAmount);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.txtType);
         this.Controls.Add(this.txtValueTotal);
         this.Controls.Add(this.txtValueUnit);
         this.Controls.Add(this.txtCode);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.dtpDate);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.cbxSize);
         this.Controls.Add(this.cbxStorageDestiny);
         this.Controls.Add(this.lblDestiny);
         this.Controls.Add(this.cbxProvider);
         this.Controls.Add(this.cbxStorageSource);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.groupBoxOperation);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pcbIcon);
         this.Controls.Add(this.pnlRodape);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.lbltitleForm);
         this.Controls.Add(this.btnSave);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(1300, 650);
         this.Name = "frmOperation";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Controle de Estoque - Projeto Piloto";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
         this.groupBoxOperation.ResumeLayout(false);
         this.groupBoxOperation.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltitleForm;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.RadioButton rbtTransfer;
        private System.Windows.Forms.RadioButton rbtOutput;
        private System.Windows.Forms.RadioButton rbtInput;
        private System.Windows.Forms.ComboBox cbxStorageSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDestiny;
        private System.Windows.Forms.ComboBox cbxStorageDestiny;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValueUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValueTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxProvider;
    }
}