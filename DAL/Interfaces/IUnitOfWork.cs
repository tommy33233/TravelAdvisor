using System;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Country> Countries { get; }
        IRepository<City> Cities { get;  }
        IRepository<Region> Regions { get; }
        IRepository<RegionNominations> RegionNominations { get;}
        void Save();
    }
}
