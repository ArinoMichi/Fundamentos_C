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
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            string cadena = "hola coca cola";
            //LA POSICION D ELOS ELEMENTOS D LA CADENA NO VARIAN
            //INDEPENDIENTEMENTE DE SI BUSCAMOS CON LASTINDEXOF
            //LA SOBRECARGA ES A PARTIR DE, PERO CONTANDO DESDE EL FINAL
            int posicion = cadena.LastIndexOf("o"); //posicion 11
            int posicion2 = cadena.LastIndexOf("o", 10); //posicion 6
            //LA POSICION DE BUSQUEDA ESTA INCLUIDA
            //oca colaF
            string subcadena = cadena.Substring(6);
            //oca
            string subcadena2 = cadena.Substring(6, 3);

            string cadena2 = "@@@hola coc@ cola@@@";
            //hola coc@ cola
            string resultado = cadena2.Trim('@');

            string cadena3 = "hola";
            //@@@@@@@@hola
            string resultado2 = cadena3.PadLeft(10, '@');

            string cadena4 = "hola coca cola";
            //h$la c$ca c$la
            string subcadena3 = cadena4.Replace('o', '$');


            for (int i = 0; i <= 255; i++) 
            {
                //CONVERTIMOS EL INT A CHAR
                char caracter = Convert.ToChar(i);

                if (char.IsLetter(caracter) == true)
                { 
                    this.txtLetras.Text += " " + caracter.ToString();
                }else if (char.IsDigit(caracter) == true)
                {
                    this.txtDigitos.Text += " " + caracter.ToString();
                } else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbolos.Text += " " + caracter.ToString();
                }else if(char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text += " " + caracter.ToString();
                }
                
            }
        }
    }
}
