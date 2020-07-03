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
using System.Globalization;

namespace Basic
{
    public partial class DIC : Form
    {
        public DIC()
        {
            InitializeComponent();
        }
        MySqlConnection sqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=SDP");
        
        private void Form1_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'sdpDataSet.dic' table. You can move, or remove it, as needed.
            this.dicTableAdapter.Fill(this.sdpDataSet.dic);
        }

        private void fasle(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            
            dic_add myForm = new dic_add();
            myForm.Show();

        }


        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dic_mod myForm = new dic_mod();
  
            myForm.textBox8.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            //string selectQuery = "Select date FROM "
            //MySqlCommand command = new MySqlCommand(selectQuery, sqlCon);
            //dgv1.CurrentRow.Cells[1].Value = myForm.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DateTime vDate = DateTime.ParseExact(dgv1.CurrentRow.Cells[1].Value.ToString(),"yyyy-MM-dd",null);

            //DateTime dt = DateTime.ParseExact(dgv1.CurrentRow.Cells.Value.ToString(), "yyyy-MM-dd", CultureInfoConverter.
            //DateTime dt = Value.Convert.ToDateTime(dsProduct.Tables["dic"].Rows[RowPosition]["date"].ToString());
            myForm.dateTimePicker1.Value = vDate;
            myForm.textBox9.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            myForm.textBox10.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            myForm.textBox11.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
            myForm.textBox12.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            myForm.textBox13.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
            myForm.ShowDialog();
            

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dicTableAdapter.Fill(this.sdpDataSet.dic);
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
            DataView DV = new DataView(sdpDataSet.dic);
            DV.RowFilter = string.Format("orderserial LIKE '%{0}%'", textBox1.Text);
            dgv1.DataSource = DV;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Order Serial")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Order Serial";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void salesRecordToolStripMenuItem_Click(object sender, EventArgs e)
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
