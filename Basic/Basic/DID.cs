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
    public partial class DID : Form
    {
        public DID()
        {
            InitializeComponent();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void DID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sdpDataSet.did' table. You can move, or remove it, as needed.
            this.didTableAdapter.Fill(this.sdpDataSet.did);
            // TODO: This line of code loads data into the 'sdpDataSet.orderdetail' table. You can move, or remove it, as needed.
            this.orderdetailTableAdapter.Fill(this.sdpDataSet.orderdetail);
            // TODO: This line of code loads data into the 'sdpDataSet.did' table. You can move, or remove it, as needed.
            this.didTableAdapter.Fill(this.sdpDataSet.did);
            // TODO: This line of code loads data into the 'sdpDataSet.orderdetail' table. You can move, or remove it, as needed.
            this.orderdetailTableAdapter.Fill(this.sdpDataSet.orderdetail);
        }

        private void orderdetailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        

        }



        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            did_mod myForm = new did_mod();

            myForm.textBox21.Text = didDataGridView.CurrentRow.Cells[0].Value.ToString();
            myForm.textBox15.Text = didDataGridView.CurrentRow.Cells[1].Value.ToString();
            myForm.textBox8.Text = didDataGridView.CurrentRow.Cells[2].Value.ToString();
            myForm.textBox23.Text = didDataGridView.CurrentRow.Cells[3].Value.ToString();
            myForm.textBox16.Text = didDataGridView.CurrentRow.Cells[4].Value.ToString();
            myForm.textBox9.Text = didDataGridView.CurrentRow.Cells[5].Value.ToString();
            myForm.textBox10.Text = didDataGridView.CurrentRow.Cells[6].Value.ToString();
            myForm.textBox12.Text = didDataGridView.CurrentRow.Cells[7].Value.ToString();
            myForm.textBox19.Text = didDataGridView.CurrentRow.Cells[8].Value.ToString();
            myForm.textBox20.Text = didDataGridView.CurrentRow.Cells[9].Value.ToString();
            myForm.textBox13.Text = didDataGridView.CurrentRow.Cells[10].Value.ToString();

            myForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.orderdetailTableAdapter.Fill(this.sdpDataSet.orderdetail);
            this.didTableAdapter.Fill(this.sdpDataSet.did);
            MessageBox.Show("Refreshed");
            
        }

        private void createSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            this.Hide();
            DIC dispatchNote = new DIC();
            dispatchNote.Show();
        }

        private void goodReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DID did = new DID();
            did.Show();
        }

        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockRecord sr = new StockRecord();
            sr.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoodsReceivedNotes stockReport = new GoodsReceivedNotes();
            stockReport.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes ==
    MessageBox.Show("Log out the account?", "Important", MessageBoxButtons.YesNo))
            {
                this.Hide();
                loginui logIn = new loginui();
                logIn.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(sdpDataSet.did);
            DV.RowFilter = string.Format("orderno LIKE '%{0}%'", textBox1.Text);
            orderdetailDataGridView.DataSource = DV;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Order No.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Order No.";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            did_add myForm = new did_add();
            myForm.Show();
        }

        private void orderdetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderdetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sdpDataSet);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            salesRecord sales = new salesRecord();
            sales.Show();
            this.Hide();
        }
    }
}
