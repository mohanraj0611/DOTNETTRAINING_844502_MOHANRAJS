using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100);

            items.Add("hello world");
            items.Add(19);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object obj in items)
                Console.WriteLine(obj.ToString());

            employee emp1 = new employee()
            { empid = 1, empname = "mohan", empdept = "admin" };
            employee emp2 = new employee()
            { empid = 2, empname = "raj", empdept = "system" };
            employee emp3 = new employee()
            { empid = 3, empname = "vimal", empdept = "maintainance" };


            List<object> le = new List<object>();

            le.Add(emp1);
            le.Add(emp2);
            le.Add(emp3);

            foreach (employee emp in le)
            {
                Console.WriteLine("empid={0} empname={1} empname={2}", emp.empid, emp.empname, emp.empdept);
            }

            emp1.showdata();
            emp2.showdata();
            emp3.showdata();

            List<int> myint = new List<int>();

            myint.Add(10);
            myint.Add(20);
            myint.Add(90);
            foreach (var n in myint)
                Console.WriteLine(n.ToString());

            List<string> employee = new List<string>() { "mohan", "raj", "vimal" };

            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }

            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "apple");
            fruits.Add(2, "mango");
            fruits.Add(3, "orange");
            fruits.Add(4, "pineapple");

            //deleting the values using key
            fruits.Remove(3);
            fruits.Add(3, "grapes");

            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key -> {0} and the fruit is {1}", kv.Key, kv.Value);
            }


            SortedDictionary<int, string> movie = new SortedDictionary<int, string>();

            movie.Add(3, "a");
            movie.Add(2, "c");
            movie.Add(1, "b");
            movie.Add(4, "d");

            foreach (KeyValuePair<int, string> kv in movie)
            {
                Console.WriteLine("key -> {0} and the fruit is {1}", kv.Key, kv.Value);
            }

            Stack<float> fnumbers = new Stack<float>();


            fnumbers.Push(10.30f);
            fnumbers.Push(10.40f);
            fnumbers.Push(10.50f);
            fnumbers.Push(10.60f);

            foreach (var fun in fnumbers)
            {
                Console.WriteLine(fun);
            }

            fnumbers.Pop();

            Console.WriteLine("after done with pop method");
            foreach (var fun in fnumbers)
            {
                Console.WriteLine(fun);
            }


            Console.WriteLine("the queue elements");
            Queue<double> qnumbers = new Queue<double>();


            qnumbers.Enqueue(10.30);
            qnumbers.Enqueue(10.40);
            qnumbers.Enqueue(10.50);
            qnumbers.Enqueue(10.60);

            foreach (var qun in qnumbers)
            {
                Console.WriteLine(qun);
            }

            qnumbers.Dequeue();

            Console.WriteLine("queue after dequeue");
            foreach (var qun in qnumbers)
            {
                Console.WriteLine(qun);
            }

            int a, b;
            a = 50;
            b = 80;
            Console.WriteLine("befoer swapping: a={0}, b={1}", a, b);

            swap<int>(ref a, ref b);

            Console.WriteLine("after swaping: a={0} b={1}", a, b);
            string s1, s2;

            s1 = "hello";
            s2 = "world";

            Console.WriteLine("befoer swapping: a={0}, b={1}", s1, s2);
            swap<string>(ref s1, ref s2);
            Console.WriteLine("befoer swapping: a={0}, b={1}", s1, s2);




            Console.ReadKey();
        }

        public class employee
        {
            public double empid
            {
                get;
                set;
            }

            public string empname
            {
                get;
                set;
            }

            public string empdept
            {
                get;
                set;
            }



            public void showdata()
            {
                Console.WriteLine("the empid is {0}", empid);
                Console.WriteLine("the empname is {0}", empname);
                Console.WriteLine("the empdept is {0}", empdept);
            }
        }


        
            

        public static void swap<T>(ref T a,ref T b)

        {
            T c;
            c = a;
            a = b;
            b = c;
        }


    }
}

