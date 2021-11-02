using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventarioData.Model.Map
{
    public class OrdenMap : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> entity)
        {
            entity.HasKey(e => new { e.VentaId ,e.ProductoId}).HasName("PK_Ordenes");
            entity.ToTable("Ordenes");
            entity.HasIndex(e => new { e.VentaId, e.ProductoId }).HasName("PK_Ordenes").IsUnique();
            entity.Property(e => e.VentaId).HasColumnName("VentaId");
            entity.Property(e => e.ProductoId).HasColumnName("IdProducto");
            entity.Property(e => e.CantidadVendida).HasColumnName("CantidadVendida");
        }
    }
}
