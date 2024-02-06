using System;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            // Exista @
            if (email.Contains("@"))
            {
                // No @ ni al inicio ni al final
                if (!(email.StartsWith("@") || email.EndsWith("@")))
                {
                    // No exista más de una @
                    if (email.IndexOf("@") != email.LastIndexOf("@"))
                    {
                        // Exista un punto
                        if (email.Contains("."))
                        {
                            // Exista un punto después de @
                            int indiceArroba = email.IndexOf("@");
                            int indicePunto = email.IndexOf(".", indiceArroba);

                            if (indicePunto > indiceArroba)
                            {
                                // Dominio de 2 a 4 caracteres (.es, .com, .org)
                                
                                int longitudDominio = email.Substring(email.LastIndexOf(".") + 1).Length;
                                if (longitudDominio >= 2 && longitudDominio <= 3)
                                {
                                    MessageBox.Show("La dirección de correo es válida.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error: Dominio no válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error: Falta punto después de @.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Falta punto en la dirección de correo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Más de una @ en la dirección de correo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: La dirección de correo no puede empezar o terminar con @.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Falta @ en la dirección de correo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
