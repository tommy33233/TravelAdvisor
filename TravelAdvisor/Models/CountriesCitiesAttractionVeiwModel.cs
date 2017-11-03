
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace TravelAdvisor.Models
{
    public class CountriesCitiesAttractionVeiwModel
    {
        public IEnumerable<CountryViewModel> Countries { get; set; }
        public IEnumerable<CityViewModel> Cities { get; set; }
        public AttractionsViewModel Attraction { get; set; }
        public AttractionTypeEnum Enum { get; set; }


    }
}