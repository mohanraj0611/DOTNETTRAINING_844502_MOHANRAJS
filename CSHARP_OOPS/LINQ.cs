using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] employee = new string[4] { "tuhin","vimal","mohan","anup" };
            ////using query syntax
            //var emp = from e in employee
            //          where e.StartsWith("t")
            //          select e;

            //foreach (string e in emp)
            //{
            //    Console.WriteLine("name starts with t: {0}", e);
            //}
            //Console.ReadKey();

            ////using method syntax

            //var emp1 = employee.Where(e => e.StartsWith("a"));

            //foreach (string e in emp1)
            //{
            //    Console.WriteLine("name starts with a: {0}", e);
            //}
            //Console.ReadKey();

            //Console.WriteLine("************************************");

            //List<string> fruit = new List<string>() { "apple", "mango", "orange", "banana", "pineapple", "grape" };


            //var frt = from f in fruit
            //          where f.Contains("o")
            //          select f;
            //foreach (string f in frt)
            //{
            //    Console.WriteLine("fruit name contains o: {0}", f);
            //}
            //Console.ReadKey();

            //var frt1 = from f in fruit
            //           where f.Length > 6
            //           select f;
            //foreach (string f in frt1)
            //{
            //    Console.WriteLine("name length > 6 letters: {0}", f);
            //}
            //Console.ReadKey();

            //Console.WriteLine("************************************");

            //int[] marks = new int[6] { 90, 78, 96, 67, 98, 100 };


            //var mrk = from m in marks
            //          where m > 90
            //          select m;
            //foreach (int m in mrk)
            //{
            //    Console.WriteLine("marks > 90: {0}", m);
            //}
            //Console.ReadKey();

            //var mrk1 = from m in marks
            //          orderby m
            //          select m;
            //foreach (int m in mrk1)
            //{
            //    Console.WriteLine("order by marks: {0}", m);
            //}
            //Console.ReadKey();
            //var mrk2 = from m in marks
            //           orderby  m descending
            //           select m;
            //foreach (int m in mrk2)
            //{
            //    Console.WriteLine("order by marks: {0}", m);
            //}
            //Console.ReadKey();

            //var mrk3 = marks.OrderByDescending(m => m);

            //foreach (int m in mrk3)
            //{
            //    Console.WriteLine("order by marks using lamda method: {0}", m);
            //}
            //Console.ReadKey();

            product p1 = new product() { id = 5, productname = "phone" };
            product p2 = new product() { id = 1, productname = "computer" };
            product p3 = new product() { id = 10, productname = "laptop" };
            product p4 = new product() { id = 9, productname = "electrical" };

            List<product> objp = new List<product>() { p1, p2, p3, p4 };

            ;

            //foreach (product m in xp)
            //{
            //    Console.WriteLine("productid: {0},productname: {1}", m.id, m.productname);
            //}
            //Console.ReadKey();

            employee e1 = new employee() {id = 5, name = "tuhin" };
            employee e2 = new employee() {id = 1, name = "vimal" };
            employee e3 = new employee() { id = 10, name = "mohan" };
            employee e4 = new employee() { id = 9, name = "anup" };

            List<employee> obje = new List<employee>() { e1, e2, e3, e4 };

            var x = (from b in obje
                    where b.id == 1
                    select b.name).Concat(from b in objp
                                                    where b.id==1
                                                    select b.productname);

            foreach (var m in x)
            {
                Console.WriteLine("name:{0}",m);
                
            }
            Console.ReadKey();


        }
    }
    public class employee
    {
        public int id
        {
            get;
            set;

        }
        public string name
        {
            get;
            set;

        }

    }
    public class product
    {
        public int id
        {
            get;
            set;

        }
        public string productname
        {
            get;
            set;

        }

    }

}
