using DAL.Entities;

namespace BLL.DTO
{
    public class AttractionsDTO
    {
        public int AttractionId { get; set; }
        public string AttractionName { get; set; }
        public int CountryId { get; set; }
        public int? CityId { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public static AttractionsDTO AttractionsFromCoreToDTO(Attractions attraction)
        {
            return new AttractionsDTO
            {
                AttractionId = attraction.AttractionId,
                AttractionName = attraction.AttractionName,
                CountryId = attraction.CountryId,
                CityId = attraction.CityId,
                Type = attraction.AttractionType,
                Description = attraction.Description,
                ImageName = attraction.ImageName
            };
        }

        public static Attractions AttractionsFromDTOToCore(AttractionsDTO attraction)
        {
            return new Attractions
            {
                AttractionId = attraction.AttractionId,
                AttractionName = attraction.AttractionName,
                CountryId = attraction.CountryId,
                CityId = attraction.CityId,
                AttractionType = attraction.Type,
                Description = attraction.Description,
                ImageName = attraction.ImageName
            };
        }
    }
}
