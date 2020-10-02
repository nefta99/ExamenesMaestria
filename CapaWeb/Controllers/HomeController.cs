using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Capa.Core.VistaModelo;
using Capa.Data.Modelo;
using Capa.Util;

namespace CapaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            
            try
            {
                var user = System.Web.HttpContext.Current.Session["sessionUsuario"];
                if (user == null )
                {                                                    
                    return View("~/Views/Login/Denegado.cshtml");                                    
                }
            }
            catch(Exception e)
            {
                BitacoraEventos.InsertaError("HomeController", "Index", "Mostrar Usuario", (e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()), "");
            }
             

            return View();
        }
        public ActionResult Valor()
        {
            UsuariosVistaModelo usuario = new UsuariosVistaModelo();
            try
            {
                usuario = new UsuarioModelo().checarUsuarios(2);
            }
            catch (Exception e)
            {

            }
            return View(usuario);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public string VerTipoUsuario(string user)
        {
            string json=""; 
            TipoUsuarioVistaModelo usu;
            
            UsuarioModelo modelo = new UsuarioModelo();
            try
            {
                user = System.Web.HttpContext.Current.Session["sessionUsuario"].ToString();
                usu = modelo.ValidarTipoUsuarioVarios(user);
                string host = HttpContext.Request.Url.Host;
                string htt = HttpContext.Request.Url.ToString();

                htt = htt.Substring(0, htt.IndexOf(':') + 1);
                string puerto = HttpContext.Request.Url.Port.ToString();
                usu.url = htt + "//" + host + ":" + puerto;

                json = new JavaScriptSerializer().Serialize(usu);
            }
            catch (Exception e)
            {
                BitacoraEventos.InsertaError("HomeController", "VerTipoUsuario", "Validar tipo usuario", (e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()), user);
            }

            
            return json;
        }
    }
}