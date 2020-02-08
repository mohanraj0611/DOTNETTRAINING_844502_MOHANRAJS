using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dataacessusingdataadapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string constring, qrystring;
        SqlCommand sqlcmd;
        SqlConnection sqlcon;
        SqlDataAdapter da;
        DataSet ds;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {
            qrystring = "select ProductID,ProductName,UnitPrice,QuantityPerUnit,categoryID from Products";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            da.Fill(ds, "ProductInfo");
            gvproducts.DataSource = ds;
            gvproducts.DataMember = "ProductInfo";
        }

        private void categoies_Click(object sender, EventArgs e)
        {
            qrystring = "select * from categories";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            da.Fill(ds, "categoriesInfo");
            gvproducts.DataSource = ds;
            gvproducts.DataMember = "categoriesInfo";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constring = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(constring);
            ds = new DataSet();

            sqlcon.Open();
        }
    }
}
