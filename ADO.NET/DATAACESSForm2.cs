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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string constring, qrystring;
        SqlCommand sqlcmd;
        SqlConnection sqlcon;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrystring = "select * from customers where country='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            da.Fill(ds, "customerInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customerinfo";

        }


        private void customerorders_Click(object sender, EventArgs e)
        {
            qrystring = "select c.customerID,c.companyname,c.Address,c.country,o.orderId,o.orderdate,o.shippeddate  from customers c join orders o on o.customerID = c.customerID";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            da.Fill(ds, "customerInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customerinfo";
        }

        private void pnameandpid_Click(object sender, EventArgs e)
        {
            qrystring = "select p.productID,p.productname,p.QuantityPerUnit,p.UnitPrice,c.categoryId,c.categoryname,c.Description  from categories c join products p on p.categoryID= c.categoryID";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "customerInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customerinfo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //uisng(sqlcon = new sqlconnection(constring)){} for starting and ending connection
            qrystring = "select count(OrderID) from orders";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            sqlcon.Open();
           
            MessageBox.Show("Total Number Of Order Placed:" + sqlcmd.ExecuteScalar().ToString());
            sqlcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qrystring = "select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            using (sqlcon = new SqlConnection(constring))
            {
                sqlcmd = new SqlCommand(qrystring, sqlcon);
                sqlcon.Open();
                da = new SqlDataAdapter(sqlcmd);
                ds.Clear();
                da.Fill(ds, "productinfo");
                DataTable dt = ds.Tables["productinfo"];
                var products = from product in dt.AsEnumerable()
                               where product.Field<decimal>("unitprice") >= 50
                               select new
                               {
                                   prodID = product["productID"],
                                   prodname = product["productname"],
                                   price = product["unitprice"],
                                   quantity = product["quantityperunit"]
                               };
                foreach(var product in products)
                {
                    MessageBox.Show("ProductID=" + product.prodID + "Name=" + product.prodname + "Price=" + product.price + "Quantity=" + product.quantity, "products with price<50.00");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            constring = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(constring);
            ds = new DataSet();

            sqlcon.Open();
            qrystring = "select distinct Country from customers";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
          
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Country"]);
            }
            dr.Close();
           
            sqlcon.Close();
        }
    }
}
