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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.txtFilter = new System.Windows.Forms.TextBox();
         this.pnlRodape = new System.Windows.Forms.Panel();
         this.label5 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.rbtSize = new System.Windows.Forms.RadioButton();
         this.rbtDescription = new System.Windows.Forms.RadioButton();
         this.rbtType = new System.Windows.Forms.RadioButton();
         this.groupBoxFilter = new System.Windows.Forms.GroupBox();
         this.label3 = new System.Windows.Forms.Label();
         this.btnModify = new System.Windows.Forms.PictureBox();
         this.btnMovement = new System.Windows.Forms.PictureBox();
         this.btnRegister = new System.Windows.Forms.PictureBox();
         this.btnCancel = new System.Windows.Forms.PictureBox();
         this.pcbIcon = new System.Windows.Forms.PictureBox();
         this.btnDelete = new System.Windows.Forms.PictureBox();
         this.codproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.typeproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.descriptionproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.valuetotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.imageproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.statusproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.groupBoxFilter.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnMovement)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
         this.SuspendLayout();
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
            this.codproduct,
            this.typeproduct,
            this.descriptionproduct,
            this.provider,
            this.size,
            this.amount,
            this.valuetotal,
            this.storage,
            this.imageproduct,
            this.statusproduct});
         dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F);
         dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dgvData.DefaultCellStyle = dataGridViewCellStyle9;
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
         this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
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
         this.panel2.Location = new System.Drawing.Point(212, 162);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1072, 14);
         this.panel2.TabIndex = 106;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(282, 120);
         this.label1.Margin = new System.Windows.Forms.Padding(0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(131, 29);
         this.label1.TabIndex = 103;
         this.label1.Text = "PRODUTO";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // rbtSize
         // 
         this.rbtSize.AutoSize = true;
         this.rbtSize.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtSize.Location = new System.Drawing.Point(403, 36);
         this.rbtSize.Name = "rbtSize";
         this.rbtSize.Size = new System.Drawing.Size(119, 29);
         this.rbtSize.TabIndex = 39;
         this.rbtSize.Text = "Tamanho";
         this.rbtSize.UseVisualStyleBackColor = true;
         this.rbtSize.CheckedChanged += new System.EventHandler(this.rbtType_CheckedChanged);
         // 
         // rbtDescription
         // 
         this.rbtDescription.AutoSize = true;
         this.rbtDescription.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtDescription.Location = new System.Drawing.Point(201, 36);
         this.rbtDescription.Name = "rbtDescription";
         this.rbtDescription.Size = new System.Drawing.Size(128, 29);
         this.rbtDescription.TabIndex = 39;
         this.rbtDescription.Text = "Descrição";
         this.rbtDescription.UseVisualStyleBackColor = true;
         this.rbtDescription.CheckedChanged += new System.EventHandler(this.rbtType_CheckedChanged);
         // 
         // rbtType
         // 
         this.rbtType.AutoSize = true;
         this.rbtType.Checked = true;
         this.rbtType.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtType.Location = new System.Drawing.Point(29, 36);
         this.rbtType.Name = "rbtType";
         this.rbtType.Size = new System.Drawing.Size(73, 29);
         this.rbtType.TabIndex = 39;
         this.rbtType.TabStop = true;
         this.rbtType.Text = "Tipo";
         this.rbtType.UseVisualStyleBackColor = true;
         this.rbtType.CheckedChanged += new System.EventHandler(this.rbtType_CheckedChanged);
         // 
         // groupBoxFilter
         // 
         this.groupBoxFilter.Controls.Add(this.rbtSize);
         this.groupBoxFilter.Controls.Add(this.rbtDescription);
         this.groupBoxFilter.Controls.Add(this.rbtType);
         this.groupBoxFilter.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
         this.groupBoxFilter.ForeColor = System.Drawing.Color.White;
         this.groupBoxFilter.Location = new System.Drawing.Point(22, 230);
         this.groupBoxFilter.Name = "groupBoxFilter";
         this.groupBoxFilter.Size = new System.Drawing.Size(579, 80);
         this.groupBoxFilter.TabIndex = 112;
         this.groupBoxFilter.TabStop = false;
         this.groupBoxFilter.Text = "Filtrar Por";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(215, 91);
         this.label3.Margin = new System.Windows.Forms.Padding(0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(160, 29);
         this.label3.TabIndex = 103;
         this.label3.Text = "PESQUISAR ";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnModify
         // 
         this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnModify.Location = new System.Drawing.Point(753, 100);
         this.btnModify.Name = "btnModify";
         this.btnModify.Size = new System.Drawing.Size(160, 50);
         this.btnModify.TabIndex = 116;
         this.btnModify.TabStop = false;
         this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
         this.btnModify.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnModify.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
         // 
         // btnMovement
         // 
         this.btnMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnMovement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnMovement.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnMovement.Location = new System.Drawing.Point(543, 100);
         this.btnMovement.Name = "btnMovement";
         this.btnMovement.Size = new System.Drawing.Size(204, 50);
         this.btnMovement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.btnMovement.TabIndex = 114;
         this.btnMovement.TabStop = false;
         this.btnMovement.Click += new System.EventHandler(this.btnMovement_Click);
         this.btnMovement.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnMovement.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
         // 
         // btnRegister
         // 
         this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnRegister.Location = new System.Drawing.Point(361, 100);
         this.btnRegister.Name = "btnRegister";
         this.btnRegister.Size = new System.Drawing.Size(176, 50);
         this.btnRegister.TabIndex = 114;
         this.btnRegister.TabStop = false;
         this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
         this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCancel.Location = new System.Drawing.Point(1073, 100);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(176, 50);
         this.btnCancel.TabIndex = 108;
         this.btnCancel.TabStop = false;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
         // btnDelete
         // 
         this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnDelete.Location = new System.Drawing.Point(919, 100);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(148, 50);
         this.btnDelete.TabIndex = 115;
         this.btnDelete.TabStop = false;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         this.btnDelete.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
         this.btnDelete.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
         // 
         // codproduct
         // 
         this.codproduct.DataPropertyName = "codproduct";
         this.codproduct.HeaderText = "codigo";
         this.codproduct.Name = "codproduct";
         this.codproduct.ReadOnly = true;
         this.codproduct.Visible = false;
         // 
         // typeproduct
         // 
         this.typeproduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
         this.typeproduct.DataPropertyName = "typeproduct";
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         this.typeproduct.DefaultCellStyle = dataGridViewCellStyle2;
         this.typeproduct.HeaderText = "TIPO";
         this.typeproduct.Name = "typeproduct";
         this.typeproduct.ReadOnly = true;
         this.typeproduct.Width = 71;
         // 
         // descriptionproduct
         // 
         this.descriptionproduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
         this.descriptionproduct.DataPropertyName = "descriptionproduct";
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         this.descriptionproduct.DefaultCellStyle = dataGridViewCellStyle3;
         this.descriptionproduct.HeaderText = "DESCRIÇÃO";
         this.descriptionproduct.Name = "descriptionproduct";
         this.descriptionproduct.ReadOnly = true;
         this.descriptionproduct.Width = 131;
         // 
         // provider
         // 
         this.provider.DataPropertyName = "descriptionprovider";
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
         this.provider.DefaultCellStyle = dataGridViewCellStyle4;
         this.provider.HeaderText = "FORNECEDOR";
         this.provider.Name = "provider";
         this.provider.ReadOnly = true;
         // 
         // size
         // 
         this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
         this.size.DataPropertyName = "descriptionsize";
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
         this.size.DefaultCellStyle = dataGridViewCellStyle5;
         this.size.HeaderText = "TAMANHO";
         this.size.Name = "size";
         this.size.ReadOnly = true;
         this.size.Width = 114;
         // 
         // amount
         // 
         this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
         this.amount.DataPropertyName = "amount";
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle6.Format = "N0";
         dataGridViewCellStyle6.NullValue = "0";
         this.amount.DefaultCellStyle = dataGridViewCellStyle6;
         this.amount.HeaderText = "QTDE";
         this.amount.Name = "amount";
         this.amount.ReadOnly = true;
         this.amount.Width = 79;
         // 
         // valuetotal
         // 
         this.valuetotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
         this.valuetotal.DataPropertyName = "valuetotal";
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle7.Format = "C2";
         dataGridViewCellStyle7.NullValue = "0,00";
         this.valuetotal.DefaultCellStyle = dataGridViewCellStyle7;
         this.valuetotal.HeaderText = "VALOR TOTAL";
         this.valuetotal.Name = "valuetotal";
         this.valuetotal.ReadOnly = true;
         this.valuetotal.Width = 145;
         // 
         // storage
         // 
         this.storage.DataPropertyName = "descriptionstorage";
         dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
         this.storage.DefaultCellStyle = dataGridViewCellStyle8;
         this.storage.HeaderText = "ESTOQUE";
         this.storage.Name = "storage";
         this.storage.ReadOnly = true;
         // 
         // imageproduct
         // 
         this.imageproduct.DataPropertyName = "imageproduct";
         this.imageproduct.HeaderText = "image";
         this.imageproduct.Name = "imageproduct";
         this.imageproduct.ReadOnly = true;
         this.imageproduct.Visible = false;
         // 
         // statusproduct
         // 
         this.statusproduct.DataPropertyName = "statusproduct";
         this.statusproduct.HeaderText = "status";
         this.statusproduct.Name = "statusproduct";
         this.statusproduct.ReadOnly = true;
         this.statusproduct.Visible = false;
         // 
         // frmProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.ClientSize = new System.Drawing.Size(1284, 611);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnModify);
         this.Controls.Add(this.btnMovement);
         this.Controls.Add(this.btnRegister);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.pcbIcon);
         this.Controls.Add(this.dgvData);
         this.Controls.Add(this.txtFilter);
         this.Controls.Add(this.pnlRodape);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.groupBoxFilter);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(1300, 650);
         this.Name = "frmProduct";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Controle de Estoque - Projeto Piloto";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.groupBoxFilter.ResumeLayout(false);
         this.groupBoxFilter.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnMovement)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.PictureBox btnModify;
        private System.Windows.Forms.PictureBox btnRegister;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtSize;
        private System.Windows.Forms.RadioButton rbtDescription;
        private System.Windows.Forms.RadioButton rbtType;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.PictureBox btnMovement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuetotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn storage;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusproduct;
    }
}

