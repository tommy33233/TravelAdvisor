using DAL.Entities;

namespace BLL.DTO
{
    public class CountryDTO
    {
        public int CountryId { get; set; }
        public string SortName { get; set; }
        public string Name { get; set; }
        public int Phonecode { get; set; }

        public static CountryDTO CountryCoreToDTO(Country country)
        {
            CountryDTO countryDTO = new CountryDTO
            {
                CountryId = country.CountryId,
                SortName = country.SortName,
                Name = country.Name,
                Phonecode = country.Phonecode
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
                Phonecode = countryDTO.Phonecode
            };
            return country;
        }
    }
}
