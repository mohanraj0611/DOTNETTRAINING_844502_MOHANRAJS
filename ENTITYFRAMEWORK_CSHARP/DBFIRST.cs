using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleDBfirstEDFP
{
    class Program
    {
      
       

        static void Main(string[] args)
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();

            //var Employee = new Employee()
            //{
            //    EmpID = 1,
            //    Name = "mohan",
            //    Salary = 28000.00,
            //    SSN = 23456,
            //    DepID = 3

            //};
            //context.Employees.Add(Employee);

            //var Employee2 = new Employee()
            //{
            //    EmpID = 2,
            //    Name = "vimal",
            //    Salary = 27000.00,
            //    SSN = 24458,
            //    DepID = 3

            //};
            //context.Employees.Add(Employee2);

            //var Employee1 = new Employee()
            //{
            //    EmpID = 3,
            //    Name = "mtuhin",
            //    Salary = 29000.00,
            //    SSN = 23457,
            //    DepID = 3

            //};
            //context.Employees.Add(Employee1);
            //context.SaveChanges();

            LinqToEntity();
            modifyemployee();
            deleteemployee();



        }
        public static void LinqToEntity()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();

            var employees = context.Employees;

            var emplist = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach(var emp in employees)
            {
                Console.WriteLine("EmpId:{0},Name:{1},salary:{2},SSN:{3},DepID:{4}", emp.EmpID, emp.Name, emp.Salary, emp.SSN, emp.DepID);
            }
        }

        public static void modifyemployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();

            var employees = context.Employees;

            var emplist = from emp in employees
                         orderby emp.Salary
                        select emp;

            foreach (var emp in employees)
            {
                if(emp.EmpID==1)
                {
                    emp.Name = "johny";
                }
            }
            context.SaveChanges();
        }

        public static void deleteemployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();

            var employees = context.Employees;

            var employee = new Employee { EmpID = 5 };
            employees.Attach(employee);
            employees.Remove(employee);
            context.SaveChanges();
        }
    }
}
