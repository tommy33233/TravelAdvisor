using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class Repository<T>:IRepository<T> where T:class
    {
        private ApplicationContext db;
        private DbSet<T> dbSet;

        public Repository(ApplicationContext context)
        {
            db = context;
            dbSet = context.Set<T>();
        }

        public void Create(T item)
        {
            dbSet.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            T t = Get(id);
            if (t != null)
            {
                dbSet.Remove(t);
            }
            db.SaveChanges();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
           return dbSet.AsNoTracking().ToList();
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
