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
    public partial class grn_add : Form
    {
        MySqlConnection sqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=SDP");
        public grn_add()
        {
            InitializeComponent();
        }

        private void grn_add_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vDate = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            string vDate2 = DateTime.Parse(dateTimePicker2.Text).ToString("yyyy-MM-dd");
            sqlCon.Open();
            string insertQuery = "INSERT INTO `reorderrecord`(`reorderno`, `supplierid`, `productid`, `purchaseqty`, `reorderdate`, `receivedate`, `status`) " +
                "VALUES('" + textBox8.Text + "','" + textBox14.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + vDate + "','" + vDate2 + "','" + textBox13.Text + "')";
            MySqlCommand command = new MySqlCommand(insertQuery, sqlCon);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
