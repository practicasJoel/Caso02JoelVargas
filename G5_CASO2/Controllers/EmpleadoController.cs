using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using G5_CASO2.Models;
using G5_CASO2.Clases;

namespace G5_CASO2.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        Empleado empleado_obj = new Empleado();
        public ActionResult Index()
        {
            IEnumerable<EMPLEADO> lst = empleado_obj.Consultar();
            return View(lst);
        }

        public ActionResult Guardar(EMPLEADO modelo)
        {
            return View(modelo);
        }

        public ActionResult Nuevo(EMPLEADO modelo)
        {
            empleado_obj.Guardar(modelo);
            return View("Guardar",modelo);
        }

        public ActionResult Modificar(int id)
        {
            EMPLEADO modelo = empleado_obj.Consultar(id);
            return View(modelo);
        }
        public ActionResult Cambiar(EMPLEADO modelo)
        {
            empleado_obj.Modificar(modelo);
            return View("Modificar",modelo);
        }

        public ActionResult Detalle(int id)
        {
            EMPLEADO modelo = empleado_obj.Consultar(id);
            return View(modelo);
        }

        public ActionResult Eliminar(int id)
        {
            EMPLEADO modelo = new EMPLEADO()
            {
                ID_EMPLEADO = id
            };
            empleado_obj.Eliminar(modelo);
            IEnumerable<EMPLEADO> lst = empleado_obj.Consultar();
            return View("Index",lst);
        }
    }
}