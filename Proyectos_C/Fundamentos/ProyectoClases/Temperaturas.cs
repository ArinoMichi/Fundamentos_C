using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Temperaturas
    {
        public string mes { get; set; }
        public int temperaturaMaxima { get; set; }
        public int temperaturaMinima { get; set; }
        public int media { get; set; }


        public List<Temperaturas> GenerarTemperaturasMeses()
        {
            List<Temperaturas> temperaturas = new List<Temperaturas>();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2024");

            for (int i = 0; i < 12; i++)
            {
                temperaturas.Add(new Temperaturas());
                int tempMaxima = random.Next(-28, 45);
                int tempMinima = random.Next(-28, 45);

                if (tempMaxima > tempMinima)
                {
                    temperaturas[i].temperaturaMaxima = tempMaxima;
                    temperaturas[i].temperaturaMinima = tempMinima;
                }
                else
                {
                    temperaturas[i].temperaturaMaxima = tempMinima;
                    temperaturas[i].temperaturaMinima = tempMaxima;
                }

                // Acceder al elemento i y asignar los valores

                temperaturas[i].media = (tempMinima + tempMaxima) / 2;

                string nombreMes = fecha.ToString("MMMM");
                fecha = fecha.AddMonths(1);
                temperaturas[i].mes = nombreMes;
            }
            return temperaturas;
        }

    }
}
