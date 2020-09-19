using Capa.Services;
using Capa.Core.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.Modelo
{
    public class UsuarioModelo
    {
        //Propiedades
        readonly IUnitOfWork unitOfWork = new UnitOfWork(new DataContext());

        //Metodos
        public UsuariosVistaModelo checarUsuarios(int id)
        {
            UsuariosVistaModelo us = unitOfWork.UsuariosRoute.ObtenerUsuarioEspecifico(id);

            return us;
        }
        public MensajeVistaModelo InsertarUsuario(string Nombre,string Paterno,string Materno,string
            Contrasenia, int TipoUsuarioId, string Matricula)
        {
            MensajeVistaModelo retorno;
            retorno = unitOfWork.UsuariosRoute.InsertarUsuarioCompleto(Nombre, Paterno, Materno, Contrasenia, TipoUsuarioId, Matricula);
            return retorno;
        }

    }
}
