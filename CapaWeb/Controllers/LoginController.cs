using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Capa.Core.JsonClassResultado;

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
            RespuestaJsonClassResultado res = new RespuestaJsonClassResultado();
            res.exito = true;
            res.Resultado = "Funciono";
            var json = new JavaScriptSerializer().Serialize(res);
            return json;
        }
    }
}
