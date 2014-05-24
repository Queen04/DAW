using EmployeeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            //creo el objeto
            //del modelo de datos
            PayrollDm nomina = new PayrollDm(
                @"C:\Users\USUARIO\Documents\Visual Studio 2012\Projects\Recover\EmployeeQuiz\Models\Bd_Empleados.csv");

            //Busco el empleado dado su ID
            var empleado = nomina.GetEmployeeById(emp.Id);
           
             //para que solo entren los numeros de control registrados
            double comprobacion = double.Parse(emp.Id);


            
            if (comprobacion <= 5 && comprobacion >=1)
            {
                return View("WorkerView", empleado);
            }

                //en caso contrario te renderea a otra vista
            else { return View("Noencontrado"); }
        }
            //return View("WorkerView", empleado);
        }

    }

