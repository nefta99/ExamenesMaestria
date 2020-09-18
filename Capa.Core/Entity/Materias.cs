using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class Materias
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPorUsuarioId { get; set; }
        public Usuarios Usuarios { get; set; }
        public List<Capitulos> Capitulos { get; set; }
    }
}
