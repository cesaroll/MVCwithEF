using System.Collections;
using System.Collections.Generic;
using DAL.Interface;

namespace DAL.Base
{
    public abstract class RepositoryBase : IRepository
    {
        protected OrganizationEntities OrganizationEntities { get; set; }

        protected RepositoryBase()
        {
            OrganizationEntities = new OrganizationEntities();
        }

        public abstract IEnumerable GetAll();

        public abstract dynamic GetById(int id);
    }
}