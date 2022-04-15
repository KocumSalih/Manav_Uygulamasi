using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavUygulamasi.Repository
{
    interface IRepository<T>
    {
        void Add_Update(T item);
        void Delete(T item);
        List<T> Get();
        T GetByID(int id);
    }
}
