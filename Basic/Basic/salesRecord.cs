using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Basic
{
    public partial class salesRecord : Form
    {
        String data;
        string con = "datasource=127.0.0.1;port=3306;username=root;password=";
        DataTable Data;
        String list;

        public salesRecord()
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
            if (DialogResult.Yes ==
            MessageBox.Show("Log out the account?", "Important", MessageBoxButtons.YesNo)) ;
            {
                this.Hide();
                loginui logIn = new loginui();
                logIn.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            salesRecord sales = new salesRecord();
            sales.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Show();
            if (radioButton1.Checked)
            {
                list = " GROUP BY ProductID ORDER BY SUM(Qty) DESC";
            }
            if (radioButton2.Checked)
            {
                list = " GROUP BY ProductID ORDER BY SUM(Qty) DESC";
            }
                string Query = "SELECT ProductID,SUM(Qty) FROM sdp.orderdetail WHERE OrderDate BETWEEN DATE_SUB(CURRENT_DATE(), INTERVAL "+comboBox1.Text+") AND CURRENT_DATE()"+list;
                MySqlConnection Database = new MySqlConnection(con);
                Database.Open();
                MySqlCommand cmd = new MySqlCommand(Query, Database);
                MySqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
                    chart1.Series["Total Sales Quantity"].Points.AddXY(dr.GetString("ProductID"),dr.GetInt32("SUM(Qty)"));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
            chart1.Series["Total Sales Quantity"].Points.Clear();
            chart1.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
            chart1.Series["Total Sales Quantity"].Points.Clear();
            chart1.Hide();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            chart1.Series["Total Sales Quantity"].Points.Clear();
            chart1.Hide();
        }

        private void salesRecord_Load(object sender, EventArgs e)
        {
            chart1.Hide();
        }
    }
}
