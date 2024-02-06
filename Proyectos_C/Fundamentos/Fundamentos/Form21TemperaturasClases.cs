using ProyectoClases;
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
    public partial class Form21TemperaturasClases : Form
    {
        List<Temperaturas> temperaturas = new List<Temperaturas>();
  
        public Form21TemperaturasClases()
        {
            InitializeComponent();
            
        }

        private void btnGenerarTemperaturas_Click(object sender, EventArgs e)
        {
            this.lstTemperaturas.Items.Clear();
            Temperaturas objeto = new Temperaturas();
            temperaturas = objeto.GenerarTemperaturasMeses();

            for (int i = 0; i < temperaturas.Count; i++)
            {
                this.lstTemperaturas.Items.Add(this.temperaturas[i].mes);
            }


        }

        

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstTemperaturas.SelectedIndex;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < this.temperaturas.Count)
            {
                Temperaturas temperaturaSeleccionada = this.temperaturas[indiceSeleccionado];

                this.txtTemperaturaMaxima.Text = temperaturaSeleccionada.temperaturaMaxima.ToString();
                this.txtTemperaturaMinima.Text = temperaturaSeleccionada.temperaturaMinima.ToString();
                this.txtMedia.Text = temperaturaSeleccionada.media.ToString();
            }
        }
    }
}
