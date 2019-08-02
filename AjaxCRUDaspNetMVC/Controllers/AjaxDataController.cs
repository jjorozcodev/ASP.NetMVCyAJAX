using System.Collections.Generic;
using System.Web.Mvc;
using AjaxCRUDaspNetMVC.Models;

namespace AjaxCRUDaspNetMVC.Controllers
{
    public class AjaxDataController : Controller
    {
        [HttpGet]
        public JsonResult ObtenerNombreUsuario()
        {
            return Json("admin", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Listar()
        {
            List<LenguajeProgramacion> data = GestorDatos.ObtenerLista();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Obtener(int id)
        {
            LenguajeProgramacion Obj = GestorDatos.ObtenerElemento(id);
            return Json(Obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Crear(LenguajeProgramacion obj)
        {
            GestorDatos.AgregarElemento(obj);
        }

        [HttpPost]
        public void Editar(LenguajeProgramacion obj)
        {
            GestorDatos.EditarElemento(obj);
        }

        [HttpPost]
        public void Borrar(int id)
        {
            GestorDatos.BorrarElemento(id);
        }

    }
}