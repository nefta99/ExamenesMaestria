using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class ComponentesMap : EntityTypeConfiguration<Componentes>
    {
        public ComponentesMap()
        {
            ToTable("Componentes", "dbo");
            HasKey(p => p.Id);
            Property(p => p.TipoComponente).HasMaxLength(80).IsRequired();
        }
    }
}
