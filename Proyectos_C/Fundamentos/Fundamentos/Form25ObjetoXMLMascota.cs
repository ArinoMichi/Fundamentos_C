using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form25ObjetoXMLMascota : Form
    {
        //NECESITAMOS EL OBJETO PARA SERIALIZAR XML
        XmlSerializer serializer;
        public Form25ObjetoXMLMascota()
        {
            InitializeComponent();
            //ESTA CLASE, AL SER INSTANCIADA NECESITA QUE LE INDIQUEMOS
            //LA CLASE QUE VA A SERIALIZAR
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            //LA LECTURA CON ESTE OBJETO UTILIZA UN reader DE LA 
            //CLASE StreamReader
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                //DENTRO DEL FICHERO, TENDREMOS UN STRING CON FORMATO XML
                //QUE REPRESENTA UNA MASCOTA
                //DEBEMOS RECUPERAR DICHO STRING Y CONVERTIRLO A OBJETO
                //ESTO LO REALIZA DE FORMA AUTOMATICA MEDIANTE UN METODO
                //LLAMADO Deserialize()
                mascota = (Mascota)serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtAnios.Text = mascota.Years.ToString();

        }

        private void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnios.Text);
            //PARA ESCRIBIR SE USA StreamWriter
            using(StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                //EL METODO Serialize() PERMITE ALMACENAR UN OBJETO CON FORMATO XML
                this.serializer.Serialize(writer, mascota);
            }
            MessageBox.Show("Mascota guardada");
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtAnios.Clear();
        }
    }
}
