using BLL.DTO;

namespace TravelAdvisor.Models
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }
        public string SortName { get; set; }
        public string Name { get; set; }
        public int Phonecode { get; set; }
        public string ImageName { get; set; }
        public string Info { get; set; }

        public static CountryDTO CountryViewToDTO(CountryViewModel countryView )
        {
            return new CountryDTO
            {
                CountryId = countryView.CountryId,
                Phonecode = countryView.Phonecode,
                SortName = countryView.SortName,
                Name = countryView.Name,
                Info = countryView.Info,
                ImageName = countryView.ImageName
            };
        }

        public static CountryViewModel CountryDTOToView(CountryDTO countryDTO)
        {
            return new CountryViewModel
            {
                CountryId = countryDTO.CountryId,
                Phonecode = countryDTO.Phonecode,
                SortName = countryDTO.SortName,
                Name = countryDTO.Name,
                Info = countryDTO.Info,
                ImageName = countryDTO.ImageName
            };
        }
    }
}