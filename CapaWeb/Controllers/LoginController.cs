using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Capa.Core.VistaModelo;
using Capa.Data.Modelo;
using Capa.Util;

namespace CapaWeb.Controllers
{
    public class LoginController : Controller
    {
        //login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string ValidarUsuario(string usuario, string pass)
        {
            MensajeVistaModelo res;
             UsuarioModelo um = new UsuarioModelo();
            string json="";
            try
            {
                res = um.validarSeccionUsurio(usuario, pass);
                if (res.Exito == true)
                {
                    System.Web.HttpContext.Current.Session["sessionUsuario"] = usuario;
                }
                json=new JavaScriptSerializer().Serialize(res);
            }catch(Exception e)
            {
                res = new MensajeVistaModelo();
                res.Exito = false;
                res.Mensaje="Error, contacte al administrador";
                BitacoraEventos.InsertaError("HomeController", "Index", "Mostrar Usuario", (e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()), "L03036903");

            }
            
           
            
            return json;
        }
    }
}
