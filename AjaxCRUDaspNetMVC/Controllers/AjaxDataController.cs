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
            List<LenguajeProgramacion> Data = GestorDatos.ObtenerLista();
            return Json(Data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Obtener(int Id)
        {
            LenguajeProgramacion Obj = GestorDatos.ObtenerElemento(Id);
            return Json(Obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Crear(LenguajeProgramacion lp)
        {
            GestorDatos.AgregarElemento(lp);
        }

        [HttpPost]
        public void Editar(LenguajeProgramacion lp)
        {
            GestorDatos.AgregarElemento(lp);
        }

        [HttpPost]
        public void Borrar(int Id)
        {
            GestorDatos.BorrarElemento(Id);
        }

    }
}