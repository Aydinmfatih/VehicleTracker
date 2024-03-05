using Microsoft.EntityFrameworkCore;
using VehicleTracker.Dal.Entities;

namespace VehicleTracker.Dal.Context
{
    public class VehicleTrackContext:DbContext
    {
        public VehicleTrackContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
