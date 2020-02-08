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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        SqlConnection sqlcon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select ContactName from customers where country ='"+ comboBox1.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlcon);
            sqlcon.Open();
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ContactName"]);
            }
            dr.Close();
            listBox1.Text = sqlCmd.ToString();
            sqlcon.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(conString);

            sqlcon.Open();

            qryString = "select Distinct country from customers";
            sqlCmd = new SqlCommand(qryString, sqlcon);

            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlcon.Close();
            //comboBox1.Text = "all Products";//naming conbox1
        }
    }
}
