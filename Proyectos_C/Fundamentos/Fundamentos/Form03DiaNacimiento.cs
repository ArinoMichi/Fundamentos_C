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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAnio.Text);
            if (mes == 1)
            {
                mes = 13;
                anio = anio - 1;

            }else if (mes == 2)
            {
                mes = 14;
                anio = anio - 1;
            }
            int numero = calcularNumero(dia, mes, anio);
            string resultado = "";
            switch (numero)
            {
                case 0:
                    resultado = "SABADO";
                    break;
                case 1:
                    resultado = "DOMINGO";
                    break;
                case 2:
                    resultado = "LUNES";
                    break;
                case 3:
                    resultado = "MARTES";
                    break;
                case 4:
                    resultado = "MIERCOLES";
                    break;
                case 5:
                    resultado = "JUEVES";
                    break;
                case 6:
                    resultado = "VIERNES";
                    break;
            }

            this.lblResultado.Text = "Naciste en: "+ resultado;


        }
        private int calcularNumero(int diaAux, int mesAux, int anioAux)
        {
            int resultado;
            int operacion1 = ((mesAux + 1) * 3) / 5;
            int operacion2 = anioAux / 4;
            int operacion3 = anioAux / 100;
            int operacion4 = anioAux / 400;
            int operacion5 = diaAux + (mesAux*2) + anioAux + operacion1 + operacion2 - operacion3 + operacion4 +2;
            int operacion6 = operacion5 / 7;
            resultado = operacion5 - (operacion6 * 7);
            return resultado;
        }
    }
}
