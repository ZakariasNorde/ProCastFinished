using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Repository
{
    public interface IRepository<T>
    {
        List<T> getAll();
        void delete(T anObject);

        void add(T anObject);

        void update(List<T> aList);

        void update(T newObject);

        void saveChanges();

        T getItem(string Id);

    }
}
