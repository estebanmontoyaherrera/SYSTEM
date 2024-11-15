using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Views
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        public ActionResult Index()
        {
            Response.Cookies.Add(new HttpCookie("session", ""));
            this.Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            this.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            this.Response.Cache.SetNoStore();
            return View();
        }
        [HttpGet]
        public JsonResult Listar()
        {


            List<Usuario> oLista = new List<Usuario>();

            oLista = new BusinessUsuario().Listar();


            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult Guardar(Usuario objeto)
        {
            object resultado;
            string mensaje = string.Empty;

            if (objeto.IdUsuario == 0)
            {

                resultado = new BusinessUsuario().Registrar(objeto, out mensaje);
            }
            else
            {
                resultado = new BusinessUsuario().Editar(objeto, out mensaje);

            }

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Eliminar(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new BusinessUsuario().Eliminar(id);

            return Json(new { resultado = respuesta }, JsonRequestBehavior.AllowGet);
        }
    }
}