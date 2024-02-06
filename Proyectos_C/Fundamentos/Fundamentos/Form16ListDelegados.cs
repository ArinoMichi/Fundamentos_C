using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form16ListDelegados : Form
    {
        private int contador = 0;
        public Form16ListDelegados()
        {
            InitializeComponent();
            //QUERESMOS INCLUIR TODOS LOS BOTONES DENTRO DE UNA COLECCION
            //POSTERIORMENTE, RECORRER DICHA COLECCION Y DELEGAR SU
            //EVENTO CLICK

            //DENTRO DE FORMS TENEMOS UNA PROPIEDAD LLAMADA
            //CONTROLS QUE CONTIENE TODOS LOS CONTROLES DEL FORMULARIO
            //DICHA PROPIEDAD FUNCIONA POR CONTAINERS, ES DECIR,
            //SI TENEMOS UN GROUPBOX, DEBEMOS RECORRER Controls DEL 
            //CONTENEDOR GROUPBOX

            //PODRIAMOS REALIZAR ESTO CON LA PROPIEDAD Controls,
            //PERO POR NORMA SIEMPRE CREAREMOS NUESTRAS PROPIAS COLECCIONES
             List<Button> botones = new List<Button>();
            //VAMOS A RECORRER TODOS LOS CONTROLES DEL FORM
            foreach (Control control in this.Controls)
            {
                //DEBEMOS PREGUNTAR SI VIENEN BOTONES
                if (control is Button)
                {
                    //ALMACENAMOS NUESTROS BOTONES
                    botones.Add((Button)control);
                }
                
            }
            //A CONTINUACION YA TRABAJAMOS CON NUESTRA COLECCION,
            //RECORREMOS TODOS LOS BOTONES Y LOS ASOCIAMOS AL EVENTO
            foreach (Button boton in botones)
            {
                boton.Click += BotonPulsado;
            }

        }

        private void BotonPulsado(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = "Contador: " + this.contador;
            //CUANDO PULSEMOS CUALQUIER BOTON QUIERO CAMBIAR SU COLOR
            //sender ES EL OBJETO QUE HA REALIZADO LA LLAMADA
            Button boton = (Button)sender;
            boton.BackColor = Color.Coral;
        }
    }
}
