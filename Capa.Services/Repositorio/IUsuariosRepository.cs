using Capa.Core.Entity;
using Capa.Core.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Services.Repositorio
{
    public interface IUsuariosRepository : IRepository<Usuarios>
    {
        Usuarios GetUsuariosPorId(int id);
        int AgregarUsuario(string nombre, string pwd);
        UsuariosVistaModelo ObtenerUsuarioEspecifico(int id);
    }
}
