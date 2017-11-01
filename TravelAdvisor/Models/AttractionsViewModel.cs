using BLL.DTO;

namespace TravelAdvisor.Models
{
    public class AttractionsViewModel
    {
        public int AttractionId { get; set; }
        public string AttractionName { get; set; }
        public int CountryId { get; set; }
        public int? CityId { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public static AttractionsDTO AttractionsFromViewToDto(AttractionsViewModel attraction)
        {
            return new AttractionsDTO
            {
                AttractionId = attraction.AttractionId,
                AttractionName = attraction.AttractionName,
                CountryId = attraction.CountryId,
                CityId = attraction.CityId,
                Type = attraction.Type,
                Description = attraction.Description,
                ImageName = attraction.ImageName
            };
        }

        public static AttractionsViewModel AttractionsFromDTOToViewModel(AttractionsDTO attraction)
        {
            return new AttractionsViewModel
            {
                AttractionId = attraction.AttractionId,
                AttractionName = attraction.AttractionName,
                CountryId = attraction.CountryId,
                CityId = attraction.CityId,
                Type = attraction.Type,
                Description = attraction.Description,
                ImageName = attraction.ImageName
            };
        }
    }
}