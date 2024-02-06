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
    public partial class Form12PracticaColeccionNumeros : Form
    {
        public Form12PracticaColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(0, 100);
                this.lstNumeros.Items.Add(numero);

            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumapares=0;
            int sumaimpares = 0;
            foreach (int item in this.lstNumeros.Items)
            {
                suma += item;
                if (item%2==0)
                {
                    sumapares += item;
                }
                else
                {
                    sumaimpares += item;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumapares.ToString();
            this.txtImpares.Text = sumaimpares.ToString();

        }
    }
}
