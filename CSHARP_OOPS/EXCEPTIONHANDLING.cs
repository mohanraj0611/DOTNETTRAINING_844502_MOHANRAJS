using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excephandle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                int[] marks = new int[6] { 85, 34, 34, 34, 45, 45 };

                for (int i = 0; i <= 6; i++)
                {
                    Console.WriteLine("subject marks are {0} = {1}", i + 1, marks[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("bal code");
            try
            {
                int a, b, c;
                Console.WriteLine("enter the numerator");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the denominator");
                b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be zero");
                }
                else
                {
                    //Console.WriteLine("denominator accepted");
                    c = a / b;
                    Console.WriteLine("the c value is {0}", c);
                }
                Console.ReadKey();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }




    }
}
