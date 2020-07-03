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
    public partial class did_add : Form
    {
        MySqlConnection sqlCon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=SDP");
        public did_add()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            string insertQuery = "INSERT INTO `did`(`orderno`, `dealerid`, `productid`, `category`, `orderqty`, `preoutstand`, `totalno`, `weight_kg`, `length_cm`, `width_cm`, `desInstruct`) " +
                "VALUES('" + textBox21.Text + "','" + textBox15.Text + "','" + textBox8.Text + "','" + textBox23.Text + "','" + textBox16.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox13.Text + "')";
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
