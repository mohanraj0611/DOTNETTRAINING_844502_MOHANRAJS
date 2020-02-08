using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee(); //instanciation of employee class using new keyword
                                           // employee emp3 = new employee(4, "vimal");
            employee emp1 = new employee(1, "mohan", 4, "sysadmin");//iitialize the class fields using the constructor
            employee emp2 = new employee(2, "raj", 3, "technical");
            emp1.showdata();
            emp2.showdata();

            product ppp = new product() { productid = 1, productname = "vadai", price = 10.00 };
            ppp.showdata();

            customer ccc = new customer(){customerid = 2, customername = "vimal", country = "india"};
            ccc.showdata();

        }

    }

    public class employee  //acess pecifier is internal by default for the class
    {
        int empid; //by default private within the class
        string empname;
        short deptid;
        string deptname;

        public employee()//default constructor
        {

        }

        //public employee(int eid,string ename)//constructor with two parameters
        //{
        //empid = eid;
        // empname = ename;
        //}

        public employee(int eid, string ename, short did, string dname)//constructor with four parameters
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }

        public void showdata() //instance method should be called with object reference
        {
            Console.WriteLine("empid = {0}", empid);
            Console.WriteLine("empname = {0}", empname);
            Console.WriteLine("depid = {0}", deptid);
            Console.WriteLine("deptname = {0}", deptname);
            Console.ReadKey();


        }
        //acess specifier
        //private,protected,public,internal,protected internal
        //private can only be acess within the class where it is defined
        //protected can only be acessed within both base and its derivedclass
        //internal can becacessed with the current assembly of where that class is defined
        //protected internal-can be accesed anywhere within the current assembly and within the drived class



    }
    public class product
    {
         int pid;
        //define properties from the class
        public int productid
        {
            get { return pid; }
            set { pid = value; }
        }

        //automatic properties ,compiler does the implementation here
        public string productname
        {
            get;
            set;
        }
        public double price
        {
            get;
            set;
        }

        public void showdata()
        {
            Console.WriteLine("productid = {0}", productid);
            Console.WriteLine("productname = {0}", productname);
            Console.WriteLine("productprice = {0}", price);
            Console.ReadKey();

        }
    }
    public class customer
    {
        int cid;
        //define properties from the class
        public int customerid
        {
            get { return cid; }
            set { cid = value; }
        }

        //automatic properties ,compiler does the implementation here
        public string customername
        {
            get;
            set;
        }
        public string country
        {
            get;
            set;
        }

        public void showdata()
        {
            Console.WriteLine("customerid = {0}", customerid);
            Console.WriteLine("customername = {0}", customername);
            Console.WriteLine("cuatomercountry = {0}", country);
            Console.ReadKey();

        }
    }

}