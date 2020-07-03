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
    public partial class grn_mod : Form
    {
        MySqlConnection sqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=SDP");
        public grn_mod()
        {
            InitializeComponent();
        }

        private void grn_mod_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vDate = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            string vDate2 = DateTime.Parse(dateTimePicker2.Text).ToString("yyyy-MM-dd");
            sqlCon.Open();
            string updateQuery = "UPDATE reorderrecord SET supplierid='" + textBox14.Text + "',productid='" + textBox9.Text +
                "',purchaseqty='" + textBox10.Text + "',reorderdate='" + vDate + "',receiveDate='" +
                vDate2 + "',status='" + textBox13.Text + "'WHERE reorderrecord.reorderno='" + textBox8.Text + "'";
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

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
