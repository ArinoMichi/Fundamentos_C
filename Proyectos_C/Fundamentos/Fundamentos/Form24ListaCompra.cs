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
    public partial class Form24ListaCompra : Form
    {
        HelperListaCompra helper;
        public Form24ListaCompra()
        {
            InitializeComponent();
            helper = new HelperListaCompra();
        }

        private void DibujarListaListBox()
        {
            this.lstListaCompra.Items.Clear();
            foreach (Producto pro in this.helper.listaCompra)
            {
                this.lstListaCompra.Items.Add(pro.Nombre + " : " + pro.Cantidad);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtNombre.Text;
            producto.Cantidad = int.Parse(this.txtCantidad.Text);
            this.helper.listaCompra.Add(producto);
            this.DibujarListaListBox();

        }

        private async void btnLeerFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                await this.helper.ReadListaAsync(path);
                this.DibujarListaListBox();

            }
        }

        private async void btnEscribirFichero_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                await this.helper.WriteListaAsync(path);
                MessageBox.Show("Lista almacenada");
            }
        }
    }
}
