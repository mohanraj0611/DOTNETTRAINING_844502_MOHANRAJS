using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreading
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("main threasd is started");
            //Method1();
            // Method2();
            //Method3();

            Thread t = Thread.CurrentThread;
            t.Name = "main thread";

            Console.WriteLine("{0} is running with id:{1}", t.Name, t.ManagedThreadId);


            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);
            
            

            t1.Start();
            t2.Start();
            t3.Start();
           

            Thread tp = new Thread(new ParameterizedThreadStart(test));
            tp.Start(100);
            Console.WriteLine("thread is exited");

            Thread tp1 = new Thread(findarea);
            tp1.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            tp.Join();

        }
        public static void Method1()
        {
            Console.WriteLine("thread1 is started");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("method1:{0}", i);
            Console.WriteLine("thread1 is exited");


        }
        public static void Method2()
        {
           
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("method2:{0}", i);
                if (i == 25)
                {
                    Thread.Sleep(5000);

                    Console.WriteLine("method:{0}", i);
                }
                Console.WriteLine("thread2 is ended");

            }
        }
        public static void Method3()
        {
            Console.WriteLine("thread3 is started");
            for (int i = 1; i <= 50; i++)
            {

            Console.WriteLine("method3:{0}", i);
               
            }
            Console.WriteLine("thread3 is ended");
        }

        public static void test(object max)
        {
            int j = Convert.ToInt32(max);
            for(int i=1;i<=j;i++)
            {
                Console.WriteLine("test:{0}",i);
            }
        }
        public static void findarea()
        {
            double length,breadth;
            Console.WriteLine("enter length");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth");
            breadth = double.Parse(Console.ReadLine());

            var area = length * breadth;
            Console.WriteLine("area is :{0}", area);   




        }

    }
}

