using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repository;

namespace Section09
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repEmp = new EmployeeRepository();

            var emps = repEmp.GetAll();

            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp.Name);
            }

        }

      
    }
}
