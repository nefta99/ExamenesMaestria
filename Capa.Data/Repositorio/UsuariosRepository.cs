using Capa.Core.Entity;
using Capa.Services.Repositorio;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Core.VistaModelo;

namespace Capa.Data.Repositorio
{
    public class UsuariosRepository : Repository<Usuarios>, IUsuariosRepository
    {
        //Constructor
        public UsuariosRepository(DataContext _context) : base(_context) { }
        public DataContext Contexto { get { return Context as DataContext; } }

        public Usuarios GetUsuariosPorId(int id)
        {
            Usuarios user =
                (from qry in Contexto.UsuariosConexion.Where(o => o.Id == id) select qry).FirstOrDefault();
            return user;
        }

        public int AgregarUsuario(string nombre, string pwd)
        {
            DataContext context = new DataContext();
            var datos = context.Database.SqlQuery<int>("AgregarUsuario @nombre, @password",
                                                                            new SqlParameter("@nombre", nombre),
                                                                            new SqlParameter("@password", pwd)).FirstOrDefault();
            return datos;
        }

        public UsuariosVistaModelo ObtenerUsuarioEspecifico(int id)
        {
            UsuariosVistaModelo resultado = new UsuariosVistaModelo();
            resultado = (
                    from u in Contexto.UsuariosConexion
                    join t in Contexto.TipoUsuariosConexion on u.TipoUsuarioId equals t.Id
                    where u.Id == id
                    select new UsuariosVistaModelo()
                    {
                        Id = u.Id,
                        Nombre = u.Nombre,
                        Paterno = u.ApellidoPaterno,
                        Materno = u.ApellidoMaterno,
                        Contrasenia = u.Contrasenia,
                        Matricula = u.Matricula,
                        TipoUsuario = t.TipoUsuario
                    }
                ).FirstOrDefault();
           //Tomamos el resultado y lo mandamos a donde se necesita
            return resultado;
        }


    }
}
