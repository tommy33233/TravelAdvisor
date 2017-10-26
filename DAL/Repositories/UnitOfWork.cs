using System;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;
        private CountryRepository countryRepository;
        private RegionRepository regionRepository;
        private CityRepository cityRepository;


        public IRepository<City> Cities
        {
            get
            {
                if (cityRepository == null)
                {
                    cityRepository = new CityRepository(db);
                }
                return cityRepository;
            }
        }

        public IRepository<Country> Countries
        {
            get
            {
                if (countryRepository == null)
                {
                    countryRepository = new CountryRepository(db);
                }
                return countryRepository;
            }
        }

        public IRepository<RegionNominations> RegionNominations
        {
            get
            {
                return null;
            }
        }

        public IRepository<Region> Regions
        {
            get
            {
                if (regionRepository == null)
                {
                   regionRepository = new RegionRepository(db);
                }
                return regionRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
