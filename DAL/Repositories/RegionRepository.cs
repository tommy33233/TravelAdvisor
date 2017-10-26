using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class RegionRepository:IRepository<Region>
    {
        private ApplicationContext db;

        public RegionRepository(ApplicationContext context)
        {
            db = context;
        }

        public IEnumerable<Region> GetAll()
        {
            return db.Regions;
        }

        public Region Get(int id)
        {
            return db.Regions.Find(id);
        }

        public IEnumerable<Region> Find(Func<Region, bool> predicate)
        {
            return db.Regions.Where(predicate).ToList();
        }

        public void Create(Region item)
        {
            db.Regions.Add(item);
        }

        public void Update(Region item)
        {
           db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Region region = Get(id);
            if (region != null)
            {
                db.Regions.Remove(region);
            }
        }
    }
}
