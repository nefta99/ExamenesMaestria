using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class Calificaciones
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuarios Usuarios { get; set; }
        public float Calificacion { get; set; }
        public int CapituloId { get; set; }
        public Capitulos Capitulos { get; set; }
    }
}
