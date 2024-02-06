using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado :Persona
    {

        protected int SalarioMinimo { get; set; }

        public Empleado() :base("Nombre","Apellidos")
        {
            Debug.WriteLine("Constructor VACIO Empleado");
            this.SalarioMinimo = 2000;
        }

        public Empleado(String nombre, string apellidos) :base(nombre,apellidos)
        {
            Debug.WriteLine("Constructor 2 parametros Empleado");
            this.Nombre=nombre;
            this.Apellidos=apellidos;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public int GetDiasVacaciones()
        {
            Debug.WriteLine("Get Vacaciones() Empleado");
            return 22;
        }

        public override string ToString()
        {
            return this.GetNombreCompleto();
        }
    }
}
