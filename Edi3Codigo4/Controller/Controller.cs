using Edi3Codigo4.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Codigo4.controller
{
    public class Controller
    {
        public Controller() { }

        public decimal CalcularHoras(Employee empleado, decimal horas)
        {
            return empleado.Puesto.HourlySalary * horas;
        }
    }
}
