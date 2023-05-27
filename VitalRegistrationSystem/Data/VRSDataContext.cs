using Microsoft.EntityFrameworkCore;
using VitalRegistrationSystem.Models;

namespace VitalRegistrationSystem.Data
{
    public class VRSDataContext : DbContext
    {
        public VRSDataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BirthModel> Births { get; set; }

    }
}
