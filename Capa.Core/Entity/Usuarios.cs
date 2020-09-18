using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string  ApellidoMaterno { get; set; }
        public string Contrasenia { get; set; }
        public int TipoUsuarioId { get; set; }
        public TipoUsuarios TipoUsuarios { get; set; }
        public List<Capitulos> Capitulos { get; set; }
        public List<Materias> Materias { get; set; }
        public List<Calificaciones> Calificaciones { get; set; }
        public List<HistorialPreguntas> HistorialPreguntas { get; set; }
        public string Matricula { get; set; }


    }
}
