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
using System.Security.Cryptography;
using Microsoft.VisualBasic;
namespace Basic
{
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
            string query = "SELECT loginid, email FROM loginaccount,dealerinfo WHERE loginid = '"+textBox1.Text+"' and email='"+textBox2.Text+"'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader myData = commandDatabase1.ExecuteReader();
            if (!myData.HasRows)
            {
                MessageBox.Show("The user name or email is incorrect. Try again.");
                databaseConnection.Close();
            }
            else
            {
                string input = Interaction.InputBox("please enter the Verification code in your email", "Verification", "Default", -1, -1); panel1.Hide();
                while (input != "1234")
                {
                    MessageBox.Show("Verification code error!");
                    input = Interaction.InputBox("please enter the Verification code in your email", "Verification", "", -1, -1); panel1.Hide();
                }
                if (input == "1234"){
                    panel1.Hide();
                    panel2.Visible = true;
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void forget_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("password not match");
                
            }
            else
            {
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                string password = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(textBox3.Text)));
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
                string query = "UPDATE loginaccount SET password = '" + password+ "'  WHERE loginid = '" + textBox1.Text + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
                try {
                    databaseConnection.Open();
                    commandDatabase1.ExecuteNonQuery();
                    MessageBox.Show("password changed!");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }
    }
}
