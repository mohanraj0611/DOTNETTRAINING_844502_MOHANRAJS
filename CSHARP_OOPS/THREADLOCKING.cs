using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp25
{
    
    class Program
    {
        public static long count1, count2;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(incrementcount1);
            Thread t2 = new Thread(incrementcount2);

            
            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Normal;
            t2.Priority = ThreadPriority.Highest;

            Thread.Sleep(10000);

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("main thread is started");
            Console.WriteLine("count1:{0}", count1);
            Console.WriteLine("count2:{0}", count2);
            Console.WriteLine("mainthread exited");
            
        }
        public static void incrementcount1()
        {
            while(true)
            {
                count1 += 1;
            }
            
        }
        public static void incrementcount2()
        {
            while(true)
            {
                count2 += 1;
            }
            
        }
    
    }
} 
