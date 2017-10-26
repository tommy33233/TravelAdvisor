using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class CityRepository:IRepository<City>
    {
        private ApplicationContext db;

        public CityRepository(ApplicationContext context)
        {
            db = context;
        }

        public IEnumerable<City> GetAll()
        {
            return db.Cities;
        }

        public City Get(int id)
        {
            return db.Cities.Find(id);
        }

        public IEnumerable<City> Find(Func<City, bool> predicate)
        {
            return db.Cities.Where(predicate).ToList();
        }

        public void Create(City item)
        {
            db.Cities.Add(item);
        }

        public void Update(City item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            City city = db.Cities.Find(id);
            if (city != null)
            {
                db.Cities.Add(city);
            }
        }
    }
}
