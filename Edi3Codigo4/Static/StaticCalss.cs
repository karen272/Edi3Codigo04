using Edi3Codigo4.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Codigo4.Static
{
    internal class StaticCalss
    {
        public static List<Employee> empleados = new List<Employee>();
        public static void InstanciarTodo()
        {
            instanciarEmpleados();
        }

        private static void instanciarEmpleados()
        {
            empleados.Add(new Employee(1,"Jony",  new Puesto("Gerente", 7900),"jony@gmail.com"));
            empleados.Add(new Employee(2,"Emy",  new Puesto("gerente", 7900), "Emy@gmail.com"));
            empleados.Add(new Employee(3,"Pepe",  new Puesto("empleado", 2500), "Pepe@gmail.com"));
            empleados.Add(new Employee(4, "Ka", new Puesto("Gerente general", 9700), "ka@gmail.com"));
            empleados.Add(new Employee(4, "Pedro", new Puesto("Gerente general", 9700)  , "pedro@gmail.com"));
        }

    }
}
