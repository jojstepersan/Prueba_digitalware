using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventarioData.Model.Map
{
    public class ProductoMap : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.HasKey(e => e.ProductoId).HasName("PK_Producto");
            entity.ToTable("Produtos");
            entity.HasIndex(e => e.ProductoId).HasName("PK_Producto").IsUnique();
            entity.Property(e => e.ProductoId).HasColumnName("IdProducto");
            entity.Property(e => e.Precio).HasColumnName("Precio");
            entity.Property(e => e.Nombre).HasColumnName("Nombre");
            entity.Property(e => e.Descripcion).HasColumnName("Descripcion");
        }
    }
}
