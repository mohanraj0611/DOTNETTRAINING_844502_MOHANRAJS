using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empcomponent
{
    public class Employee
    {
        public int Employeeid
        {
            get;
            set;
        }
        public string Employeename
        {
            get;
            set;
        }
        public string Employeedept
        {
            get;
            set;
        }
        public double Getsalary(int nds,double spd)
        {
            var salary = nds + spd;
            return salary;
        }
        public double Incentives(double salary)
        {
            var incent=salary*1.0;
            return incent;
        }
        public string showdata()
        {
            return string.Format("empid:{0}, name:{1}, depatrment{2}", Employeeid, Employeename, Employeedept);
           
        }

    }
}
