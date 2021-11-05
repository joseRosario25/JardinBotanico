using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JardinBotanic.Models;
using System.IO;

namespace JardinBotanic.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Encuesta()
        {
            return View();
        }

        public ActionResult Resultados(info dato, HttpPostedFileBase foto)
        {

            info Archivo = new info();
            Archivo.Edad = Request.Form["edad"].ToString();
            Archivo.Exp = Request.Form["exp"].ToString();
            Archivo.FavFlor = Request.Form["favFlor"].ToString();
            Archivo.Lugar = Request.Form["lugar"].ToString();
            Archivo.FlorCasa = Request.Form["florCasa"].ToString();
            Archivo.Fact = Request.Form["fact"].ToString();
            Archivo.Motiv = Request.Form["motiv"].ToString();
            info.DatosInfo.Add(Archivo);

            TXT txt = new TXT();

            txt.Guardar();
            txt.TEXTO();

            string nombre_fot = Path.GetFileName(foto.FileName);
            string rutafoto = Path.Combine(Server.MapPath("/Imagenes"), nombre_fot);
            foto.SaveAs(rutafoto);

            return View(info.DatosInfo);
        }

    }
}
