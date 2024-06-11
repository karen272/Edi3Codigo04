using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Codigo4.Modelo
{
    public class Employee
    {
        private int id;
        private string nombre;
        private Puesto puesto;
        private string email;

        public Employee () { }

        public Employee (int id,string nombre, Puesto puesto,string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.puesto = puesto;
            this.email= email;
            
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;  }
        }


        public Puesto Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        

        public override string ToString()
        {
            return Nombre + " " + Puesto.Position +" " + Email ;
        }


    }
}
