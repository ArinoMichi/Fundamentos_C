using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director :Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR");
            this.SalarioMinimo += 200;
        }

        //OVERRIDE
        public new int GetDiasVacaciones()
        {
            //NECESITAMOS LEER PRIMERO LA CLSE BASE PARA
            //RECUPERAR LAS VACACIONES DE UN EMPLEADO

            int vacaciones =
                base.GetDiasVacaciones();

            Debug.WriteLine("GetVacaciones() Director");
            return vacaciones +8;
        }
    }
}
