using System.Data.Entity;
using DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.EF
{
    //user control: add and authenticate
   public class ApplicationContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionNominations> RegionNominationses { get; set; }
    }
}
