using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL2.Repository
{
    public class Repository<T> where T : class 
    {
        public OrganizationEntities OE { get; set; }

        public Repository()
        {
            OE = new OrganizationEntities();
        }

        public IEnumerable<T> GetAll()
        {
            return OE.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return OE.Set<T>().Find(id);
        }

        public void Insert(T obj)
        {
            OE.Set<T>().Add(obj);
            OE.SaveChanges();
        }

        public void Update(T obj)
        {
            OE.Entry(obj).State = EntityState.Modified;
            OE.SaveChanges();
        }

        public void Delete(T obj)
        {
            OE.Entry(obj).State = EntityState.Deleted;
            OE.SaveChanges();
        }

    }
}