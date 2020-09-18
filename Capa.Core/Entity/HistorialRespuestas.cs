using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class HistorialRespuestas
    {
        public int Id { get; set; }
        public int RespuestaId { get; set; }
        public Respuestas Respuestas { get; set; }
        public int HistorialPreguntaId { get; set; }
        public HistorialPreguntas HistorialPreguntas { get; set; }
    }
}
