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
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void Form10ColeccionGrafica_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //PARA ELIMINAR DE UNA COLECCION TENEMOS DOS OPCIONES
            //1) Remove(objeto: ELIMINA UN ELEMENTO ENVIANDO EL OBJETO
            //2) RemoveAt(indice): ELIMINA UN ELEMENTO POR SU INDICE
            //Recuperamos el indice seleccionado del listbox
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indice);
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstElementos.SelectedIndex != -1)
            {
                this.lblIndiceSeleccionado.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblSeleccionado.Text = this.lstElementos.SelectedItem.ToString();
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
    }
}
