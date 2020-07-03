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
    public partial class dic_mod : Form
    {
        MySqlConnection sqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=SDP");
        public dic_mod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vDate = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            sqlCon.Open();
            string updateQuery = "UPDATE dic SET date='" + vDate + "',invoicename='" + textBox9.Text + 
                "',invoiceaddress='" + textBox10.Text + "',deliveryaddress='" + textBox11.Text + "',desinstruct='" + 
                textBox13.Text +"' WHERE orderserial='" + textBox8.Text + "'";
            MySqlCommand command = new MySqlCommand(updateQuery, sqlCon);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlCon.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dic_mod_Load(object sender, EventArgs e)
        {

        }
    }
}
