using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DAL.Base;

namespace DAL.Repository
{
    public class EmployeeRepository : RepositoryBase
    {

        public override IEnumerable GetAll()
        {
            return OrganizationEntities.Employees.ToList();
        }

        public override dynamic GetById(int id)
        {
            return OrganizationEntities.Employees.Find(id);
        }
    }
}