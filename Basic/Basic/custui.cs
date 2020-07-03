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
using MySql.Data;
namespace Basic
{
    
    public partial class custui : Form
    {
        loginui a = new loginui();
        public custui()
        {
            InitializeComponent();
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



        private void createSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            ordering salesCreate = new ordering();
            salesCreate.setloginid(getloginid());
            salesCreate.Show();
        }

        private void salesOrderRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
            //  PageName salesRecord = new PageName();
            //  salesRecord.Show();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
            string query = " SELECT * FROM orderrecord where dealerid = '" + id + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
            MySqlDataAdapter sqlad = new MySqlDataAdapter(commandDatabase1);

            DataTable dataTable = new DataTable();
            databaseConnection.Open();
            sqlad.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            panel1.Show();
        }

        private void dispatchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
          //  PageName dispatchNote = new PageName();
          //  dispatchNote.Show();
        }

        private void goodReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
          //  PageName goodReceive = new PageName();
           // goodReceive.Show();
        }

        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
          //  PageName stockRecord = new PageName();
           // stockRecord.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
         //   PageName stockReport = new PageName();
          //  stockRecord.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change page by clicking the item Fill in the page name
         //   PageName help = new PageName();
           // help.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Log out the account?", "Important", MessageBoxButtons.YesNo))
            {
                this.Hide();
                loginui logIn = new loginui();
                logIn.Show();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void custui_Load(object sender, EventArgs e)
        {
            loginui a = new loginui();
            panel1.Hide();
            // TODO: 這行程式碼會將資料載入 'sdpDataSet.orderrecord' 資料表。您可以視需要進行移動或移除。
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sdp;";
            string query = " SELECT * FROM orderrecord where dealerid = '"+id+ "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
            MySqlDataAdapter sqlad = new MySqlDataAdapter(commandDatabase1);

            DataTable dataTable = new DataTable();
            databaseConnection.Open();
            sqlad.Fill(dataTable);
            dataGridView1.DataSource = dataTable;




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sdpDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
