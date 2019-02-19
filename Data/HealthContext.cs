using Microsoft.EntityFrameworkCore;
using StoreNet.Data.Models;

namespace StoreNet.Data
{
    public class HealthContext : DbContext
    {
         public HealthContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Ailment> Ailments { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}