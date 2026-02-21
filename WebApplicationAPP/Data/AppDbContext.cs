using Microsoft.EntityFrameworkCore;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tablas personalizadas en MySQL
            modelBuilder.Entity<Cliente>().ToTable("clientes_keilyn");
            modelBuilder.Entity<Producto>().ToTable("productos_keilyn");

            base.OnModelCreating(modelBuilder);

            //public DbSet<WebApplicationAPP.Models.Producto> Productos { get; set; }
        }
    }
}
