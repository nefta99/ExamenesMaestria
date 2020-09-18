using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class Respuestas
    {
        public  int Id { get; set; }
        public string Respuesta { get; set; }
        public float Valor { get; set; }
        public int PreguntaId { get; set; }
        public Preguntas Preguntas { get; set; }

    }
}
