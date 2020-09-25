using Capa.Services;
using Capa.Core.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Core.JsonClassResultado;

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
        public MensajeVistaModelo validarSeccionUsurio(string usuario, string pass)
        {
            MensajeVistaModelo retorno;
            retorno = new MensajeVistaModelo();
            ValidarResultado vr;
            vr = unitOfWork.UsuariosRoute.ValidarUsuario(usuario, pass);
            if (vr != null)
            {                
                if (vr.Mensaje== "correcto")
                {
                   
                    retorno.Exito = true;
                }
                else
                {
                    retorno.Exito = false;
                    retorno.Mensaje = "Error en el usuario o la contraseña";
                }
            }
            return retorno;
        }
    }
}
