using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 125;
            short b = 20;
            int n = 98;
            long l = 56656565;
            float f = 10.99f;
            double d = 30.99;
            decimal m = 999.99m;

            Console.WriteLine("values of a={0}, b={1}, n={2}, l={3}, f={4}, d={5}, m={6}", a,b, n, l, f, d, m);

            DateTime dd = DateTime.Now;

            Console.WriteLine("the current date is:{0}", dd);
            Console.WriteLine("the current short date is{0}", dd.ToShortDateString());
            Console.WriteLine("the current long date is{0}", dd.ToLongDateString());
            Console.WriteLine("the current short time is{0}", dd.ToShortTimeString());
            Console.WriteLine("the current long time is{0}", dd.ToLongTimeString());
            Console.ReadKey();
        }
    }
}
