using Microsoft.EntityFrameworkCore;

namespace VitalRegistrationSystem.Data
{
    public class VRSDataContext : DbContext
    {
        public VRSDataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
