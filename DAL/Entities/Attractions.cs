using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
   public class Attractions
    {
       [Key]
       public int AttractionId { get; set; }
       public string AttractionName { get; set; }
       public int CountryId { get; set; }
       public int? CityId { get; set; }
       public int AttractionType { get; set; }
       public string Description { get; set; }

       public virtual Country Country { get; set; }
       public virtual City City { get; set; }
        public virtual AttractionType Type { get; set; }
    }
}
