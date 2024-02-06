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

    public partial class Form17SumarBotones : Form
    {
        //LAS COLECCIONES SE SUELEN DECLARAR A NIVEL DE CLASE
        //POR SI NECESITAMOS UTILIZARLAS EN MULTIPLES METODOS
        int suma;
        List<Button> botones;

        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            Random random = new Random();

            foreach (Button boton in this.panel1.Controls)
            {
                botones.Add((Button)boton);
                boton.Text = random.Next(1, 100).ToString();
                boton.Click += SumarBoton;
            }
        }

        private void SumarBoton(object? sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            suma += numero;
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();
        }
    }
}
