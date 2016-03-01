using System.Collections;

namespace DAL.Interface
{
    public interface IRepository
    {
        IEnumerable GetAll();

        dynamic GetById(int id); 
    }
}