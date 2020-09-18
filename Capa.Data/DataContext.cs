using Capa.Core.Entity;
using Capa.Data.EntityMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name= ConexionesBD")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new UsuariosMap());
            modelBuilder.Configurations.Add(new TipoUsuariosMap());
            modelBuilder.Configurations.Add(new MateriasMap());
            modelBuilder.Configurations.Add(new CapitulosMap());
            modelBuilder.Configurations.Add(new ComponentesMap());
            modelBuilder.Configurations.Add(new PreguntasMap());
            modelBuilder.Configurations.Add(new RespuestasMap());
            modelBuilder.Configurations.Add(new CalificacionesMap());
        }
        public virtual DbSet<Usuarios> UsuariosConexion { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuariosConexion { get; set; }
        public virtual DbSet<Materias> MateriasConexion { get; set; }
        public virtual DbSet<Capitulos> CapitulosConexion { get; set; }
        public virtual DbSet<Componentes> ComponentesConexion { get; set; }
        public virtual DbSet<Preguntas> PreguntasConexion { get; set; }
        public virtual DbSet<Respuestas> RespuestasConexion { get; set; }
        public virtual DbSet<Calificaciones> CalificacionesConexion { get; set; }


    }
}
