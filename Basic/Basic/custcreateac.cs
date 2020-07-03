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


namespace Basic
{
    public partial class custcreateac : Form
    {
        public custcreateac()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("please enter all blank ");
            }
            else
            {
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                string password = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(textBox2.Text)));
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
                string query = "INSERT INTO loginaccount(`loginid`, `password`, `rid`) VALUES ('" + textBox1.Text + "', '" + password + "', '1')";
                string query2 = "INSERT INTO dealerinfo(`dealerid`, `contactperson1`,`companyname`,`contactperson1phoneno`,`shippingaddress1`,`email`) VALUES ('" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox6.Text+ "', '"+ maskedTextBox1.Text+ "', '"+ textBox4.Text+ "', '"+textBox3.Text+"')";
                // Which could be translated manually to :
                // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
                MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);

                commandDatabase1.CommandTimeout = 60;
                commandDatabase2.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase1.ExecuteReader();
                    //MessageBox.Show("User succesfully registered");

                    databaseConnection.Close();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("the username already exists.Please use a different username");
                    else
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                    return;
                }
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();
                    MessageBox.Show("User succesfully registered");
                    this.Hide();
                    databaseConnection.Close();

                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("the email already exists.Please use a different email");
                    else
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                }
            }
        }



        }
    }

