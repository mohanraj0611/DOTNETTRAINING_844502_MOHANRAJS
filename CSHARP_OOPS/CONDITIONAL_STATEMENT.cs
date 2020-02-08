using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;

            if (a > 10)
            {
                Console.WriteLine("good morning");
            }
            else if (a < 10)
            {
                Console.WriteLine("good evenig");
            }
            else
            {
                Console.WriteLine("good night");
            }

            Console.WriteLine("enter the value");
            int b = Convert.ToInt32(Console.ReadLine());


            switch (b)
            {
                case 1:
                    Console.WriteLine("HELLO HOW ARE YOU");
                    break;
                case 2:
                    Console.WriteLine("HI HOW DO YOU DO");
                    break;
                case 3:
                    Console.WriteLine("nasama po");
                    break;
                default:
                    Console.WriteLine("sethu po");
                    break;

            }
            Console.WriteLine("enter a nuber");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }

            int m = 10;
            do
            {
                Console.WriteLine("{0} is less than 100", m);
                m = m + 10;


            } while (m < 100);

            int n = 10;

            while (n < 100)
            {
                Console.WriteLine("{0} is less than 100", n);
                n = n + 10;
            }

            int fact, fn, j;
            fact = 1;

            Console.WriteLine("enter a number to find the fatorial");
            fn = int.Parse(Console.ReadLine());
            for(j=1;j<=fn;j++)
            {
                fact = fact * j;
            }
            Console.WriteLine("the factorial of {0} = {1},", fn, fact);
            Console.ReadKey();

        }
    }
}
