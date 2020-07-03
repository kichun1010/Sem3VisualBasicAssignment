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
    public partial class StockRecord : Form
    {
        string con = "datasource=127.0.0.1;port=3306;username=root;password=";
        string Query = "Select * from sdp.inventory";
        DataTable Data;


        public StockRecord()
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
            // ordering salesRecord = new ordering();
            //salesRecord.Show();
        }

        private void dispatchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            DIC dispatchNote = new DIC();
            dispatchNote.Show();
        }

        private void goodReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            //PageName goodReceive = new PageName();
            //goodReceive.Show();
        }

        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            StockRecord sr = new StockRecord();
            sr.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            GoodsReceivedNotes stockReport = new GoodsReceivedNotes();
            stockReport.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            //PageName help = new PageName();
            //help.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Log out the account?", "Important", MessageBoxButtons.YesNo)) 
            {
                //PageName logIn = new PageName();
                //logIn.Show();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            MySqlConnection Database = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(Query, Database);
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
            Data = new DataTable();
            sqlDA.Fill(Data);
            dataGridView1.DataSource = Data;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cc = "Select * From sdp.inventory where CategoryID = '" + comboBox1.Text + "'";
            MySqlConnection Database = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(cc, Database);
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
            Data = new DataTable();
            sqlDA.Fill(Data);
            dataGridView1.DataSource = Data;

        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            if (All.Checked==true) {
                ReOrder.Checked = false;
                Danger.Checked = false;
                All.Checked = true;
                checkBox3.Checked = false;

                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(Query, Database);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                Data = new DataTable();
                sqlDA.Fill(Data);
                dataGridView1.DataSource = Data;
            }
        }

        private void ReOrder_CheckedChanged(object sender, EventArgs e)
        {
            string re = Query + " where QtyInStock<=ReOrderLevel";
            if (ReOrder.Checked==true)
            {
                All.Checked = false;
                Danger.Checked = false;
                ReOrder.Checked = true;
                checkBox3.Checked = false;
                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(re, Database);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                Data = new DataTable();
                sqlDA.Fill(Data);
                dataGridView1.DataSource = Data;

            }
        }

        private void Danger_CheckedChanged(object sender, EventArgs e)
        {
            string dan = Query+ " where QtyInStock<=DangerLevel";
            if (Danger.Checked == true)
            {
                ReOrder.Checked = false;
                All.Checked = false;
                Danger.Checked = true;
                checkBox3.Checked = false;
                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(dan, Database);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                Data = new DataTable();
                sqlDA.Fill(Data);
                dataGridView1.DataSource = Data;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                DataView DV = new DataView(Data);
                DV.RowFilter = string.Format("ProductID LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter ProductID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter ProductID";
                textBox1.ForeColor = Color.DarkGray;
                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(Query, Database);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                Data = new DataTable();
                sqlDA.Fill(Data);
                dataGridView1.DataSource = Data;
            }
        }

 

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sure to delete this record?", "Warning", MessageBoxButtons.YesNo))
            {
                try { 
                dataGridView1.Show();
                groupBox1.Hide();
                groupBox3.Show();
                button5.Show();
                button6.Show();
                string productID = textBox2.Text;
                string del = "delete from sdp.inventory where ProductID = '" + productID+"'";
                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(del, Database);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                Data = new DataTable();
                sqlDA.Fill(Data);
                dataGridView1.DataSource = Data;
                MySqlCommand a = new MySqlCommand(Query, Database);
                MySqlDataAdapter aa = new MySqlDataAdapter(a);
                Data = new DataTable();
                aa.Fill(Data);
                dataGridView1.DataSource = Data;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("There is no such data.", "Error");
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sure to insert this data?", "Important", MessageBoxButtons.YesNo)) ;
            {
                dataGridView1.Show();
                groupBox1.Hide();
                groupBox3.Show();
                button5.Show();
                button6.Show();
                try
                {
                    if (checkBox1.Checked == true)
                    {
                        string insert = "INSERT INTO sdp.inventory (ProductID,CategoryID,SupplierID,QtyInStock,QtyReserved,QtyOnOrder,ReOrderQty,ReOrderLevel,DangerLevel,Location,SalesStatus) VALUES" +
                    " ('" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + numericUpDown1.Text + "','0','0','0','"+numericUpDown2.Text+ "','" +numericUpDown3.Text + "','" + textBox3.Text + "','" + checkBox1.Text + "')";
                        MySqlConnection Database = new MySqlConnection(con);
                        MySqlCommand cmd = new MySqlCommand(insert, Database);
                        MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                        Data = new DataTable();
                        sqlDA.Fill(Data);
                        dataGridView1.DataSource = Data;
                        MySqlCommand a = new MySqlCommand(Query, Database);
                        MySqlDataAdapter aa = new MySqlDataAdapter(a);
                        Data = new DataTable();
                        aa.Fill(Data);
                        dataGridView1.DataSource = Data;
                    }
                    else
                    {
                        string insert = "INSERT INTO sdp.inventory (ProductID,CategoryID,SupplierID,QtyInStock,QtyReserved,QtyOnOrder,ReOrderQty,ReOrderLevel,DangerLevel,Location,SalesStatus) VALUES" +
                    " ('" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + numericUpDown1.Text + "','0','0','0','" + numericUpDown2.Text + "','" + numericUpDown3.Text + "','" + textBox3.Text + "','" + checkBox2.Text + "')";
                        MySqlConnection Database = new MySqlConnection(con);
                        MySqlCommand cmd = new MySqlCommand(insert, Database);
                        MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                        Data = new DataTable();
                        sqlDA.Fill(Data);
                        dataGridView1.DataSource = Data;
                        MySqlCommand a = new MySqlCommand(Query, Database);
                        MySqlDataAdapter aa = new MySqlDataAdapter(a);
                        Data = new DataTable();
                        aa.Fill(Data);
                        dataGridView1.DataSource = Data;
                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("The data has been inseted already","Error");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sure to update this data?", "Warning", MessageBoxButtons.YesNo)) ;
            {
                dataGridView1.Show();
                groupBox1.Hide();
                groupBox3.Show();
                button5.Show();
                button6.Show();
                if (checkBox1.Checked == true)
                {
                    string update = "UPDATE sdp.inventory SET CategoryID='" + comboBox2.Text + "',SupplierID = '" + textBox4.Text + "',QtyInStock='" + numericUpDown1.Text + "',ReOrderLevel='"+numericUpDown2.Text + "',DangerLevel='"+numericUpDown3.Text + "',Location='" + textBox3.Text + "',SalesStatus='" + checkBox1.Text + "' where ProductID = '" +textBox2.Text+ "'";
                    MySqlConnection Database = new MySqlConnection(con);
                    MySqlCommand cmd = new MySqlCommand(update, Database);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    Data = new DataTable();
                    sqlDA.Fill(Data);
                    dataGridView1.DataSource = Data;
                    MySqlCommand a = new MySqlCommand(Query, Database);
                    MySqlDataAdapter aa = new MySqlDataAdapter(a);
                    Data = new DataTable();
                    aa.Fill(Data);
                    dataGridView1.DataSource = Data;
                }
                else
                {
                    string update = "UPDATE sdp.inventory SET CategoryID='" + comboBox2.Text + "',SupplierID = '" + textBox4.Text + "',QtyInStock='" + numericUpDown1.Text + "',ReOrderLevel='" + numericUpDown2.Text + "',DangerLevel='" + numericUpDown3.Text + "',Location='" + textBox3.Text + "',SalesStatus='" + checkBox2.Text + "' where ProductID = '" + textBox2.Text + "'";
                    MySqlConnection Database = new MySqlConnection(con);
                    MySqlCommand cmd = new MySqlCommand(update, Database);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    Data = new DataTable();
                    sqlDA.Fill(Data);
                    dataGridView1.DataSource = Data;
                    MySqlCommand a = new MySqlCommand(Query, Database);
                    MySqlDataAdapter aa = new MySqlDataAdapter(a);
                    Data = new DataTable();
                    aa.Fill(Data);
                    dataGridView1.DataSource = Data;
                }
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedRow;
            selectedRow = dataGridView1.Rows[index];
            String Pid = selectedRow.Cells[0].Value.ToString();
            Inventory_Detail id = new Inventory_Detail();
            id.passMsg(Pid.ToString());
            id.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Show();
            groupBox1.Hide();
            groupBox3.Show();
            button5.Show();
            button6.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            groupBox1.Show();
            groupBox3.Hide();
            button1.Hide();
            button4.Hide();
            button5.Hide();
            button3.Show();
            button6.Hide();
            textBox2.ReadOnly = false;
            textBox2.Text = null;
            comboBox2.Text = null;
            textBox4.Text = null;
            numericUpDown1.Text = null;
            textBox3.Text = null;
            numericUpDown2.Text = null;
            numericUpDown3.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string on = "UPDATE sdp.inventory SET status = 'On Sell' where ProductID = '" + textBox2.Text + "'";
            string off = "UPDATE sdp.inventory SET status = 'Off Sell' where ProductID = '" + textBox2.Text + "'";
            string checkStatus = "Select status From sdp.stockrecord where ProductID = '" + textBox2.Text + "'";
            if (checkStatus=="On Sell")
            {
                dataGridView1.Show();
                groupBox1.Hide();
                groupBox3.Show();
                button5.Show();
                button6.Show();
                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(off, Database);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                Data = new DataTable();
                sqlDA.Fill(Data);
                dataGridView1.DataSource = Data;
                MySqlCommand a = new MySqlCommand(Query, Database);
                MySqlDataAdapter aa = new MySqlDataAdapter(a);
                Data = new DataTable();
                aa.Fill(Data);
                dataGridView1.DataSource = Data;
            }
            else
            {
                dataGridView1.Show();
                groupBox1.Hide();
                groupBox3.Show();
                button5.Show();
                button6.Show();
                MySqlConnection Database = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand(on, Database);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                Data = new DataTable();
                sqlDA.Fill(Data);
                dataGridView1.DataSource = Data;
                MySqlCommand a = new MySqlCommand(Query, Database);
                MySqlDataAdapter aa = new MySqlDataAdapter(a);
                Data = new DataTable();
                aa.Fill(Data);
                dataGridView1.DataSource = Data;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void createSalesOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ordering salesCreate = new ordering();
            salesCreate.Show();
        }

        private void salesOrderRecordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            //this.Hide();
            // ordering salesRecord = new ordering();
            //salesRecord.Show();
        }

        private void dispatchNotesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DIC dispatchNote = new DIC();
            dispatchNote.Show();
        }

        private void goodReceiveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DID did = new DID();
            did.Show();
        }

        private void stockRecordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StockRecord sr = new StockRecord();
            sr.Show();
        }

        private void stockReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GoodsReceivedNotes stockReport = new GoodsReceivedNotes();
            stockReport.Show();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Log out the account?", "Important", MessageBoxButtons.YesNo))
            {
                this.Hide();
                loginui logIn = new loginui();
                logIn.Show();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            groupBox1.Show();
            groupBox3.Hide();
            button3.Hide();
            button6.Hide();
            button1.Show();
            button4.Show();
            button5.Hide();
            textBox2.ReadOnly = true;
            int index;
            index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow;
            selectedRow = dataGridView1.Rows[index];
            textBox2.Text = selectedRow.Cells[0].Value.ToString();
            comboBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox4.Text = selectedRow.Cells[2].Value.ToString();
            numericUpDown1.Text = selectedRow.Cells[3].Value.ToString();
            numericUpDown2.Text = selectedRow.Cells[7].Value.ToString();
            numericUpDown3.Text = selectedRow.Cells[8].Value.ToString();
            textBox3.Text = selectedRow.Cells[9].Value.ToString();
            string status = selectedRow.Cells[10].Value.ToString();
            if (status == "On Sell")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
                checkBox1.Checked = false;
            }
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                ReOrder.Checked = false;
                Danger.Checked = false;
                All.Checked = false;
                string re = Query + " where QtyInStock<ReOrderLevel AND QtyInStock >DangerLevel";
                    MySqlConnection Database = new MySqlConnection(con);
                    MySqlCommand cmd = new MySqlCommand(re, Database);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    Data = new DataTable();
                    sqlDA.Fill(Data);
                    dataGridView1.DataSource = Data;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            groupBox1.Hide();
            groupBox3.Show();
            button5.Show();
            button6.Show();
        }
    }
}
