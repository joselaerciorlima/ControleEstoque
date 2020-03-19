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
         this.rbtDescription = new System.Windows.Forms.RadioButton();
         this.rbtType = new System.Windows.Forms.RadioButton();
         this.groupBoxFilter = new System.Windows.Forms.GroupBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnMovement = new System.Windows.Forms.PictureBox();
         this.btnCancel = new System.Windows.Forms.PictureBox();
         this.pcbIcon = new System.Windows.Forms.PictureBox();
         this.codmovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.typeoperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dateoperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.typeproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.descriptionproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.descriptionsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.descriptionstorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.descriptionprovider = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.valuetotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.rbtTransfer = new System.Windows.Forms.RadioButton();
         this.rbtOutput = new System.Windows.Forms.RadioButton();
         this.rbtInput = new System.Windows.Forms.RadioButton();
         this.rbtSize = new System.Windows.Forms.RadioButton();
         this.rbtAll = new System.Windows.Forms.RadioButton();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.groupBoxFilter.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.btnMovement)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvData
         // 
         this.dgvData.AllowUserToAddRows = false;
         this.dgvData.AllowUserToDeleteRows = false;
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
            this.codmovement,
            this.typeoperation,
            this.dateoperation,
            this.typeproduct,
            this.descriptionproduct,
            this.descriptionsize,
            this.descriptionstorage,
            this.descriptionprovider,
            this.amount,
            this.valuetotal});
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
         this.txtFilter.Location = new System.Drawing.Point(939, 272);
         this.txtFilter.Name = "txtFilter";
         this.txtFilter.Size = new System.Drawing.Size(323, 38);
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
         this.label5.Location = new System.Drawing.Point(934, 240);
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
         // rbtDescription
         // 
         this.rbtDescription.AutoSize = true;
         this.rbtDescription.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtDescription.Location = new System.Drawing.Point(106, 36);
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
         this.rbtType.Location = new System.Drawing.Point(21, 36);
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
         this.groupBoxFilter.Location = new System.Drawing.Point(540, 230);
         this.groupBoxFilter.Name = "groupBoxFilter";
         this.groupBoxFilter.Size = new System.Drawing.Size(381, 80);
         this.groupBoxFilter.TabIndex = 112;
         this.groupBoxFilter.TabStop = false;
         this.groupBoxFilter.Text = "Tipo de Filtro";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(217, 120);
         this.label1.Margin = new System.Windows.Forms.Padding(0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(390, 29);
         this.label1.TabIndex = 103;
         this.label1.Text = "HISTÓRICO DE MOVIMENTAÇÃO";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnMovement
         // 
         this.btnMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.btnMovement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnMovement.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnMovement.Location = new System.Drawing.Point(848, 100);
         this.btnMovement.Name = "btnMovement";
         this.btnMovement.Size = new System.Drawing.Size(219, 50);
         this.btnMovement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.btnMovement.TabIndex = 114;
         this.btnMovement.TabStop = false;
         this.btnMovement.Click += new System.EventHandler(this.btnMovement_Click);
         this.btnMovement.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
         this.btnMovement.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
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
         this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
         this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
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
         // codmovement
         // 
         this.codmovement.DataPropertyName = "codmovement";
         this.codmovement.HeaderText = "CODMOVIMENTO";
         this.codmovement.Name = "codmovement";
         this.codmovement.ReadOnly = true;
         this.codmovement.Visible = false;
         // 
         // typeoperation
         // 
         this.typeoperation.DataPropertyName = "typeoperation";
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         this.typeoperation.DefaultCellStyle = dataGridViewCellStyle2;
         this.typeoperation.HeaderText = "OPERAÇÃO";
         this.typeoperation.Name = "typeoperation";
         this.typeoperation.ReadOnly = true;
         // 
         // dateoperation
         // 
         this.dateoperation.DataPropertyName = "dateoperation";
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
         this.dateoperation.DefaultCellStyle = dataGridViewCellStyle3;
         this.dateoperation.HeaderText = "DATA";
         this.dateoperation.Name = "dateoperation";
         this.dateoperation.ReadOnly = true;
         // 
         // typeproduct
         // 
         this.typeproduct.DataPropertyName = "typeproduct";
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
         this.typeproduct.DefaultCellStyle = dataGridViewCellStyle4;
         this.typeproduct.HeaderText = "TIPO";
         this.typeproduct.Name = "typeproduct";
         this.typeproduct.ReadOnly = true;
         // 
         // descriptionproduct
         // 
         this.descriptionproduct.DataPropertyName = "descriptionproduct";
         this.descriptionproduct.HeaderText = "DESCRIÇÃO";
         this.descriptionproduct.Name = "descriptionproduct";
         this.descriptionproduct.ReadOnly = true;
         // 
         // descriptionsize
         // 
         this.descriptionsize.DataPropertyName = "descriptionsize";
         this.descriptionsize.HeaderText = "TAMANHO";
         this.descriptionsize.Name = "descriptionsize";
         this.descriptionsize.ReadOnly = true;
         // 
         // descriptionstorage
         // 
         this.descriptionstorage.DataPropertyName = "descriptionstorage";
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
         this.descriptionstorage.DefaultCellStyle = dataGridViewCellStyle5;
         this.descriptionstorage.HeaderText = "ESTOQUE";
         this.descriptionstorage.Name = "descriptionstorage";
         this.descriptionstorage.ReadOnly = true;
         // 
         // descriptionprovider
         // 
         this.descriptionprovider.DataPropertyName = "descriptionprovider";
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
         this.descriptionprovider.DefaultCellStyle = dataGridViewCellStyle6;
         this.descriptionprovider.HeaderText = "FORNECEDOR";
         this.descriptionprovider.Name = "descriptionprovider";
         this.descriptionprovider.ReadOnly = true;
         // 
         // amount
         // 
         this.amount.DataPropertyName = "amount";
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle7.Format = "N0";
         dataGridViewCellStyle7.NullValue = "0";
         this.amount.DefaultCellStyle = dataGridViewCellStyle7;
         this.amount.HeaderText = "QTDE";
         this.amount.Name = "amount";
         this.amount.ReadOnly = true;
         // 
         // valuetotal
         // 
         this.valuetotal.DataPropertyName = "valuetotal";
         dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 13F);
         dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle8.Format = "C2";
         dataGridViewCellStyle8.NullValue = "0,00";
         this.valuetotal.DefaultCellStyle = dataGridViewCellStyle8;
         this.valuetotal.HeaderText = "VALOR TOTAL";
         this.valuetotal.Name = "valuetotal";
         this.valuetotal.ReadOnly = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.rbtTransfer);
         this.groupBox1.Controls.Add(this.rbtAll);
         this.groupBox1.Controls.Add(this.rbtOutput);
         this.groupBox1.Controls.Add(this.rbtInput);
         this.groupBox1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
         this.groupBox1.ForeColor = System.Drawing.Color.White;
         this.groupBox1.Location = new System.Drawing.Point(22, 230);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(502, 80);
         this.groupBox1.TabIndex = 112;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Tipo de Operação";
         // 
         // rbtTransfer
         // 
         this.rbtTransfer.AutoSize = true;
         this.rbtTransfer.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtTransfer.Location = new System.Drawing.Point(321, 36);
         this.rbtTransfer.Name = "rbtTransfer";
         this.rbtTransfer.Size = new System.Drawing.Size(161, 29);
         this.rbtTransfer.TabIndex = 39;
         this.rbtTransfer.Text = "Transferência";
         this.rbtTransfer.UseVisualStyleBackColor = true;
         this.rbtTransfer.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
         // 
         // rbtOutput
         // 
         this.rbtOutput.AutoSize = true;
         this.rbtOutput.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtOutput.Location = new System.Drawing.Point(224, 36);
         this.rbtOutput.Name = "rbtOutput";
         this.rbtOutput.Size = new System.Drawing.Size(87, 29);
         this.rbtOutput.TabIndex = 39;
         this.rbtOutput.Text = "Saída";
         this.rbtOutput.UseVisualStyleBackColor = true;
         this.rbtOutput.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
         // 
         // rbtInput
         // 
         this.rbtInput.AutoSize = true;
         this.rbtInput.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtInput.Location = new System.Drawing.Point(109, 36);
         this.rbtInput.Name = "rbtInput";
         this.rbtInput.Size = new System.Drawing.Size(105, 29);
         this.rbtInput.TabIndex = 39;
         this.rbtInput.Text = "Entrada";
         this.rbtInput.UseVisualStyleBackColor = true;
         this.rbtInput.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
         // 
         // rbtSize
         // 
         this.rbtSize.AutoSize = true;
         this.rbtSize.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtSize.Location = new System.Drawing.Point(246, 36);
         this.rbtSize.Name = "rbtSize";
         this.rbtSize.Size = new System.Drawing.Size(119, 29);
         this.rbtSize.TabIndex = 39;
         this.rbtSize.Text = "Tamanho";
         this.rbtSize.UseVisualStyleBackColor = true;
         this.rbtSize.CheckedChanged += new System.EventHandler(this.rbtType_CheckedChanged);
         // 
         // rbtAll
         // 
         this.rbtAll.AutoSize = true;
         this.rbtAll.Checked = true;
         this.rbtAll.Font = new System.Drawing.Font("Arial", 16F);
         this.rbtAll.Location = new System.Drawing.Point(20, 36);
         this.rbtAll.Name = "rbtAll";
         this.rbtAll.Size = new System.Drawing.Size(79, 29);
         this.rbtAll.TabIndex = 39;
         this.rbtAll.TabStop = true;
         this.rbtAll.Text = "Tudo";
         this.rbtAll.UseVisualStyleBackColor = true;
         this.rbtAll.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
         // 
         // frmProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
         this.ClientSize = new System.Drawing.Size(1284, 611);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnMovement);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.pcbIcon);
         this.Controls.Add(this.dgvData);
         this.Controls.Add(this.txtFilter);
         this.Controls.Add(this.pnlRodape);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.groupBox1);
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
         ((System.ComponentModel.ISupportInitialize)(this.btnMovement)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtDescription;
        private System.Windows.Forms.RadioButton rbtType;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.PictureBox btnMovement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeoperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionstorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionprovider;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuetotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtTransfer;
        private System.Windows.Forms.RadioButton rbtOutput;
        private System.Windows.Forms.RadioButton rbtInput;
        private System.Windows.Forms.RadioButton rbtSize;
        private System.Windows.Forms.RadioButton rbtAll;
    }
}

