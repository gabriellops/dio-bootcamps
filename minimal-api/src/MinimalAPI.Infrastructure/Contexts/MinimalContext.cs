using Microsoft.EntityFrameworkCore;
using MinimalAPI.Domain.Entities;

namespace MinimalAPI.Infrastructure.Contexts
{
    public class MinimalContext : DbContext
    {
        public MinimalContext(DbContextOptions<MinimalContext> options) : base(options)
        { 
        }

        public DbSet<AdministratorEntity> AdministratorEntities { get; set; }
        public DbSet<VehicleEntity> VehicleEntities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AdministratorEntity>()
                .HasMany(a => a.Vehicles)
                .WithOne(v => v.Administrator)
                .HasForeignKey(v => v.AdministratorId);
        }
    }
}
