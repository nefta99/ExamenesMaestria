using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class Preguntas
    {
        public int Id { get; set; }
        public string pregunta { get; set; }
        public int ComponenteId { get; set; }
        public Componentes Componentes { get; set; }
        public int CapituloId { get; set; }
        public Capitulos Capitulos { get; set; }
        public List<Respuestas> Respuestas { get; set; }
    }
}
