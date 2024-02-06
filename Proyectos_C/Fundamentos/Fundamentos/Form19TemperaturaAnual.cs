using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form19TemperaturaAnual : Form
    {
        List<int> temperaturas;
        public Form19TemperaturaAnual()
        {
            InitializeComponent();
            this.temperaturas = new List<int>();

        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            this.lstTemperaturas.Items.Clear();
            this.temperaturas.Clear();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2024");
            for (int i = 0; i < 12; i++)
            {
                int temp = random.Next(-28, 45);
                this.temperaturas.Add(temp);
                string nombreMes = fecha.ToString("MMMM");
                fecha = fecha.AddMonths(1);
                this.lstTemperaturas.Items.Add(nombreMes + ": " + temp);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int maxima = 0;
            int minima = 0;
            int media = 0;
            int suma = 0;
            foreach (int temp in temperaturas)
            {
                suma += temp;
                maxima = Math.Max(maxima, temp);
                minima = Math.Min(minima, temp);

            }
            media = suma / this.temperaturas.Count;

            this.txtMaxima.Text = maxima.ToString();
            this.txtMinima.Text = minima.ToString();
            this.txtMedia.Text = media.ToString(); 
        }
    }
}
