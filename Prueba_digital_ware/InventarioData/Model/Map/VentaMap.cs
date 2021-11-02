using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventarioData.Model.Map
{
    public class VentaMap: IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> entity)
        {
            entity.HasKey(e => e.VentaId).HasName("PK_Venta");
            entity.ToTable("Venta");
            entity.HasIndex(e => e.VentaId).HasName("PK_Venta").IsUnique();
            entity.Property(e => e.VentaId).HasColumnName("VentaId");
            entity.Property(e => e.Fecha).HasColumnName("Fecha");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteId");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoId");
            entity.Property(e => e.Total).HasColumnName("Total");
        }
    }
}
