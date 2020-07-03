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
    public partial class dic_add : Form
    {
        MySqlConnection sqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=SDP");
        public dic_add()
        {
            InitializeComponent();
            DateTime d = new DateTime();
            d = DateTime.Now;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vDate = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            sqlCon.Open();
            string insertQuery = "INSERT INTO `dic`(`orderserial`, `date`, `invoicename`, `invoiceaddress`, `deliveryaddress`, `dealerorderno`, `desinstruct`) " +
                "VALUES('" + textBox8.Text + "','" + vDate + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dic_add_Load(object sender, EventArgs e)
        {

        }
    }
}
