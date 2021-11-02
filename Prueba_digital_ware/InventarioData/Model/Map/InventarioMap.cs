using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventarioData.Model.Map
{
    public class InventarioMap: IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> entity)
        {
            entity.HasKey(e => e.ProductoId).HasName("FK_Inventario_Producto");
            entity.ToTable("Inventario");
            entity.HasIndex(e => e.ProductoId).HasName("FK_Inventario_Producto").IsUnique();
            entity.Property(e => e.ProductoId).HasColumnName("IdProducto");
            entity.Property(e => e.CantidadExistente).HasColumnName("CantidadExistente");
        }
    }
}
