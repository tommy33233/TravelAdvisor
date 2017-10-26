using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class CountryRepository:IRepository<Country>
    {
        private ApplicationContext db;

        public CountryRepository(ApplicationContext context)
        {
            db = context;
        }

        public IEnumerable<Country> GetAll()
        {
            return db.Countries;
        }

        public Country Get(int id)
        {
            return db.Countries.Find(id);
        }

        public IEnumerable<Country> Find(Func<Country, bool> predicate)
        {
            return db.Countries.Where(predicate).ToList();
        }

        public void Create(Country item)
        {
            db.Countries.Add(item);
        }

        public void Update(Country item)
        {
           db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Country country = db.Countries.Find(id);
            if (country != null)
            {
                db.Countries.Remove(country);
            }
        }
    }
}
