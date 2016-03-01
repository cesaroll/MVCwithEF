using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section08
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganizationEntities oe = new OrganizationEntities();
            Program prog = new Program();

            Console.WriteLine("In Main");

            var T = prog.ReadDepartments(oe);

            Console.WriteLine("Back in Main");

            T.Wait();
        }

        private async Task ReadDepartments(OrganizationEntities oe)
        {
            var deps = await oe.Departments.ToListAsync();

            foreach (var dep in deps)
            {
                Console.WriteLine("Id: {0} Name: {1}", dep.Id, dep.Name);
            }
        }
    }
}
