

using Capa.Data.Repositorio;
using Capa.Services;
using Capa.Services.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data
{
    public  class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public int Complete() { return _context.SaveChanges(); }
        public void Dispose() { _context.Dispose(); }
        //Atributos
        public IUsuariosRepository UsuariosRoute { get; private set; }

        //Constructor
        public UnitOfWork(DataContext context)
        {
            _context = context;
            UsuariosRoute = new UsuariosRepository(_context);

        }

        
    }
}
