using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;


namespace Basic
{ 
    public partial class loginui : Form
    {
        private string id;
        public loginui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            custcreateac cac = new custcreateac();
            cac.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            string password = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(textBox3.Text)));
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "SELECT loginid, password FROM loginaccount where loginid = '"+ textBox4.Text + "' AND password = '"+password+"'and rid='1'";
            MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
            commandDatabase1.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader myData = commandDatabase1.ExecuteReader();
            if (!myData.HasRows)
            {
                MessageBox.Show("The user name or password is incorrect. Try again.");
                databaseConnection.Close();
            }
            else
            {custui custui = new custui();
                custui.setloginid(textBox4.Text);
                MessageBox.Show("Login succesfully!.");
                
                custui.Visible = true;
                this.Visible = false;
                databaseConnection.Close();

            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget f = new forget();
            f.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            string password = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(textBox1.Text)));
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "SELECT loginid, password FROM loginaccount where loginid = '" + textBox2.Text + "' AND password = '" + password + "'and rid='2'";
            MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
            commandDatabase1.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader myData = commandDatabase1.ExecuteReader();
            if (!myData.HasRows)
            {
                MessageBox.Show("The user name or password is incorrect. Try again.");
                databaseConnection.Close();
            }
            else
            {
                MessageBox.Show("Login succesfully!.");
                //填staff page名
                homePage staffui = new homePage();
                staffui.Visible = true;
                this.Visible = false;
                custui a = new custui();
                a.setloginid(textBox4.Text);
                databaseConnection.Close();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
