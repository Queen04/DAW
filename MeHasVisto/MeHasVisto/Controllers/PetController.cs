using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ViewResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
            //var cont = (string)RouteData.Values["controller"];
            //var act = (string)RouteData.Values["action"];
            //return name+cont+act;
            //var model = PetManagement.GetByName(name);
           // if (model == null)
            return RedirectToAction("NotFound");
            //return View(model);
        }

        public ActionResult NotFount()
        {
            return View();
        }

        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture =@"C:\Users\USUARIO\Pictures\foOtiicoOs\pick´s/" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg";
            return File(picture, contentType, fileName);

        }
    }
}
