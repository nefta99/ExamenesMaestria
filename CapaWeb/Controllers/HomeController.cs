using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa.Core.VistaModelo;
using Capa.Data.Modelo;

namespace CapaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
    }
}