namespace DAL.Entities
{
    public class Region
    {
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public int RegionNumber { get; set; }
        public int RegionNominationId { get; set; }
        public string Name { get; set; }

        public virtual RegionNominations RegionNomination { get; set; }
        public virtual Country Country { get; set; }
    }
}
