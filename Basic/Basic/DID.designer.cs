namespace Basic
{
    partial class DID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DID));
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.didDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.didBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdpDataSet = new Basic.sdpDataSet();
            this.orderdetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.information = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableAdapterManager = new Basic.sdpDataSetTableAdapters.TableAdapterManager();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderdetailTableAdapter = new Basic.sdpDataSetTableAdapters.orderdetailTableAdapter();
            this.orderdetailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderdetailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.didTableAdapter = new Basic.sdpDataSetTableAdapters.didTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.didDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.didBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingNavigator)).BeginInit();
            this.orderdetailBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(14, 12);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(229, 22);
            this.textBox14.TabIndex = 15;
            this.textBox14.Text = "Despatch Instructon Detail";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(919, 123);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(146, 37);
            this.Button2.TabIndex = 22;
            this.Button2.Text = "Refresh";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.didDataGridView);
            this.groupBox1.Controls.Add(this.orderdetailDataGridView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Button2);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Location = new System.Drawing.Point(78, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 450);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // didDataGridView
            // 
            this.didDataGridView.AutoGenerateColumns = false;
            this.didDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.didDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.didDataGridView.DataSource = this.didBindingSource;
            this.didDataGridView.Location = new System.Drawing.Point(45, 188);
            this.didDataGridView.Name = "didDataGridView";
            this.didDataGridView.RowTemplate.Height = 24;
            this.didDataGridView.Size = new System.Drawing.Size(1032, 220);
            this.didDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "orderno";
            this.dataGridViewTextBoxColumn2.HeaderText = "orderno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productid";
            this.dataGridViewTextBoxColumn3.HeaderText = "productid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dealerid";
            this.dataGridViewTextBoxColumn5.HeaderText = "dealerid";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn6.HeaderText = "category";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "orderqty";
            this.dataGridViewTextBoxColumn7.HeaderText = "orderqty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "preoutstand";
            this.dataGridViewTextBoxColumn8.HeaderText = "preoutstand";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "totalno";
            this.dataGridViewTextBoxColumn9.HeaderText = "totalno";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "weight_kg";
            this.dataGridViewTextBoxColumn10.HeaderText = "weight_kg";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "length_cm";
            this.dataGridViewTextBoxColumn11.HeaderText = "length_cm";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "width_cm";
            this.dataGridViewTextBoxColumn12.HeaderText = "width_cm";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "desInstruct";
            this.dataGridViewTextBoxColumn13.HeaderText = "desInstruct";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // didBindingSource
            // 
            this.didBindingSource.DataMember = "orderdetail_did";
            this.didBindingSource.DataSource = this.orderdetailBindingSource;
            // 
            // orderdetailBindingSource
            // 
            this.orderdetailBindingSource.DataMember = "orderdetail";
            this.orderdetailBindingSource.DataSource = this.sdpDataSet;
            // 
            // sdpDataSet
            // 
            this.sdpDataSet.DataSetName = "sdpDataSet";
            this.sdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdetailDataGridView
            // 
            this.orderdetailDataGridView.AutoGenerateColumns = false;
            this.orderdetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.orderdetailDataGridView.DataSource = this.orderdetailBindingSource;
            this.orderdetailDataGridView.Location = new System.Drawing.Point(292, 21);
            this.orderdetailDataGridView.Name = "orderdetailDataGridView";
            this.orderdetailDataGridView.RowTemplate.Height = 24;
            this.orderdetailDataGridView.Size = new System.Drawing.Size(528, 130);
            this.orderdetailDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add a Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(868, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Enter Order No.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.SystemColors.Control;
            this.information.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.information.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.information.Location = new System.Drawing.Point(0, 660);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(1284, 15);
            this.information.TabIndex = 13;
            this.information.Text = "Address : 20 Tsing Yi Road, Tsing Yi Island, New Territories, Hong Kong     Tel :" +
    " 2388 2388     Fax : 2388 2389     E-mail : smart_luxury_motor@hotmail.com";
            this.information.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(1242, 8);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(41, 12);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "LogOut";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(1186, 8);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(28, 12);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ENG";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1124, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(17, 12);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "簡";
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
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSalesOrderToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(160, 40);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Basic.Properties.Resources.CompanyName;
            this.pictureBox2.Location = new System.Drawing.Point(348, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(729, 144);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basic.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(142, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 144);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // orderdetailTableAdapter
            // 
            this.orderdetailTableAdapter.ClearBeforeFill = true;
            // 
            // orderdetailBindingNavigator
            // 
            this.orderdetailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderdetailBindingNavigator.BindingSource = this.orderdetailBindingSource;
            this.orderdetailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderdetailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderdetailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderdetailBindingNavigatorSaveItem});
            this.orderdetailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderdetailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderdetailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderdetailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderdetailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderdetailBindingNavigator.Name = "orderdetailBindingNavigator";
            this.orderdetailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderdetailBindingNavigator.Size = new System.Drawing.Size(1284, 25);
            this.orderdetailBindingNavigator.TabIndex = 16;
            this.orderdetailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // orderdetailBindingNavigatorSaveItem
            // 
            this.orderdetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderdetailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderdetailBindingNavigatorSaveItem.Image")));
            this.orderdetailBindingNavigatorSaveItem.Name = "orderdetailBindingNavigatorSaveItem";
            this.orderdetailBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderdetailBindingNavigatorSaveItem.Text = "Save Data";
            this.orderdetailBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderdetailBindingNavigatorSaveItem_Click);
            // 
            // didTableAdapter
            // 
            this.didTableAdapter.ClearBeforeFill = true;
            // 
            // DID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 675);
            this.Controls.Add(this.orderdetailBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.information);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "DID";
            this.Text = "Address : 20 Tsing Yi Road, Tsing Yi Island, New Territories, Hong Kong     Tel:2" +
    "388 2388     Fax:2399 2399     E-mail : smart_luxury@co.com";
            this.Load += new System.EventHandler(this.DID_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.didDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.didBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingNavigator)).EndInit();
            this.orderdetailBindingNavigator.ResumeLayout(false);
            this.orderdetailBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private sdpDataSet sdpDataSet;
        private sdpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource orderdetailBindingSource;
        private sdpDataSetTableAdapters.orderdetailTableAdapter orderdetailTableAdapter;
        private System.Windows.Forms.BindingNavigator orderdetailBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderdetailBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView orderdetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource didBindingSource;
        private sdpDataSetTableAdapters.didTableAdapter didTableAdapter;
        private System.Windows.Forms.DataGridView didDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}