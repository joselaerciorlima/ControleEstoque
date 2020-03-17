namespace View
{
   partial class frmProduct
   {
      /// <summary>
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Windows Form Designer

      /// <summary>
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
         this.btnModify = new System.Windows.Forms.PictureBox();
         this.btnRegister = new System.Windows.Forms.PictureBox();
         this.btnCancel = new System.Windows.Forms.PictureBox();
         this.pcbIcon = new System.Windows.Forms.PictureBox();
         this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.typeproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.codproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.txtFilter = new System.Windows.Forms.TextBox();
         this.pnlRodape = new System.Windows.Forms.Panel();
         this.label5 = new System.Windows.Forms.Label();
         this.btnHome = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.rbtLocation = new System.Windows.Forms.RadioButton();
         this.rbtModel = new System.Windows.Forms.RadioButton();
         this.rbtType = new System.Windows.Forms.RadioButton();
         this.btnDelete = new System.Windows.Forms.PictureBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnModify
         // 
         this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnModify.Location = new System.Drawing.Point(753, 93);
         this.btnModify.Name = "btnModify";
         this.btnModify.Size = new System.Drawing.Size(160, 50);
         this.btnModify.TabIndex = 116;
         this.btnModify.TabStop = false;
         this.btnModify.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnModify.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
         // 
         // btnRegister
         // 
         this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnRegister.Location = new System.Drawing.Point(571, 93);
         this.btnRegister.Name = "btnRegister";
         this.btnRegister.Size = new System.Drawing.Size(176, 50);
         this.btnRegister.TabIndex = 114;
         this.btnRegister.TabStop = false;
         this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
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
         this.btnCancel.TabIndex = 108;
         this.btnCancel.TabStop = false;
         this.btnCancel.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnCancel.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
         // 
         // pcbIcon
         // 
         this.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.pcbIcon.Location = new System.Drawing.Point(22, 35);
         this.pcbIcon.Name = "pcbIcon";
         this.pcbIcon.Size = new System.Drawing.Size(171, 159);
         this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pcbIcon.TabIndex = 107;
         this.pcbIcon.TabStop = false;
         // 
         // status
         // 
         this.status.DataPropertyName = "status";
         this.status.HeaderText = "status";
         this.status.Name = "status";
         this.status.ReadOnly = true;
         this.status.Visible = false;
         // 
         // image
         // 
         this.image.DataPropertyName = "image";
         this.image.HeaderText = "image";
         this.image.Name = "image";
         this.image.ReadOnly = true;
         this.image.Visible = false;
         // 
         // filename
         // 
         this.filename.DataPropertyName = "filename";
         this.filename.HeaderText = "filename";
         this.filename.Name = "filename";
         this.filename.ReadOnly = true;
         this.filename.Visible = false;
         // 
         // amount
         // 
         this.amount.DataPropertyName = "amount";
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
         this.amount.DefaultCellStyle = dataGridViewCellStyle1;
         this.amount.FillWeight = 56.70259F;
         this.amount.HeaderText = "QTDE";
         this.amount.Name = "amount";
         this.amount.ReadOnly = true;
         // 
         // storage
         // 
         this.storage.DataPropertyName = "storage";
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         this.storage.DefaultCellStyle = dataGridViewCellStyle2;
         this.storage.FillWeight = 94.67348F;
         this.storage.HeaderText = "LOCALIZAÇÂO";
         this.storage.Name = "storage";
         this.storage.ReadOnly = true;
         // 
         // size
         // 
         this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
         this.size.DataPropertyName = "size";
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         this.size.DefaultCellStyle = dataGridViewCellStyle3;
         this.size.HeaderText = "TAMANHO";
         this.size.Name = "size";
         this.size.ReadOnly = true;
         this.size.Width = 114;
         // 
         // brand
         // 
         this.brand.DataPropertyName = "brand";
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
         this.brand.DefaultCellStyle = dataGridViewCellStyle4;
         this.brand.FillWeight = 74.52007F;
         this.brand.HeaderText = "MARCA";
         this.brand.Name = "brand";
         this.brand.ReadOnly = true;
         // 
         // model
         // 
         this.model.DataPropertyName = "model";
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
         this.model.DefaultCellStyle = dataGridViewCellStyle5;
         this.model.FillWeight = 144.3439F;
         this.model.HeaderText = "MODELO";
         this.model.Name = "model";
         this.model.ReadOnly = true;
         // 
         // typeproduct
         // 
         this.typeproduct.DataPropertyName = "typeproduct";
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
         this.typeproduct.DefaultCellStyle = dataGridViewCellStyle6;
         this.typeproduct.FillWeight = 151.3513F;
         this.typeproduct.HeaderText = "TIPO";
         this.typeproduct.Name = "typeproduct";
         this.typeproduct.ReadOnly = true;
         // 
         // codproduct
         // 
         this.codproduct.DataPropertyName = "codproduct";
         this.codproduct.HeaderText = "codigo";
         this.codproduct.Name = "codproduct";
         this.codproduct.ReadOnly = true;
         this.codproduct.Visible = false;
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
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
         dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
         dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
         this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codproduct,
            this.typeproduct,
            this.model,
            this.brand,
            this.size,
            this.storage,
            this.amount,
            this.filename,
            this.image,
            this.status});
         dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvData.DefaultCellStyle = dataGridViewCellStyle8;
         this.dgvData.Location = new System.Drawing.Point(22, 341);
         this.dgvData.MultiSelect = false;
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.RowHeadersVisible = false;
         this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvData.Size = new System.Drawing.Size(1240, 226);
         this.dgvData.TabIndex = 113;
         // 
         // txtFilter
         // 
         this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtFilter.Font = new System.Drawing.Font("Arial", 20F);
         this.txtFilter.Location = new System.Drawing.Point(626, 262);
         this.txtFilter.Name = "txtFilter";
         this.txtFilter.Size = new System.Drawing.Size(636, 38);
         this.txtFilter.TabIndex = 111;
         // 
         // pnlRodape
         // 
         this.pnlRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pnlRodape.BackColor = System.Drawing.Color.White;
         this.pnlRodape.Location = new System.Drawing.Point(0, 591);
         this.pnlRodape.Name = "pnlRodape";
         this.pnlRodape.Size = new System.Drawing.Size(1284, 20);
         this.pnlRodape.TabIndex = 110;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(621, 230);
         this.label5.Margin = new System.Windows.Forms.Padding(0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(81, 29);
         this.label5.TabIndex = 102;
         this.label5.Text = "Filtro:";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnHome
         // 
         this.btnHome.AutoSize = true;
         this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnHome.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnHome.ForeColor = System.Drawing.Color.White;
         this.btnHome.Location = new System.Drawing.Point(205, 99);
         this.btnHome.Margin = new System.Windows.Forms.Padding(0);
         this.btnHome.Name = "btnHome";
         this.btnHome.Size = new System.Drawing.Size(59, 39);
         this.btnHome.TabIndex = 104;
         this.btnHome.Text = "HOME";
         this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
         this.label2.TabIndex = 105;
         this.label2.Text = "CONTROLE DE ESTOQUE";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel2
         // 
         this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel2.BackColor = System.Drawing.Color.White;
         this.panel2.Location = new System.Drawing.Point(212, 155);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1072, 14);
         this.panel2.TabIndex = 106;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(277, 109);
         this.label1.Margin = new System.Windows.Forms.Padding(0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(147, 29);
         this.label1.TabIndex = 103;
         this.label1.Text = "PRODUTOS";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(257, 92);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(31, 45);
         this.label3.TabIndex = 109;
         this.label3.Text = "|";
         // 
         // rbtLocation
         // 
         this.rbtLocation.AutoSize = true;
         this.rbtLocation.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtLocation.Location = new System.Drawing.Point(387, 36);
         this.rbtLocation.Name = "rbtLocation";
         this.rbtLocation.Size = new System.Drawing.Size(146, 29);
         this.rbtLocation.TabIndex = 39;
         this.rbtLocation.TabStop = true;
         this.rbtLocation.Text = "Localização";
         this.rbtLocation.UseVisualStyleBackColor = true;
         // 
         // rbtModel
         // 
         this.rbtModel.AutoSize = true;
         this.rbtModel.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtModel.Location = new System.Drawing.Point(193, 36);
         this.rbtModel.Name = "rbtModel";
         this.rbtModel.Size = new System.Drawing.Size(103, 29);
         this.rbtModel.TabIndex = 39;
         this.rbtModel.TabStop = true;
         this.rbtModel.Text = "Modelo";
         this.rbtModel.UseVisualStyleBackColor = true;
         // 
         // rbtType
         // 
         this.rbtType.AutoSize = true;
         this.rbtType.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtType.Location = new System.Drawing.Point(29, 36);
         this.rbtType.Name = "rbtType";
         this.rbtType.Size = new System.Drawing.Size(73, 29);
         this.rbtType.TabIndex = 39;
         this.rbtType.TabStop = true;
         this.rbtType.Text = "Tipo";
         this.rbtType.UseVisualStyleBackColor = true;
         // 
         // btnDelete
         // 
         this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnDelete.Location = new System.Drawing.Point(919, 93);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(148, 50);
         this.btnDelete.TabIndex = 115;
         this.btnDelete.TabStop = false;
         this.btnDelete.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnDelete.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.rbtLocation);
         this.groupBox1.Controls.Add(this.rbtModel);
         this.groupBox1.Controls.Add(this.rbtType);
         this.groupBox1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
         this.groupBox1.ForeColor = System.Drawing.Color.White;
         this.groupBox1.Location = new System.Drawing.Point(22, 230);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(579, 80);
         this.groupBox1.TabIndex = 112;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Filtrar Por";
         // 
         // frmProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.ClientSize = new System.Drawing.Size(1284, 611);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnModify);
         this.Controls.Add(this.btnRegister);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.pcbIcon);
         this.Controls.Add(this.dgvData);
         this.Controls.Add(this.txtFilter);
         this.Controls.Add(this.pnlRodape);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.btnHome);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(1300, 650);
         this.Name = "frmProduct";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Controle de Estoque - Projeto Piloto";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.PictureBox btnModify;
        private System.Windows.Forms.PictureBox btnRegister;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn storage;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproduct;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtLocation;
        private System.Windows.Forms.RadioButton rbtModel;
        private System.Windows.Forms.RadioButton rbtType;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

