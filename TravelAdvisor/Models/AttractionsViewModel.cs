using System.ComponentModel.DataAnnotations;
using BLL.DTO;

namespace TravelAdvisor.Models
{
    public class AttractionsViewModel
    {
        public int AttractionId { get; set; }
        [Display(Name = "Attraction Name")]
        public string AttractionName { get; set; }
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        [Display(Name = "City")]
        public int? CityId { get; set; }
        [Display(Name = "Type of attraction")]
        public int Type { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Image")]
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