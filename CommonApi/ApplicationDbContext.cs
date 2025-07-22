using CommonApi.Entities;
using CommonApi.Seeds;
using Microsoft.EntityFrameworkCore;

namespace CommonApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Eps> Eps { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply seeds
            PaisSeed.Seed(modelBuilder);
            RegionSeed.Seed(modelBuilder);
            EpsSeed.Seed(modelBuilder);
            CiudadSeed.Seed(modelBuilder);
            GeneroSeed.Seed(modelBuilder);
            TipoDocumentoSeed.Seed(modelBuilder);
        }
    }
}