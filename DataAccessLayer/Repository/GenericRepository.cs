using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    internal class GenericRepository<T> : lGenericDal<T> where T : class
    {
        void lGenericDal<T>.Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();    
        }

        List<T> lGenericDal<T>.GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();

        }

        void lGenericDal<T>.Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
        }

        void lGenericDal<T>.Update(T t)
        {
            using var c = new Context();
            c.Update(t);
        }
    }
}
