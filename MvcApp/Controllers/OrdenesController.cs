using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.ProxyOrdenesCompra;
namespace MvcApp.Controllers
{
    public class OrdenesController : Controller
    {
        //
        // GET: /Ordenes/
        OrdenesCompraClient _servicio = new OrdenesCompraClient();
        public ActionResult Index()
        {
            ViewBag.ListarOrdenes = _servicio.ListarOrdenes();
            return View();
        }
        public ActionResult Buscar(FormCollection fc)
        {
            //Se toman los valores de los controles
            String criterio = fc["criterio"];
            String condicion = fc["condicion"];

            if (condicion.Equals("PorCodigo"))
            {
                ViewBag.ListarOrdenes = _servicio.ListarOrdenesProveedor(criterio);
            }
            else if (condicion.Equals("PorEstado"))
            {
                ViewBag.ListarOrdenes = _servicio.ListarOrdenesEstado(criterio);
            }
            else
            {
                ViewBag.ListarOrdenes = _servicio.ListarOrdenes();
            }
            return View("Index");
        }

    }
}
