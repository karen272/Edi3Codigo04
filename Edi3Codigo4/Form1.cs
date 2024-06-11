using Edi3Codigo4.controller;
using Edi3Codigo4.Modelo;
using Edi3Codigo4.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edi3Codigo4
{
    public partial class Form1 : Form
    {
        private List<Employee> empleados;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal horasTrabajadas;
            if (Decimal.TryParse(txtHoras.Text, out horasTrabajadas))
            {
                enviarEmail();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void enviarEmail()
        {
            if (listEmpleados.SelectedIndex != -1)
            {

                Controller controler = new Controller();
                Employee empleadoSelec = empleados[listEmpleados.SelectedIndex];
                decimal horasTrabajadas = Decimal.Parse(txtHoras.Text);

                decimal resultado = controler.CalcularHoras(empleadoSelec, horasTrabajadas);

                MessageBox.Show("En total es: $" + resultado + " Le pertenece a " + empleadoSelec.Nombre);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StaticCalss.InstanciarTodo();
            empleados = listarEmpleados();
            listEmpleados.Items.Clear();

            foreach (Employee empleado in empleados)
            {
                listEmpleados.Items.Add(empleado.ToString());
            }
        }
        public List<Employee> listarEmpleados()
        {
            List<Employee> empleados = StaticCalss.empleados;
            empleados = StaticCalss.empleados;
            return empleados;
        }

       
    }
}
