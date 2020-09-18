using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Services.Repositorio;

namespace Capa.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuariosRepository UsuariosRoute { get; }
        int Complete();
    }
}
