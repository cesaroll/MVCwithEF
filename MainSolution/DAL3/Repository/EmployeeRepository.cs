using System.Linq;
using DAL3.Models;

namespace DAL3.Repository
{
    public class EmployeeRepository : Repository<Employee>
    {
        public static EmployeeRepository GetInstance()
        {
            return new EmployeeRepository();
        }
        public bool ExistsByName(string name)
        {
            int count = OE.Employees.Where(x => x.Name == name).ToList().Count();
            return count > 0;
        }
    }
}