using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; } 
        public int CodigoPostal { get; set; }
        //CREAMOS UN CONSTRUCTOR QUE 
        public Direccion() 
        {
            Debug.WriteLine("Constructor DIRECCION sin parametros");
        }
        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION 2 parametros");
            
        }
        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor DIRECCION 3 parametros");
        }
    }
}
