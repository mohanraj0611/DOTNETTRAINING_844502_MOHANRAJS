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

namespace database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlCommand sqlcmd;
        SqlConnection sqlcon;
        SqlDataReader dr;
        string constring, qrystring;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrystring = "select unitprice from products where productname='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            sqlcon.Open();
            price.Text = "price" + sqlcmd.ExecuteScalar().ToString();
            sqlcon.Close();
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            qrystring = "update products set unitprice=" + Convert.ToDouble(textBox1.Text) + "where productname='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Product updated,New Product Price");
            sqlcon.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            constring = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(constring);

           
            qrystring = "select productname from products";

            sqlcmd = new SqlCommand(qrystring, sqlcon);
            sqlcon.Open();
            dr = sqlcmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr["productname"]);
            }
            dr.Close();
            sqlcon.Close();
            comboBox1.Text = "ALL PRODUCTS";


            

        }
    }
}
