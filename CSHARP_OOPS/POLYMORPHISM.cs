using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();

            var salray = emp.getsalary(30, 800);
            Console.WriteLine("salary with out incentive = {0}", salray);

            salray = emp.getsalary(30, 800, 5000);
            Console.WriteLine("salary with  incentive = {0}", salray);


            manager mng = new manager();
            var salary = mng.getperks(30000, 5000);
            Console.WriteLine("salary = {0}", salary);
            Console.ReadKey();


        }
    }

    public class employee
    {
        public double getsalary(int nds, float spd)//this method  can be overloaded with diff signature
        {
            double salary = nds * spd;
            return salary;
        }
        public double getsalary(int nds, float spd, float incent)//getsalary method overloaded
        {
            double salary = (nds * spd) + incent;
            return salary;
        }

        public virtual double getperks(float salary, float perk)
        {
            double ts = salary + perk;
            return ts;

        }

    }
    public class manager : employee
    {
        public override double getperks(float salary, float perk)
        {
            return base.getperks(salary, perk) * 1.10;
        }
    }
}