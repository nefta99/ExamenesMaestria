using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public  class HistorialRespuestasMap : EntityTypeConfiguration<HistorialRespuestas>
    {
        public HistorialRespuestasMap()
        {
            ToTable("HistorialRespuestas", "dbo");
            HasKey(p => p.Id);
            
        }
    }
}
