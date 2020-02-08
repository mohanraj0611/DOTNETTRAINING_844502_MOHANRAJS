using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void DisplayNum()
        {
            Console.WriteLine("enter the value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("the entered age is" +a);
            Console.ReadKey();
            


        }

        static void DisplaySen()
        {
            Console.WriteLine("enter the user name");
            string username = Console.ReadLine();
            string s = "username:{1}";
            string msg=string.Format("mohan");
            Console.WriteLine("the entered value is:{1}", msg);
            //Console.WriteLine("the entered username is:" + username);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            
            DisplayNum();
            DisplaySen();
        }
    }
}
