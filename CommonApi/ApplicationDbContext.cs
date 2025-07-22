using CommonApi.Entities;
using CommonApi.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

    public static class MigrationInitializer
    {
        public static void ApplyMigrations(IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                try
                {
                    var context = scopedServices.GetRequiredService<ApplicationDbContext>();
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while applying migrations: {ex.Message}");
                }
            }
        }
    }
}