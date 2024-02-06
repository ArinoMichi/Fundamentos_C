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
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        void GetDobleValor(int num)
        {
            num = num * 2;
        }

        private void Form14Metodos_Load(object sender, EventArgs e)
        {

        }

        private void Form14Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //HANDLED DESACTIVA LOS EVENTOS SUCESIVOS DEL EVENTO
            //KEYCHAR ES LA TECLA PULSADA
            this.lblResultado.Text = e.KeyChar.ToString();
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
