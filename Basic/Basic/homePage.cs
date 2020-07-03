using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void createSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            ordering salesCreate = new ordering();
            salesCreate.Show();
        }

        private void salesOrderRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            //this.Hide();
            // ordering salesRecord = new ordering();
            //salesRecord.Show();
        }

        private void dispatchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            this.Hide();
            DIC dispatchNote = new DIC();
            dispatchNote.Show();
        }

        private void goodReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            this.Hide();
            DID did = new DID();
            did.Show();
        }

        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            this.Hide();
            StockRecord sr = new StockRecord();
            sr.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            this.Hide();
            GoodsReceivedNotes stockReport = new GoodsReceivedNotes();
            stockReport.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            //this.Hide();
            //PageName help = new PageName();
            //help.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes==
            MessageBox.Show("Log out the account?","Important", MessageBoxButtons.YesNo));
            {
                this.Hide();
                loginui logIn = new loginui();
                logIn.Show();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            salesRecord sales = new salesRecord();
            sales.Show();
            this.Hide();
        }
    }
}
