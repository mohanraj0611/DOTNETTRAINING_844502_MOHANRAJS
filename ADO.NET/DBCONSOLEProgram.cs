using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace dbconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string constring, qrystring;
            SqlCommand sqlcmd;
            SqlConnection sqlcon;
            SqlDataAdapter da;
            SqlDataReader dr;
            DataSet ds;

            constring = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(constring);

            //sqlcon.Open();

            //qrystring = "select productname from products";
            //sqlcmd = new SqlCommand(qrystring, sqlcon);

            //dr = sqlcmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["productName"]);
            //}
            //dr.Close();
            //sqlcon.Close();
            qrystring = "select * from customers";
            using (sqlcon = new SqlConnection(constring))
            {
                sqlcmd = new SqlCommand(qrystring, sqlcon);
                //sqlcon.Open();
                da = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "customerinfo");
                DataTable dt = ds.Tables["customerinfo"]; 
                var customer = from customers in dt.AsEnumerable()
                               where customers.Field<string>("country") == "USA"
                               select new
                               {
                                   customerID = customers["customerID"],
                                   contactname = customers["contactname"],
                                   companyname = customers["companyname"],
                                   city = customers["city"],
                                   country = customers["country"]
                               };
                foreach (var c in customer)
                {
                    Console.WriteLine("customerID=" + c.customerID + "Name=" + c.contactname + "companyname=" + c.companyname + "city=" + c.city+"country=" +c.country);
                }

                int[] array = new int[6] { 2, 5, 6, 7, 4, 7 };

                var even = from i in array
                           where i % 2 == 0                                                     
                           select i;

                foreach(int i in even)
                {
                    Console.WriteLine("even numbers are:{0}",i);
                }
            }
        }
    }
}
