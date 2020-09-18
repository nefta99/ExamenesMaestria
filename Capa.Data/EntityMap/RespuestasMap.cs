using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class RespuestasMap : EntityTypeConfiguration<Respuestas>
    {
        public RespuestasMap()
        {
            ToTable("Respuestas", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Respuesta).HasMaxLength(500).IsRequired();
            Property(p => p.PreguntaId).IsRequired();
        }
    }
}
