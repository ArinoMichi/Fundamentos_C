using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
            this.btnBajar.Enabled = false;
            this.btnSubir.Enabled = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text;
            int index = this.lstTienda.FindString(elem);

            if (index == -1)
            {
                this.lstTienda.Items.Add(elem);
            }
            else
            {
                // Item found, select it in the list
                this.lstTienda.SelectedIndex = index;
            }


            this.txtProducto.Focus();
            this.txtProducto.SelectAll();
        }

        private void btnBorrarTodos_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstTienda.SelectedIndices.Count;

            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                //ELIMINAMOS CADA ELEMENTOS POR SU INDICE DE LA COLECCION
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.SelectedItems)
            {
                this.lstProductos.Items.Add(item);

            }
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];

                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.Items)
            {
                this.lstProductos.Items.Add(item);
            }
            this.lstTienda.Items.Clear();
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ultimoIndex = lstProductos.Items.Count - 1;
            if (this.lstProductos.SelectedIndex != 0)
            {
                this.btnSubir.Enabled = true;
            }
            else
            {
                this.btnSubir.Enabled = false;
            }
            if (this.lstProductos.SelectedIndex != ultimoIndex)
            {
                this.btnBajar.Enabled = true;

            }
            else
            {

                this.btnBajar.Enabled = false;
            }

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            object selectedItem = this.lstProductos.SelectedItem;

            this.lstProductos.Items.RemoveAt(index);
            this.lstProductos.Items.Insert(index - 1, selectedItem);

            // Update the selected index to reflect the move
            this.lstProductos.SelectedIndex = index - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            object selectedObject = this.lstProductos.SelectedItem;

            this.lstProductos.Items.RemoveAt(index);
            this.lstProductos.Items.Insert(index + 1, selectedObject);

            this.lstProductos.SelectedIndex = index + 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
