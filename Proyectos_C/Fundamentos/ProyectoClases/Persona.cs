using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum Paises { España, Francia, Alemania, Andorra}
    public enum TipoGenero { Masculino, Femenino}
    public class Persona
    {
        #region CONSTRUCTORES


        public Persona() 
        {
            Debug.WriteLine("Constructor VACIO Persona");
        }
        //LA CLASE PERSONA SOLO TIENE UN UNICO CONSTRUCTOR CON PARAMETROS
        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor 2 parametros Persona");
            this.Nombre= nombre;
            this.Apellidos= apellidos;
        }

        #endregion


        #region PROPIEDADES

        //CONJUNTO PARA ALMACENAR DESCRIPCIONES
        private string[] descripciones = new string[3];

        //PROPIEDAD INDIZADA PARA ALMACENAR DESCRIPCIONES 
        //DE UNA PERSONA
        public string this[int index]
        {
            get
            {
                //DEVOLVEMOS LA DESCRIPCION DE UNA POSICION
                return this.descripciones[index];
            }
            set
            {
                //ALMACENAMOS EN EL INDICE DEL ARRAY LA NUEVA
                //DESCRIPCION
                this.descripciones[index] = value;
            }
        }


        public Direccion Domicilio { get; set; }   
        public Direccion DomicilioVacaciones { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get;set; }
        private TipoGenero _Genero;
        public TipoGenero Genero 
        { 
            get
            {
                return _Genero;
            }
            set
            {
                //DEBEMOS COMPROBAR LOS VALORES DE LA ENUMERACION
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor de genero incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }


        //CAMPO PROPIEDAD PARA EDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set 
            {
                //NECESITAMOS COMPROBAR EL VALOR QUE SE HA ASIGNADO
                //A LA PROPIEDAD EDAD
                
                if (value<=0) 
                {
                    //1) ERROR SILENCIOSO
                    //this._Edad = 0;
                    //2)LANCAR UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa! ");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        /* public int Edad;

         //EN LAS PROPIEDADES SE UTILIZAN CAMPOS
         //PRIVADOS PARA CONTROLAR LOS VALORES DE LA
         //PROPIEDAD. DICHOS CAMPOS DEBEN SER DEL MISMO
         //TIPO QUE LA PROPIEDAD.
         //NORMALMENTE, LOS CAMPOS DE PROPIEDAD SE DENOMINAN
         //MEDIANTE EL GUION BAJO Y NOMBRE DE PROPIEDAD
         //persona._Propiedad= "Ejemplo";
         private string _Propiedad;
         public string Propiedad
         {
             get
             {
                 return this._Propiedad;
             }
             set
             {
                 this._Propiedad = value;

             }
         }*/
        #endregion

        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public String GetNombreCompleto(bool orden)
        {
            if(orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                //UTILIZAMOS EL METODO ANTERIOR SIN PARAMETROS
                return this.GetNombreCompleto();
            }
            
        }

        public void MetodoParametrosOpcionales(int numero1, int numero2 = 444, int numero3 = 0)
        {

        }

        

        #endregion
    }

}
