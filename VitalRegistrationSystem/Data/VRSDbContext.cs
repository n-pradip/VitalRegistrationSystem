using Microsoft.EntityFrameworkCore;
using VitalRegistrationSystem.Models;

namespace VitalRegistrationSystem.Data
{
    public class VRSDbContext : DbContext
    {
        public VRSDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BirthModel> Births { get; set; }
        public DbSet<DeathModel> Deaths { get; set; }
        public DbSet<MarrigeModel> Marriges { get; set; }
        public DbSet<DivorceModel> Divorces { get; set; }

    }
}
