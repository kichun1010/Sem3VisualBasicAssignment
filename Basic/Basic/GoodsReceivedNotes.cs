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
    public partial class GoodsReceivedNotes : Form
    {
        public GoodsReceivedNotes()
        {
            InitializeComponent();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sdpDataSet.did' table. You can move, or remove it, as needed.
            this.reorderrecordTableAdapter.Fill(this.sdpDataSet.reorderrecord);
        }

        private void GoodsReceivedNotes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sdpDataSet.reorderrecord' table. You can move, or remove it, as needed.
            this.reorderrecordTableAdapter.Fill(this.sdpDataSet.reorderrecord);


        }

        private void reorderrecordDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grn_mod myForm = new grn_mod();

            myForm.textBox8.Text = reorderrecordDataGridView.CurrentRow.Cells[0].Value.ToString();
            myForm.textBox14.Text = reorderrecordDataGridView.CurrentRow.Cells[1].Value.ToString();
            myForm.textBox9.Text = reorderrecordDataGridView.CurrentRow.Cells[2].Value.ToString();
            myForm.textBox10.Text = reorderrecordDataGridView.CurrentRow.Cells[3].Value.ToString();
            DateTime vDate = DateTime.ParseExact(reorderrecordDataGridView.CurrentRow.Cells[4].Value.ToString(), "yyyy-MM-dd", null);
            myForm.dateTimePicker1.Value = vDate;
            DateTime vDate2 = DateTime.ParseExact(reorderrecordDataGridView.CurrentRow.Cells[5].Value.ToString(), "yyyy-MM-dd", null);
            myForm.dateTimePicker2.Value = vDate2;
            myForm.textBox13.Text = reorderrecordDataGridView.CurrentRow.Cells[6].Value.ToString();

            myForm.Show();
        }

        private void reorderrecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                DataView DV = new DataView(sdpDataSet.reorderrecord);
                DV.RowFilter = string.Format("ReOrderNo LIKE '%{0}%'", textBox1.Text);
                reorderrecordDataGridView.DataSource = DV;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter ReOrder No.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter ReOrder No.";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordering salesCreate = new ordering();
            salesCreate.Show();
        }

        private void salesOrderRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Log out the account?", "Important", MessageBoxButtons.YesNo)) ;
            {
                loginui logIn = new loginui();
                logIn.Show();
            }
        }

        private void reorderrecordDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sdpDataSet.did' table. You can move, or remove it, as needed.
            this.reorderrecordTableAdapter.Fill(this.sdpDataSet.reorderrecord);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grn_add myForm = new grn_add();
            myForm.Show();
        }

        private void reorderrecordDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
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
