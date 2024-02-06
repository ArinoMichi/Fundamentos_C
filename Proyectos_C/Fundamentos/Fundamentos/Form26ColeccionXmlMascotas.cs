using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form26ColeccionXmlMascotas : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotasList;
        public Form26ColeccionXmlMascotas()
        {
            InitializeComponent();

            this.serializer = new XmlSerializer(typeof(ColeccionMascotas));
            this.mascotasList = new ColeccionMascotas();

        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("listamascotas.xml"))
            {
                this.mascotasList = (ColeccionMascotas)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();
        }

        private async void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("listamascotas.xml"))
            {
                this.serializer.Serialize(writer, this.mascotasList);
                await writer.FlushAsync();
                writer.Close();
            }
            this.lstMascotas.Items.Clear();
            this.mascotasList.Clear();
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombe.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnios.Text);

            this.mascotasList.Add(mascota);
            this.txtNombe.Clear();
            this.txtRaza.Clear();
            this.txtAnios.Clear();
            this.DibujarMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                this.txtNombe.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtAnios.Text = mascota.Years.ToString();
            }
        }
    }
}
