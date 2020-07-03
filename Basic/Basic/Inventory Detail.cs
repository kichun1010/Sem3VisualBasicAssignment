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
    public partial class Inventory_Detail : Form
    {
        String data;
        string con = "datasource=127.0.0.1;port=3306;username=root;password=";
        DataTable Data;

        public Inventory_Detail()
        {
            InitializeComponent();
        }

        private void createSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesOrderRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dispatchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goodReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        public void passMsg(String msg)
        {
            data = msg.ToString();
            label19.Text = data;
        }

        private void Inventory_Detail_Load(object sender, EventArgs e)
        {
            
            string Query = "SELECT product.ProductID,ProductName,inventory.CategoryID," +
                "CategoryName,Weight_kg, Width_cm,Length_cm,ProductDescription,inventory.SupplierID,SupplierName" +
                ",QtyInStock,UnitPrice, Location, SalesStatus,DangerLevel,ReOrderLevel FROM sdp.category,sdp.inventory,sdp.product,sdp.supplier " +
                "WHERE supplier.SupplierID=inventory.SupplierID AND product.ProductID=inventory.ProductID " +
                "AND category.CategoryID=inventory.CategoryID AND product.ProductID='" + data + "';";
           MySqlConnection Database = new MySqlConnection(con);
            Database.Open();
            MySqlCommand cmd = new MySqlCommand(Query, Database);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label20.Text = (dr["ProductName"].ToString());
                label21.Text = (dr["CategoryID"].ToString());
                label22.Text = (dr["CategoryName"].ToString());
                label23.Text = (dr["Weight_kg"].ToString());
                label24.Text = (dr["Width_cm"].ToString());
                label25.Text = (dr["Length_cm"].ToString());
                label26.Text = (dr["ProductDescription"].ToString());
                label27.Text = (dr["SupplierID"].ToString());
                label28.Text = (dr["SupplierName"].ToString());
                label29.Text = (dr["QtyInStock"].ToString());
                label30.Text = (dr["UnitPrice"].ToString());
                label31.Text = (dr["ReOrderLevel"].ToString());
                label32.Text = (dr["DangerLevel"].ToString());
                label33.Text = (dr["Location"].ToString());
                label34.Text = (dr["SalesStatus"].ToString());
            }
            dr.Close();
            string sum = "SELECT SUM(Qty),SUM(totalPrice) FROM sdp.orderdetail WHERE MONTH(OrderDate) = MONTH(CURRENT_DATE()) AND YEAR(OrderDate)=YEAR(CURRENT_DATE) AND ProductID='"+data+"';";
            MySqlCommand cd = new MySqlCommand(sum, Database);
            MySqlDataReader su = cd.ExecuteReader();
            if (su.Read())
            {
                label35.Text = (su["SUM(Qty)"].ToString());
                label37.Text = (su["SUM(totalPrice)"].ToString());
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
