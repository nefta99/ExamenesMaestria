using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class CapitulosMap : EntityTypeConfiguration<Capitulos>
    {
        public CapitulosMap()
        {
            ToTable("Capitulos", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Nombre).HasMaxLength(80).IsRequired();
            Property(p => p.FechaCreacion).IsOptional();
            Property(p => p.CreadoPorUsuarioId).IsOptional();
        }
    }
}
