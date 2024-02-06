using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        public HelperMascotas() 
        {
            this.Mascotas = new List<Mascota>();
        }

        public async Task WriteMascotasAsync(string path)
        {
            //AL ESCRIBIR DEBEMOS CONVERTIR LA COLECCION A STRING
            string data = this.ConvertMascotasString();
            await HelperFiles.WriteFileAsync(path, data);

        }

        public async Task ReadMascotasAsync(string path)
        {
            //LEEMOS EL FICHERO QUE NOS HAN DADO
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertirMascotasList(data);
        }
        

        //NOSOTROS EN ESTA CLASE TENEMOS UN CONJUNTO DE MASCOTAS
        //GARFIELD,GATO#PLUTO,PERRO
        //NECESITAMOS CONVERTIR UN TEXTO A COLECCION DE OBJETOS
        private string ConvertMascotasString()
        {
            string data = "";
            foreach (Mascota masc in Mascotas)
            {
                data += masc.Nombre + "," + masc.Raza + "#";
            }
            data = data.TrimEnd('#');
            return data;
        }

        //TAMBIEN TENDREMOS QUE LEER DE UN FICHERO LAS MASCOTAS
        //AL LEER DEBEMOS CONVERTIR EL STRING EN COLECCION
        //GARFIELD,GATO#PLUTO,PERRO
        private void ConvertirMascotasList(string data)
        {
            //LIMPIAR LA COLECCION DE MASCOTAS
            this.Mascotas.Clear();
            //SEPARAMOS LOS DATOS DE CADA MASCOTA POR OBJETO
            string[] datosMascotas = data.Split('#');
            foreach (string datos in datosMascotas)
            {
                //VOLVEMOS A SEPARAR POR EL SEPARADOR DE PROPIEDADES QUE HEMOS UTILIZADO
                string[] propiedades = datos.Split(",");
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

    }
}
