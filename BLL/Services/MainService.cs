using System;
using System.Collections.Generic;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class MainService : IService
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
            Mapper.Initialize(cfg => cfg.CreateMap<City, CityDTO>());
            return Mapper.Map<IEnumerable<City>, List<CityDTO>>(Database.Cities.GetAll());
        }

        public CityDTO GetCityById(int? id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<City, CityDTO>());
            return Mapper.Map<City, CityDTO>(Database.Cities.Get(id.HasValue ? (int) id : 0));
        }

        public IEnumerable<CountryDTO> GetCountries()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Country, CountryDTO>());
            return Mapper.Map<IEnumerable<Country>, List<CountryDTO>>(Database.Countries.GetAll());
        }

        public CountryDTO GetCountryById(int? id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Country, CountryDTO>());
            return Mapper.Map<Country, CountryDTO>(Database.Countries.Get(id.HasValue ? (int) id : 0));
        }

        public RegionDTO GetRegionById(int? id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Region, RegionDTO>());
            return Mapper.Map<Region, RegionDTO>(Database.Regions.Get(id.HasValue ? (int) id : 0));
        }

        public IEnumerable<RegionDTO> GetRegions()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Region, RegionDTO>());
            return Mapper.Map<IEnumerable<Region>, List<RegionDTO>>(Database.Regions.GetAll());
        }

        public IEnumerable<RegionNominationDTO> GetRegionNominations()
        {
            Mapper.Initialize(cfg=>cfg.CreateMap<RegionNominations, RegionNominationDTO>());
            return
                Mapper.Map<IEnumerable<RegionNominations>, List<RegionNominationDTO>>(
                    Database.RegionNominations.GetAll());
        }

        public RegionNominationDTO GetRegionNominationById(int? id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegionNominations, RegionNominationDTO>());
            return Mapper.Map<RegionNominations, RegionNominationDTO>(Database.RegionNominations.Get(id.HasValue?(int)id:0));
        }
    }
}
