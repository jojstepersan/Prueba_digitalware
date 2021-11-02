using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventarioData.Model.Map
{
    public class TipoIdentificacionMap: IEntityTypeConfiguration<TipoIdentificacion>
    {
        public void Configure(EntityTypeBuilder<TipoIdentificacion> entity)
        {
            entity.HasKey(e => e.TipoIdentificacionId).HasName("PK_TipoIdentificacions");
            entity.ToTable("TipoIdentificacions");
            entity.HasIndex(e => e.TipoIdentificacionId).HasName("PK_TipoIdentificacions").IsUnique();
            entity.Property(e => e.TipoIdentificacionId).HasColumnName("TipoIdentificacionId");
            entity.Property(e => e.Nombre).HasColumnName("Nombre");
            entity.Property(e => e.Descripcion).HasColumnName("Descripcion");
        }
    }
}
