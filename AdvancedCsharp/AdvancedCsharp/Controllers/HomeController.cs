using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedCsharp.Models;

namespace AdvancedCsharp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public String Index()
        {
            return "Navegar a una URL para mostrar un ejemplo";
        }
        public ViewResult AutoProperty()
        {
            //crear un nuevo objeto
            //de la clase producto
            Product myProduct = new Product
            {
                //establece el valor de la propiedad
                ProductID = 12,
                Name = "Kayak",
                Description = "Kiosteca blue",
                category = "SPORTS",
                price = 12.5f
            };

            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                myProduct.ProductID,
            myProduct.Name,
            myProduct.Description,
            myProduct.category,
            myProduct.price);
            //genera la vista
            return View("Results", (object)salida);
        }
        
    }
}
