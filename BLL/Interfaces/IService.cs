using System.Collections.Generic;
using BLL.DTO;

namespace BLL.Interfaces
{
    interface IService
    {
        CountryDTO GetCountryById(int? id);
        CityDTO GetCityById(int? id);
        RegionDTO GetRegionById(int? id);
        IEnumerable<CountryDTO> GetCountries();
        IEnumerable<CityDTO> GetCities();
        IEnumerable<RegionDTO> GetRegions();
        void Dispose();
    }
}
