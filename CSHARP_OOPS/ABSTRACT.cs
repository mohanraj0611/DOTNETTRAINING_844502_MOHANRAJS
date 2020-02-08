using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            sbaaccount obj = new sbaaccount();
            ccaccount objcc = new ccaccount();
            

            double si=obj.getsimpleinterest(95000.00, 5, 8);
            double tamt = obj.gettotalamount(5000.00,si);

            Console.WriteLine("the simpleinterest is {0}",si);
            Console.WriteLine("the totalamount is {0}", tamt);

            var sicc = objcc.getsimpleinterest(95000.00, 5, 8);
            tamt = objcc.gettotalamount(5000.00, sicc);

            Console.WriteLine("the simpleinterest is {0}", sicc);
            Console.WriteLine("the totalamount is {0}", tamt);

            obj.show();
            
        }
    }

    public abstract class banking
    {
        public abstract double getsimpleinterest(double pr, int td, short rt);

        public abstract double gettotalamount(double bal,double si);

        public void show()
        {
            Console.WriteLine("this is concrete method in abs class");
        }
    }

    public class sbaaccount : banking
    {
        public override double getsimpleinterest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;
        }

        public override double gettotalamount(double bal, double si)
        {
            double amount = bal + si;
            return amount;
        }
    }

    public class ccaccount : banking
    {
        public override double getsimpleinterest(double pr, int td, short rt)
        {
            double si = 0.25*(pr * td * rt) / 100;
            return si;
        }

        public override double gettotalamount(double bal, double si)
        {
            double amount = bal + si;
            return amount;
        }
    }
}
