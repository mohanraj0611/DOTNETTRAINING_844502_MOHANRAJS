using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        enum Department
        {
            physics = 10,
            chemistry = 12,
            mathamatics = 15,
            biology = 18
        };

        enum Color
        {
            Red = 10,
            green,
            blue = 15
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Department id of physics:{0}", (int)Department.physics);
            Console.WriteLine("Department id of chemistry:{0}", (int)Department.chemistry);
            Console.WriteLine("Department id of mathamatics:{0}", (int)Department.mathamatics);
            Console.WriteLine("Department id of biology:{0}", (int)Department.biology);

            Console.WriteLine("the color red indicates: {0}", (int)Color.Red);
            Console.WriteLine("the color green indicates: {0}", (int)Color.green);
            Console.WriteLine("the color blue indicates: {0}", (int)Color.blue);

            Console.ReadKey();
        }
    }
}