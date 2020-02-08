using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridding
{
    class Program
    {
        static void Main(string[] args)
        {
            technical tech = new technical();
            var ts = tech.totalsalary(50000, 6000);
            Console.WriteLine("total salary(tech) = {0} ", ts);

            admin ad = new admin();
            ts = ad.totalsalary(50000, 6000);
            Console.WriteLine("total salary(admin) = {0} ", ts);

            manager mng = new manager();
            ts = mng.totalsalary(50000, 6000);
            Console.WriteLine("total salary(manager) = {0} ", ts);
            Console.ReadKey();
        }
    }

    public class salary
    {
        public virtual double totalsalary(int salary, double bonus)
        {
            double ts = salary + bonus;
            return ts;
        }
    }
    public class technical : salary
    {
        public override double totalsalary(int salary, double bonus)
        {
            return base.totalsalary(salary, bonus);
        }
    }
    public class admin : salary
    {
        public override double totalsalary(int salary, double bonus)
        {
            return base.totalsalary(salary, bonus) * 1.2;
        }

         
    }
    public class manager : salary
    {
        public override double totalsalary(int salary, double bonus)
        {
            return base.totalsalary(salary, bonus) * 1.4;
        }
    }
    
}
