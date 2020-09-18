using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class CalificacionesMap : EntityTypeConfiguration<Calificaciones>
    {
        public CalificacionesMap()
        {

            ToTable("Calificaciones", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Calificacion).IsRequired();
            Property(p => p.UsuarioId).IsRequired();
            Property(p => p.CapituloId).IsRequired();
        }

    }
}
