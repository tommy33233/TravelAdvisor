using DAL.Entities;

namespace BLL.DTO
{
    public class CityDTO
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public int Population { get; set; }

        public City CityFromDtoToCore(CityDTO cityDto)
        {
            City city = new City();
            if (cityDto != null)
            {
                city.CityId = cityDto.CityId;
                city.CityName = cityDto.CityName;
                city.CountryId = cityDto.CountryId;
                city.Population = cityDto.Population;
            }
            return city;
        }

        public CityDTO CityfromCoreToDto(City city)
        {
            CityDTO cityDto = new CityDTO
            {
                CityId = city.CityId,
                CityName = city.CityName,
                CountryId = city.CountryId,
                Population = city.Population
            };
            return cityDto;
        }
    }
}
