using Microsoft.VisualBasic;
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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posicionX = int.Parse(this.txtPosicionX.Text);
            int posicionY = int.Parse(this.txtPosicionY.Text);
            this.btnPosicion.Location = new Point(posicionX, posicionY);

        }

        private void btnBgColor_Click(object sender, EventArgs e)
        {

            int red = int.Parse(this.txtRojo.Text);
            int green = int.Parse(this.txtVerde.Text);
            int blue = int.Parse(this.txtAzul.Text);

            if (red <0 || red>255)
            {
                MessageBox.Show("El valor de rojo debe estar entre 0 y 255", "titulo del mensaje", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }else if (green <0 || green > 255)
            {
                MessageBox.Show("El valor de verde debe estar entre 0 y 255", "titulo del mensaje", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

            }else if(blue <0 || blue > 255)
            {
                MessageBox.Show("El valor de azul debe estar entre 0 y 255", "titulo del mensaje", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

            }
            else
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }

            
        }
    }
}
