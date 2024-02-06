using ProyectoClases.Helpers;
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

namespace Fundamentos
{
    public partial class Form23Mascotas : Form
    {

        HelperMascotas helper;

        public Form23Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }


        private void DibujarMascotasListBox()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota masc in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(masc.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotasListBox();
        }

        private async void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                await this.helper.ReadMascotasAsync(path);
                this.DibujarMascotasListBox();

            }
        }

        private async void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                await this.helper.WriteMascotasAsync(path);
                MessageBox.Show("Mascotas almacenadas");
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstMascotas.SelectedIndex;
            if(indiceSeleccionado != -1)
            {
                Mascota mascota = this.helper.Mascotas[indiceSeleccionado];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
