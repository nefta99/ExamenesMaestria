using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class UsuariosMap : EntityTypeConfiguration<Usuarios>
    {
        public UsuariosMap()
        { 
            ToTable("Usuarios", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Nombre).HasMaxLength(60).IsRequired();
            Property(p => p.ApellidoPaterno).HasMaxLength(70).IsRequired();
            Property(p => p.ApellidoMaterno).HasMaxLength(60).IsOptional();
            Property(p => p.Contrasenia).HasMaxLength(70).IsRequired();
        }
    }
}
