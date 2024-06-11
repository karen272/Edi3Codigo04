using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Codigo4.Modelo
{
    public class Puesto
    {
        private string position;
        private decimal hourlySalary;

        public Puesto () { }
        public Puesto (string position, decimal hourlySalary)
        {
            this.position = position;
            this.hourlySalary = hourlySalary;
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public decimal HourlySalary
        {
            get { return hourlySalary; }
            set { hourlySalary = value; }
        }



    }
}
