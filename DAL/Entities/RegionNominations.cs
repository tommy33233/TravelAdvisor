using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class RegionNominations
    {
        [Key]
        public int RegionNominationId { get; set; }
        public string Name { get; set; }

        public ICollection<Region> Regions { get; set; }

        public RegionNominations()
        {
            Regions=new List<Region>();
        }
    }
}

