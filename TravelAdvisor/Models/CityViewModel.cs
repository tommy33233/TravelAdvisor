using BLL.DTO;

namespace TravelAdvisor.Models
{
    public class CityViewModel
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public int Population { get; set; }

        public static CityDTO CityFromViewToDto(CityViewModel cvm)
        {
            CityDTO cityDto = new CityDTO
            {
                CityId = cvm.CityId,
                CityName = cvm.CityName,
                CountryId = cvm.CountryId,
                Population = cvm.Population
            };
            return cityDto;
        }
        public static CityViewModel CityFromDtoToView(CityDTO cityDTO)
        {
            CityViewModel cityVM = new CityViewModel
            {
                CityId = cityDTO.CityId,
                CityName = cityDTO.CityName,
                CountryId = cityDTO.CountryId,
                Population = cityDTO.Population
            };
            return cityVM;
        }
    }
}