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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;




        private void btngetproduct_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            qryString = "select productname from products";
            sqlCmd = new SqlCommand(qryString, sqlcon);

            dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                listBox1.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlcon.Close();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select UnitPrice from products where ProductName ='" + comboBox1.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlcon);
            sqlcon.Open();
            price.Text = "Unit Price:" + sqlCmd.ExecuteScalar().ToString();
            sqlcon.Close();
               


        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           conString= "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(conString);

            sqlcon.Open();

            qryString = "select productname from products";
            sqlCmd = new SqlCommand(qryString, sqlcon);

            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlcon.Close();
            comboBox1.Text = "all Products";//naming conbox1
        }
    }
}
