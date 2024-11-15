using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult ListarRol()
        {

            List<Rol> oLista = new List<Rol>();
            oLista = new BusinessRol().ListarRol();
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult GuardarRol(Rol objeto)
        {
            object resultado;
            string mensaje = string.Empty;

            if (objeto.IdRol == 0)
            {

                resultado = new BusinessRol().Registrar(objeto, out mensaje);
            }
            else
            {
                resultado = new BusinessRol().Editar(objeto, out mensaje);

            }

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public JsonResult EliminarRol(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new BusinessRol().Eliminar(id, out mensaje);

            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }
    }
}