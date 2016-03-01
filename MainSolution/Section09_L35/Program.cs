using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL2;
using DAL2.Repository;

namespace Section09_L35
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Display Employees */
            Repository<Employee> empRep = new Repository<Employee>();

            var emps = empRep.GetAll();

            Console.WriteLine("Employees\n");
            foreach (var emp in emps)
            {
                Console.WriteLine("Emp Name: " + emp.Name);
            }

            /*Display Departments*/

            Repository<Department> depRep = new Repository<Department>();

            var deps = depRep.GetAll();

            Console.WriteLine("\n\nDepartments\n");
            foreach (var dep in deps)
            {
                Console.WriteLine("Dep: " + dep.Name);
            }

        }
    }
}
