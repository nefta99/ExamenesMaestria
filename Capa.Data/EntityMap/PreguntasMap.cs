using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
   public  class PreguntasMap : EntityTypeConfiguration<Preguntas>
    {
        public PreguntasMap()
        {
            ToTable("Preguntas", "dbo");
            HasKey(p => p.Id);
            Property(p => p.pregunta).HasMaxLength(1000).IsRequired();
            Property(p => p.ComponenteId).IsRequired();
            Property(p => p.CapituloId).IsRequired();
        }
    }
}
