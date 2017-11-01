using DAL.Entities;

namespace BLL.DTO
{
    public class CountryDTO
    {
        public int CountryId { get; set; }
        public string SortName { get; set; }
        public string Name { get; set; }
        public int Phonecode { get; set; }
        public string Info { get; set; }
        public string ImageName { get; set; }

        public static CountryDTO CountryCoreToDTO(Country country)
        {
            CountryDTO countryDTO = new CountryDTO
            {
                CountryId = country.CountryId,
                SortName = country.SortName,
                Name = country.Name,
                Phonecode = country.Phonecode,
                Info = country.Info,
                ImageName = country.ImageName
            };
            return countryDTO;
        }

        public static Country CountryDTOToCore(CountryDTO countryDTO)
        {
            Country country = new Country
            {
                CountryId = countryDTO.CountryId,
                SortName = countryDTO.SortName,
                Name = countryDTO.Name,
                Phonecode = countryDTO.Phonecode,
                Info = countryDTO.Info,
                ImageName = countryDTO.ImageName
            };
            return country;
        }
    }
}
