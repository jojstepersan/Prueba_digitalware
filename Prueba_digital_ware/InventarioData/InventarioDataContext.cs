using InventarioData.Model.Map;
using InventarioData.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace InventarioData
{
    public class InventarioDataContext : DbContext
    {
        public InventarioDataContext() { }

        public InventarioDataContext(DbContextOptions<InventarioDataContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.use("USER ID=LEGAL_APP;Password=Falabella$2020!;DATA SOURCE=CO2DVW261A.Falabella.com:1521/orcl.Falabella.com");
            //}
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Orden> Ordens { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new InventarioMap());
            modelBuilder.ApplyConfiguration(new OrdenMap());
            modelBuilder.ApplyConfiguration(new PersonaMap());
            modelBuilder.ApplyConfiguration(new ProductoMap());
            modelBuilder.ApplyConfiguration(new TipoIdentificacionMap());
            modelBuilder.ApplyConfiguration(new VentaMap());
        }
    }
}
