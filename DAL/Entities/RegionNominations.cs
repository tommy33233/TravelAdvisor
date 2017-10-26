using System.Collections.Generic;

namespace DAL.Entities
{
    public class RegionNominations
    {
        public int NominationId { get; set; }
        public string Name { get; set; }

        public ICollection<Region> Regions { get; set; }

        public RegionNominations()
        {
            Regions=new List<Region>();
        }
    }
}

