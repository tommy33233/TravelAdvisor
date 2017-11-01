using System.Collections.Generic;

namespace DAL.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string SortName { get; set; }
        public string Name { get; set; }
        public int Phonecode { get; set; }
        public string Info { get; set; }
        public string ImageName { get; set; }

        public ICollection<City> Cities { get;set;}
        public ICollection<Region> Regions { get; set; }

        public Country()
        {
            Cities = new List<City>();
            Regions = new List<Region>();
        }
    }
}
