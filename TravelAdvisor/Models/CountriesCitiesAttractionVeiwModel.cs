
using System;
using System.Collections.Generic;

namespace TravelAdvisor.Models
{
    public class CountriesCitiesAttractionVeiwModel
    {
        public IEnumerable<CountryViewModel> Countries { get; set; }
        public IEnumerable<CityViewModel> Cities { get; set; }
        public AttractionsViewModel Attraction { get; set; }
    }
}