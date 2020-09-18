using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class HistorialPreguntas
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuarios Usuarios { get; set; }
        public int CapituloId { get; set; }
        public Capitulos Capitulos { get; set; }
        public int PreguntaId { get; set; }
        public Preguntas Preguntas { get; set; }
        public List<HistorialRespuestas> HistorialRespuestas { get; set; }
    }
}
