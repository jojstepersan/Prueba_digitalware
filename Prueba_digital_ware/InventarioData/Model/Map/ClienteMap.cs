using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventarioData.Model.Map
{
    public class ClienteMap: IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.HasKey(e => e.ClienteId).HasName("PK_Clientes");
            entity.ToTable("Clientes");
            entity.HasIndex(e => e.ClienteId).HasName("PK_Clientes").IsUnique();
            entity.Property(e => e.ClienteId).HasColumnName("ClienteId");
            entity.Property(e => e.PersonaId).HasColumnName("PersonaId");
        }
    }
}
