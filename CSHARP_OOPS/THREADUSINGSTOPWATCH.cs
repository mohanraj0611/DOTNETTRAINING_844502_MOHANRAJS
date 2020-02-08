using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            incrementcount1();
            incrementcount2();
            s1.Stop();

            Stopwatch s2 = new Stopwatch();
            Thread t1 = new Thread(incrementcount1);
            Thread t2 = new Thread(incrementcount2);

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();
            t2.Join();

            
           
            Console.WriteLine("the single thread elapsed time:{0}", s1.ElapsedMilliseconds);
            Console.WriteLine("the multi thread elapsed time:{0}", s2.ElapsedMilliseconds);
            Console.WriteLine("mainthreadng exited");
        }
        public static void incrementcount1()
        {
            long count1=0;
            for (int i= 1;i<= 100000;i++)
            {
                count1++;
               
            }
            Console.WriteLine("count1:{0}", count1);
        }
        public static void incrementcount2()
        {
            long count2 = 0;
            for (int i = 1; i <= 100000; i++)
            {
                count2++;
                
            }
            Console.WriteLine("count2:{0}", count2);
        }
    }
}
