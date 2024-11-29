using Microsoft.EntityFrameworkCore;
using Planificador.Shared.Entities;

namespace Planificador.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Actividad> Actividades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actividad>().HasIndex(x => x.Activity).IsUnique();
        }
    }
}
