using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class Capitulos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion  { get; set; }
        public  int  CreadoPorUsuarioId { get; set; }
        public Usuarios Usuarios { get; set; }
        public int  MateriaId { get; set; }
        public Materias Materias { get; set; }
        public List<Calificaciones> Calificaciones { get; set; }




    }
}
