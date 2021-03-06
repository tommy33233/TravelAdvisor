﻿using System.Collections.Generic;
using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IService
    {
        CountryDTO GetCountryById(int? id);
        CityDTO GetCityById(int? id);
        RegionDTO GetRegionById(int? id);
        RegionNominationDTO GetRegionNominationById(int? id);
        IEnumerable<CountryDTO> GetCountries();
        IEnumerable<CityDTO> GetCities();
        IEnumerable<RegionDTO> GetRegions();
        IEnumerable<RegionNominationDTO> GetRegionNominations();
        AttractionsDTO GetAttractionById(int id);
        IEnumerable<AttractionsDTO> GetAttractions(); 
        void AddCity(CityDTO city);
        void AddAttraction(AttractionsDTO attraction);
        void Dispose();
    }
}
