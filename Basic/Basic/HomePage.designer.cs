namespace Basic
{
    partial class homePage
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.information = new System.Windows.Forms.Label();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1114, 8);
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
            this.linkLabel2.Location = new System.Drawing.Point(1165, 8);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(28, 12);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ENG";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(1217, 8);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(42, 12);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Log out";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.SystemColors.Control;
            this.information.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.information.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.information.Location = new System.Drawing.Point(0, 666);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(1264, 15);
            this.information.TabIndex = 5;
            this.information.Text = "Address : 20 Tsing Yi Road, Tsing Yi Island, New Territories, Hong Kong     Tel :" +
    " 2388 2388     Fax : 2388 2389     E-mail : smart_luxury_motor@hotmail.com";
            this.information.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(122, 40);
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
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.information);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "homePage";
            this.Text = "Sales Processing & Stock Recording System";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

