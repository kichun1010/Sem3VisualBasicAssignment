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
    public partial class did_mod : Form
    {
        MySqlConnection sqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=SDP");
        public did_mod()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void did_mod_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            string updateQuery = "UPDATE `did` SET `orderqty`='" + textBox16.Text + "',`preoutstand`='" + textBox9.Text +
                "',`totalno`='" + textBox10.Text + "',`desinstruct`='" + textBox13.Text + "' WHERE `did`.`orderno`='"
                + textBox21.Text + "'";
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
    }
}
