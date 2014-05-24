using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace EmployeeQuiz.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Ingrese el codigo del empleado")]
        [RegularExpression("1,2,3,4,5",
            ErrorMessage = "Favor de ingresar un codigo de empleado valido")]
        public string Id{ get; set; }//Representa las propiedades de un Empleado 

        public string Name { get; set; }//Modela a una persona
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public string Position { get; set; }
        public double Wage { get; set; }
        public char Sex{ get; set; }
        public string PhotoPath { get; set; }
    }
}