using Microsoft.EntityFrameworkCore;
using Vehicle_tracking_App.Data_Access.Model;

namespace Vehicle_tracking_App.Data_Access
{
    public class VehicletrackingContext : DbContext
    {
         public DbSet<Users> Users { get; set; }
        public DbSet<UseVehicleDetails> UseVehicleDetails { get; set; }
        public DbSet<Device> Devices { get; set; }
        public VehicletrackingContext(DbContextOptions options) : base(options)
        {
        }
  
    }
}
