using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventarioData.Model.Map
{
    public class PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> entity)
        {
            entity.HasKey(e => e.PersonaId).HasName("PK_Personas");
            entity.ToTable("Personas");
            entity.HasIndex(e => e.PersonaId).HasName("PK_Personas").IsUnique();
            entity.Property(e => e.PersonaId).HasColumnName("PersonaId");
            entity.Property(e => e.FechaNacimiento).HasColumnName("FechaNacimiento");
            entity.Property(e => e.Identificacion).HasColumnName("Identificacion");
            entity.Property(e => e.Nombres).HasColumnName("Nombres");
            entity.Property(e => e.TipoIdentificacionId).HasColumnName("TipoIdentificacionId");            
        }
    }
}
