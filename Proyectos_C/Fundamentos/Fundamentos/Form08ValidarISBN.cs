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
    public partial class Form08ValidarISBN : Form
    {
        public Form08ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string ISBN = this.txtISBN.Text;
            int suma = 0;
            if (ISBN.Length > 10)
            {
                this.lblResultado.Text = "El ISBN es demasiado largo";
            }
             else if (!ISBN.All(char.IsDigit))
            {
                this.lblResultado.Text = "El ISBN debe contener solo números";
                return;
            }
            else
            {
                for (int i = 0; i < ISBN.Length; i++)
                {
                    char caracter = ISBN[i];
                    int numero = int.Parse(caracter.ToString());
                    suma = suma + numero *(i+1);
                }
                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "El ISBN es válido";
                }
                else
                {
                    this.lblResultado.Text = "El ISBN no es válido";
                }

            }

         
        }
    }
}
