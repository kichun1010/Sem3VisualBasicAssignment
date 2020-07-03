namespace Basic
{
    partial class DIC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.information = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.orderserialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerordernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desinstructDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new Basic.sdpDataSet();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dealerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Basic.sdpDataSetTableAdapters.TableAdapterManager();
            this.deliverynoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.despatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dicTableAdapter = new Basic.sdpDataSetTableAdapters.dicTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSalesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodReceiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despatchBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1136, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(17, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "簡";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(1188, 8);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(28, 12);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ENG";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(1242, 8);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(41, 12);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "LogOut";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.SystemColors.Control;
            this.information.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.information.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.information.Location = new System.Drawing.Point(0, 632);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(1284, 15);
            this.information.TabIndex = 5;
            this.information.Text = "Address : 20 Tsing Yi Road, Tsing Yi Island, New Territories, Hong Kong     Tel :" +
    " 2388 2388     Fax : 2388 2389     E-mail : smart_luxury_motor@hotmail.com";
            this.information.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Button2);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Location = new System.Drawing.Point(68, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 393);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(938, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Enter Order Serial";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(739, 337);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(146, 37);
            this.Button2.TabIndex = 22;
            this.Button2.Text = "Refresh";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(919, 337);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(156, 37);
            this.Button1.TabIndex = 20;
            this.Button1.Text = "Add New DIC";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dgv1
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderserialDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.invoicenameDataGridViewTextBoxColumn,
            this.invoiceaddressDataGridViewTextBoxColumn,
            this.deliveryaddressDataGridViewTextBoxColumn,
            this.dealerordernoDataGridViewTextBoxColumn,
            this.desinstructDataGridViewTextBoxColumn});
            this.dgv1.DataSource = this.dicBindingSource;
            this.dgv1.Location = new System.Drawing.Point(53, 50);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(1022, 270);
            this.dgv1.TabIndex = 21;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            // 
            // orderserialDataGridViewTextBoxColumn
            // 
            this.orderserialDataGridViewTextBoxColumn.DataPropertyName = "orderserial";
            this.orderserialDataGridViewTextBoxColumn.HeaderText = "Order Serial";
            this.orderserialDataGridViewTextBoxColumn.Name = "orderserialDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // invoicenameDataGridViewTextBoxColumn
            // 
            this.invoicenameDataGridViewTextBoxColumn.DataPropertyName = "invoicename";
            this.invoicenameDataGridViewTextBoxColumn.HeaderText = "Invoice Name";
            this.invoicenameDataGridViewTextBoxColumn.Name = "invoicenameDataGridViewTextBoxColumn";
            // 
            // invoiceaddressDataGridViewTextBoxColumn
            // 
            this.invoiceaddressDataGridViewTextBoxColumn.DataPropertyName = "invoiceaddress";
            this.invoiceaddressDataGridViewTextBoxColumn.HeaderText = "Invoice Address";
            this.invoiceaddressDataGridViewTextBoxColumn.Name = "invoiceaddressDataGridViewTextBoxColumn";
            this.invoiceaddressDataGridViewTextBoxColumn.Width = 130;
            // 
            // deliveryaddressDataGridViewTextBoxColumn
            // 
            this.deliveryaddressDataGridViewTextBoxColumn.DataPropertyName = "deliveryaddress";
            this.deliveryaddressDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
            this.deliveryaddressDataGridViewTextBoxColumn.Name = "deliveryaddressDataGridViewTextBoxColumn";
            this.deliveryaddressDataGridViewTextBoxColumn.Width = 130;
            // 
            // dealerordernoDataGridViewTextBoxColumn
            // 
            this.dealerordernoDataGridViewTextBoxColumn.DataPropertyName = "dealerorderno";
            this.dealerordernoDataGridViewTextBoxColumn.HeaderText = "Dealer Order No.";
            this.dealerordernoDataGridViewTextBoxColumn.Name = "dealerordernoDataGridViewTextBoxColumn";
            this.dealerordernoDataGridViewTextBoxColumn.Width = 150;
            // 
            // desinstructDataGridViewTextBoxColumn
            // 
            this.desinstructDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desinstructDataGridViewTextBoxColumn.DataPropertyName = "desinstruct";
            this.desinstructDataGridViewTextBoxColumn.HeaderText = "Despatch Instruction";
            this.desinstructDataGridViewTextBoxColumn.Name = "desinstructDataGridViewTextBoxColumn";
            // 
            // dicBindingSource
            // 
            this.dicBindingSource.DataMember = "dic";
            this.dicBindingSource.DataSource = this.sdpDataSet;
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(14, 12);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(229, 22);
            this.textBox14.TabIndex = 15;
            this.textBox14.Text = "Despatch Instructon Cover";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Basic.Properties.Resources.CompanyName;
            this.pictureBox2.Location = new System.Drawing.Point(338, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(729, 144);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basic.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(132, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dealerinfoBindingSource
            // 
            this.dealerinfoBindingSource.DataMember = "dealerinfo";
            this.dealerinfoBindingSource.DataSource = this.sdpDataSet;
            // 
            // sdpDataSetBindingSource
            // 
            this.sdpDataSetBindingSource.DataSource = this.sdpDataSet;
            this.sdpDataSetBindingSource.Position = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.sdpDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.dealerinfoTableAdapter = null;
            this.tableAdapterManager.deliverynoteTableAdapter = null;
            this.tableAdapterManager.dicTableAdapter = null;
            this.tableAdapterManager.didTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.loginaccountTableAdapter = null;
            this.tableAdapterManager.orderdetailTableAdapter = null;
            this.tableAdapterManager.orderrecordTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.reorderrecordTableAdapter = null;
            this.tableAdapterManager.staffinfoTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Basic.sdpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deliverynoteBindingSource
            // 
            this.deliverynoteBindingSource.DataMember = "deliverynote";
            this.deliverynoteBindingSource.DataSource = this.sdpDataSet;
            // 
            // despatchBindingSource
            // 
            this.despatchBindingSource.DataMember = "despatch";
            this.despatchBindingSource.DataSource = this.sdpDataSet;
            // 
            // dicTableAdapter
            // 
            this.dicTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.stockToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(310, 143);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 45);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSalesOrderToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(122, 40);
            this.homeToolStripMenuItem.Text = "Sales";
            // 
            // createSalesOrderToolStripMenuItem
            // 
            this.createSalesOrderToolStripMenuItem.AutoSize = false;
            this.createSalesOrderToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.createSalesOrderToolStripMenuItem.Name = "createSalesOrderToolStripMenuItem";
            this.createSalesOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 40);
            this.createSalesOrderToolStripMenuItem.Text = "Create Sales Order";
            this.createSalesOrderToolStripMenuItem.Click += new System.EventHandler(this.createSalesOrderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispatchNotesToolStripMenuItem,
            this.goodReceiveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 40);
            this.toolStripMenuItem1.Text = "Dispatch";
            // 
            // dispatchNotesToolStripMenuItem
            // 
            this.dispatchNotesToolStripMenuItem.AutoSize = false;
            this.dispatchNotesToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.dispatchNotesToolStripMenuItem.Name = "dispatchNotesToolStripMenuItem";
            this.dispatchNotesToolStripMenuItem.Size = new System.Drawing.Size(221, 40);
            this.dispatchNotesToolStripMenuItem.Text = "Despatch Instructon Cover";
            this.dispatchNotesToolStripMenuItem.Click += new System.EventHandler(this.dispatchNotesToolStripMenuItem_Click);
            // 
            // goodReceiveToolStripMenuItem
            // 
            this.goodReceiveToolStripMenuItem.AutoSize = false;
            this.goodReceiveToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.goodReceiveToolStripMenuItem.Name = "goodReceiveToolStripMenuItem";
            this.goodReceiveToolStripMenuItem.Size = new System.Drawing.Size(221, 40);
            this.goodReceiveToolStripMenuItem.Text = "Despatch Instructon Detail";
            this.goodReceiveToolStripMenuItem.Click += new System.EventHandler(this.goodReceiveToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.AutoSize = false;
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockRecordToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.toolStripMenuItem2});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(160, 40);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // stockRecordToolStripMenuItem
            // 
            this.stockRecordToolStripMenuItem.AutoSize = false;
            this.stockRecordToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.stockRecordToolStripMenuItem.Name = "stockRecordToolStripMenuItem";
            this.stockRecordToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.stockRecordToolStripMenuItem.Text = "Stock Record";
            this.stockRecordToolStripMenuItem.Click += new System.EventHandler(this.stockRecordToolStripMenuItem_Click);
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.AutoSize = false;
            this.stockReportToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.stockReportToolStripMenuItem.Text = "Goods Inwards Record";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 40);
            this.toolStripMenuItem2.Text = "Sales Report";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AutoSize = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(160, 40);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // DIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 647);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.information);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DIC";
            this.Text = "Address : 20 Tsing Yi Road, Tsing Yi Island, New Territories, Hong Kong     Tel:2" +
    "388 2388     Fax:2399 2399     E-mail : smart_luxury@co.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox14;
        private sdpDataSet sdpDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource sdpDataSetBindingSource;
        private System.Windows.Forms.BindingSource dealerinfoBindingSource;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource deliverynoteBindingSource;
        private System.Windows.Forms.BindingSource despatchBindingSource;
        private System.Windows.Forms.BindingSource dicBindingSource;
        private sdpDataSetTableAdapters.dicTableAdapter dicTableAdapter;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderserialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerordernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desinstructDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSalesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dispatchNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodReceiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

