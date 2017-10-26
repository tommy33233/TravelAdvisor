
using System;
using System.Collections.Generic;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;

namespace BLL.Services
{
    class MainService : IService
    {
        private IUnitOfWork Database { get; set; }

        public MainService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<CityDTO> GetCities()
        {
            throw new NotImplementedException();
        }

        public CityDTO GetCityById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CountryDTO> GetCountries()
        {
            throw new NotImplementedException();
        }

        public CountryDTO GetCountryById(int? id)
        {
            throw new NotImplementedException();
        }

        public RegionDTO GetRegionById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegionDTO> GetRegions()
        {
            throw new NotImplementedException();
        }
    }
}
