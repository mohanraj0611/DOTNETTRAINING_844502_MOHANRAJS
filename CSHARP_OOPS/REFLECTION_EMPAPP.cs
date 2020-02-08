using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using empcomponent;

namespace empapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            { Employeeid = 10, Employeename = "mohan", Employeedept = "admin" };

            
                 
            var sdsd = emp.showdata();
            Console.WriteLine(sdsd);

            var salary = emp.Getsalary(30, 800.00);
            var incent = emp.Incentives(salary);

            Console.WriteLine("salary:{0},incentives:{1},totlasalary:{2}", salary, incent,salary+incent);

            Console.ReadKey();
        }
    }
}
