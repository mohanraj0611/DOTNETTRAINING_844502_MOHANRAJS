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
    public partial class Form4 : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        string conString, qryString;

        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conString = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();

            sqlCmd = new SqlCommand();
            sqlCmd.CommandText = "getcustomersbycountry";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = sqlcon;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@country";
            param.DbType = DbType.String;
            param.Value = comboBox1.Text;

            sqlCmd.Parameters.Add(param);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "customersbycountry");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customersbycountry";

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(conString);
            ds = new DataSet();

            using (sqlcon = new SqlConnection(conString))
            {
                sqlcon.Open();
                qryString = "select distinct country from customers";
                sqlCmd = new SqlCommand(qryString,sqlcon);
                dr = sqlCmd.ExecuteReader();
                while (dr .Read())
                {
                    comboBox1.Items.Add(dr["country"]); 
                }
                dr.Close();


            }
         

        }
    }
}
