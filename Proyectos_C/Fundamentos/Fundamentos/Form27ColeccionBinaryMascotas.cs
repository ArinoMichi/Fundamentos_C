using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form27ColeccionBinaryMascotas : Form
    {
        BinaryFormatter binaryFormatter;
        List<Mascota> mascotasList;
        public Form27ColeccionBinaryMascotas()
        {
            InitializeComponent();

            this.binaryFormatter = new BinaryFormatter();
            this.mascotasList = new List<Mascota>();
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            using (FileStream reader = new FileStream("listamascotas.dat", FileMode.Open))
            {
                this.mascotasList = (ColeccionMascotas)this.binaryFormatter.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();

        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {

        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }
    }
}
