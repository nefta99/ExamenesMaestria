using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class TipoUsuariosMap : EntityTypeConfiguration<TipoUsuarios>
    {
        public TipoUsuariosMap() { 
            ToTable("TipoUsuarios", "dbo");
            HasKey(p => p.Id);
            Property(p => p.TipoUsuario).HasMaxLength(60).IsRequired();
        }
    }
}
