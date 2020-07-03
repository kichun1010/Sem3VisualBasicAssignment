using MySql.Data.MySqlClient;
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
    public partial class ordering : Form
    {
        int qty;
        double totalprice;
        public ordering()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private string id;

        public void setloginid(string ids)
        {
            id = ids;
        }

        public string getloginid()
        {
            return id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cat = comboBox1.Text;
            string sql = "select categoryid from category where categoryname = '" + cat + "'";
            DataTable DataTable1 = GetMyDataTable("127.0.0.1", "sdp", "root", "", sql);
            string id = DataTable1.Rows[0][0].ToString();
            string sql2;
            string text = textBox1.Text.Trim();
            if (text == "")
            {
                sql2 = "SELECT a2.productid as 'Product id',a2.productname as 'Product Name',a2.unitprice as 'Price',a2.productdescription as 'Description' FROM inventory a1,product a2 WHERE a1.productid = a2.productid and a1.categoryid = '" + id + "' order by a2.productid asc ";
            }
            else
            {
                sql2 = "SELECT a2.productid as 'Product id',a2.productname as 'Product Name',a2.unitprice as 'Price',a2.productdescription as 'Description' FROM inventory a1,product a2 WHERE a1.productid = a2.productid and a1.categoryid = '" + id + "'  and a2.productname like '%" + text + "%'  order by a2.productid asc ";
            }

            DataTable DataTable2 = GetMyDataTable("127.0.0.1", "sdp", "root", "", sql2);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = DataTable2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void ordering_Load(object sender, EventArgs e)
        {
            string sql = "select categoryname from category";
            DataTable myDataTable = GetMyDataTable("127.0.0.1", "sdp", "root", "", sql);
            comboBox1.DataSource = myDataTable;
            comboBox1.DisplayMember = "categoryname";
        }
        public static MySqlConnection MyOpenConn(string Server, string Database, string dbuid, string dbpwd)
        {
            string cnstr = string.Format("server={0};database={1};uid={2};pwd={3};Connect Timeout = 180; CharSet=utf8", Server, Database, dbuid, dbpwd);
            MySqlConnection icn = new MySqlConnection();
            icn.ConnectionString = cnstr;
            if (icn.State == ConnectionState.Open) icn.Close();
            icn.Open();
            return icn;
        }

        public static DataTable GetMyDataTable(string Server, string Database, string dbuid, string dbpwd, string SqlString)
        {
            DataTable myDataTable = new DataTable();
            MySqlConnection icn = null;
            icn = MyOpenConn(Server, Database, dbuid, dbpwd);
            MySqlCommand isc = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(isc);
            isc.Connection = icn;
            isc.CommandText = SqlString;
            isc.CommandTimeout = 600;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            myDataTable = ds.Tables[0];
            if (icn.State == ConnectionState.Open) icn.Close();
            return myDataTable;
        }

        public static void MySqlInsertUpdateDelete(string Server, string Database, string dbuid, string dbpwd, string SqlSelectString)
        {
            MySqlConnection icn = MyOpenConn(Server, Database, dbuid, dbpwd);
            MySqlCommand cmd = new MySqlCommand(SqlSelectString, icn);
            MySqlTransaction mySqlTransaction = icn.BeginTransaction();
            try
            {
                cmd.Transaction = mySqlTransaction;
                cmd.ExecuteNonQuery();
                mySqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                mySqlTransaction.Rollback();
                throw (ex);
            }
            if (icn.State == ConnectionState.Open) icn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        // {
        //  this.textBox2.Text = this.dataGridView1.CurrentRow.Cells["Product id"].Value.ToString();
        //   this.textBox2.Text = this.dataGridView1.CurrentRow.Cells["Product Name"].Value.ToString();
        //  this.textBox2.Text = this.dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
        //}

        // private void dataGridView1_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        // {

        //  this.textBox2.Text = this.dataGridView1.CurrentRow.Cells["Product id"].Value.ToString();
        // this.textBox2.Text = this.dataGridView1.CurrentRow.Cells["Product Name"].Value.ToString();
        // this.textBox2.Text = this.dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
        // }

        // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // {
        //   this.textBox2.Text = this.dataGridView1.CurrentRow.Cells["Product id"].Value.ToString();
        //   this.textBox3.Text = this.dataGridView1.CurrentRow.Cells["Product Name"].Value.ToString();
        //   this.textBox4.Text = this.dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
        //   }


        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text) == true || String.IsNullOrWhiteSpace(textBox3.Text) == true || String.IsNullOrWhiteSpace(textBox4.Text) == true || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("please enter all field and not order item less than 0");
                return;
            }
            int row = dataGridView2.RowCount-1;
            bool hasid = false;
            int hasindex = 0;
            if (dataGridView2.RowCount == 0)
            {
                var index = dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells["Productid"].Value = textBox2.Text;
                dataGridView2.Rows[index].Cells["ProductName"].Value = textBox3.Text;
                dataGridView2.Rows[index].Cells["Price"].Value = textBox4.Text;
                dataGridView2.Rows[index].Cells["quantity"].Value = numericUpDown1.Text;
                dataGridView2.Rows[index].Cells["total"].Value = Convert.ToDouble(Convert.ToDouble(numericUpDown1.Text)* Convert.ToDouble(textBox4.Text));
                priceandQtyCount();
                return;
            }
            for (int i = 0; i <= row; i++)
            {
                if (dataGridView2.Rows[i].Cells["Productid"].Value.ToString() == textBox2.Text)
                {
                    hasid = true;
                    hasindex = i;
                }
            }
            if (hasid == false)
            {
                var index = dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells["Productid"].Value = textBox2.Text;
                dataGridView2.Rows[index].Cells["ProductName"].Value = textBox3.Text;
                dataGridView2.Rows[index].Cells["Price"].Value = textBox4.Text;
                dataGridView2.Rows[index].Cells["quantity"].Value = numericUpDown1.Text;
                    dataGridView2.Rows[index].Cells["total"].Value = Convert.ToDouble(Convert.ToDouble(numericUpDown1.Text) * Convert.ToDouble(textBox4.Text));
                priceandQtyCount();
            }
            else
            {
                dataGridView2.Rows[hasindex].Cells["quantity"].Value = numericUpDown1.Text;
                dataGridView2.Rows[hasindex].Cells["total"].Value = Convert.ToDouble(Convert.ToDouble(numericUpDown1.Text) * Convert.ToDouble(textBox4.Text));
                priceandQtyCount();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
  
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();

            }
        }
        private void priceandQtyCount()
        {
            totalprice = 0;
            qty = 0;
            for (int row = this.dataGridView2.Rows.Count - 1; row >= 0; row--)
            {
                totalprice += Convert.ToDouble(dataGridView2.Rows[row].Cells["Price"].Value);
                qty += Convert.ToInt32(dataGridView2.Rows[row].Cells["quantity"].Value);
                label5.Text = "total price:" + totalprice;
                label6.Text = "total quantity:" + qty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
            priceandQtyCount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Sql = "select OrderNo from orderrecord where OrderNo like '%" + DateTime.Now.ToString("yyMMdd") + "%'";

            DataTable DataTable2 = GetMyDataTable("127.0.0.1", "sdp", "root", "", Sql);
            int num1 = DataTable2.Rows.Count;
            string num2 = num1.ToString().PadLeft(4, '0');
            string orderid = "s" + DateTime.Now.ToString("yyMMdd") + num2;
            DialogResult dialogResult = MessageBox.Show("Sure", "are you want to create order?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(" insert into orderdetail (OrderNo,ProductID,Qty,OrderDate,totalPrice) VALUES ('" + orderid + "',@productid,@qty,'" + DateTime.Now.ToString("yyyy-MM-dd ")+ "',@total)", con))
                        {
                            cmd.Parameters.AddWithValue("@productid", row.Cells["Productid"].Value);
                            cmd.Parameters.AddWithValue("@qty", row.Cells["quantity"].Value);
                            cmd.Parameters.AddWithValue("@total", row.Cells["total"].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                    string query = "INSERT INTO  orderrecord ( OrderNo, DealerID,OrderDate,Status,Remarks) VALUES ('" + orderid + "', '" + getloginid() + "', '"+ DateTime.Now.ToString("yyyy-MM-dd ") + "','pending','"+ textBox5.Text + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                    MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
                   try {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase1.ExecuteReader();
                        //MessageBox.Show("User succesfully registered");

                        databaseConnection.Close();
                    }
                catch (MySqlException ex)
                    {
                            MessageBox.Show(ex.Message);
                        return;
                    }
                MessageBox.Show("order create succesfully!");
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

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
    }
        }
    


    
