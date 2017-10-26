using System;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;
        //private CountryRepository countryRepository;
        //private RegionRepository regionRepository;
        //private CityRepository cityRepository;
        //private RegionNominations _regionNominationsRepository;
        private IRepository<Country> countryRepository;
        private IRepository<City> cityRepository;
        private IRepository<Region> regionRepository;
        private IRepository<RegionNominations> _regionNominationsRepository;


        public IRepository<RegionNominations> RegionNominations
        {
            get
            {
                if (_regionNominationsRepository == null)
                {
                    _regionNominationsRepository = new Repository<RegionNominations>(db);
                }
                return _regionNominationsRepository;
            }
        }

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
