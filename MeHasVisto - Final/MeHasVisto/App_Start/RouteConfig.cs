using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MeHasVisto
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //es una plantilla de ruteo y es la Queryable define como ban as estar definidas las peticiones http en los controladores
            routes.MapRoute(
                name: "Default", //
                url: "{controller}/{action}/{id}", // patron de la ruta, identifica el nombre del controlador, nombre de la accion, parametros del http
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional
         }
            );
        }
    }
}