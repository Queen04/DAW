using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PK1_PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Buenos Días !!!" : "Buenas Tardes !!!";
            return View();
        }
        //Get: /Home/RsvpForm
        //Renderea el Link de la forma del RSVP
        public ViewResult RsvpForm()
        {
            return View();
        }

    }
}
