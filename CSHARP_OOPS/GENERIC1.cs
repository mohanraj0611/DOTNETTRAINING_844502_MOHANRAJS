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



            List<int> myint = new List<int>();

                myint.Add(10);
                myint.Add(20);
                myint.Add(90);
                foreach (var n in myint)
                    Console.WriteLine(n.ToString());

            List<string> employee = new List<string>() { "mohan", "raj", "vimal" };
            foreach(var emp in employee)
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

            foreach (KeyValuePair<int,string> kv in fruits) 
            {
                Console.WriteLine("key -> {0} and the fruit is {1}",kv.Key,kv.Value);
            }
           

            SortedDictionary<int, string> movie = new SortedDictionary<int, string>();

            movie.Add(3, "kaithi");
            movie.Add(2, "bigil");
            movie.Add(1, "mersal");
            movie.Add(4, "vtv");

            foreach (KeyValuePair<int, string> kv in movie)
            {
                Console.WriteLine("key -> {0} and the fruit is {1}", kv.Key, kv.Value);
            }

            Console.ReadKey();
        }
    }
}
