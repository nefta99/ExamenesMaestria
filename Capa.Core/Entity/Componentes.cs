using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class Componentes
    {
        public int Id { get; set; }
        public string TipoComponente { get; set; }
        public List<Preguntas> Preguntas { get; set; }
    }
}
