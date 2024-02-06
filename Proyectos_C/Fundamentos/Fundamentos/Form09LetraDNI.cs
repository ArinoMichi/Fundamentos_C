using System;
using System.Linq;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form09LetraDNI : Form
    {
        public Form09LetraDNI()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;

            if (dni.Length == 9)
            {
                // Verificar si los primeros 8 caracteres son dígitos y el último es una letra
                if (dni.Substring(0, 8).All(char.IsDigit) && char.IsLetter(dni[8]))
                {
                    int numeroDNI = int.Parse(dni.Substring(0, 8));
                    char letraDNI = dni[8];

                    char letraCalculada = CalcularLetraDNI(numeroDNI);

                    if (letraDNI == letraCalculada)
                    {
                        lblResultado.Text = $"El DNI {dni} es válido";
                        return;
                    }
                    else
                    {
                        lblResultado.Text = $"El DNI {dni} no es válido";
                        return;
                    }
                }
            }

            // Si no cumple con la validación anterior, realizar la validación original para DNI de 8 dígitos
            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                lblResultado.Text = "El DNI debe contener 8 dígitos numéricos";
                return;
            }

            int numeroDNIOriginal = int.Parse(dni);
            char letraDNIOriginal = CalcularLetraDNI(numeroDNIOriginal);

            lblResultado.Text = $"La letra del DNI {dni} es: {letraDNIOriginal}";
        }

        private char CalcularLetraDNI(int numeroDNI)
        {
            int numero = numeroDNI - ((numeroDNI/23)*23);

            char letraDNI;
            switch (numero)
            {
                case 0: letraDNI = 'T'; break;
                case 1: letraDNI = 'R'; break;
                case 2: letraDNI = 'W'; break;
                case 3: letraDNI = 'A'; break;
                case 4: letraDNI = 'G'; break;
                case 5: letraDNI = 'M'; break;
                case 6: letraDNI = 'Y'; break;
                case 7: letraDNI = 'F'; break;
                case 8: letraDNI = 'P'; break;
                case 9: letraDNI = 'D'; break;
                case 10: letraDNI = 'X'; break;
                case 11: letraDNI = 'B'; break;
                case 12: letraDNI = 'N'; break;
                case 13: letraDNI = 'J'; break;
                case 14: letraDNI = 'Z'; break;
                case 15: letraDNI = 'S'; break;
                case 16: letraDNI = 'Q'; break;
                case 17: letraDNI = 'V'; break;
                case 18: letraDNI = 'H'; break;
                case 19: letraDNI = 'L'; break;
                case 20: letraDNI = 'C'; break;
                case 21: letraDNI = 'K'; break;
                case 22: letraDNI = 'E'; break;
                default:
                    lblResultado.Text = "Error al calcular la letra del DNI";
                    return '\0'; // Carácter nulo en caso de error
            }

            return letraDNI;
        }
    }
}
