using ProyectoClases.Helpers;
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
    public partial class Form22Files : Form
    {
        HelperFiles helper;
        public Form22Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
        }
        //PARA PODER USAR AWAIT EN LA LECTURA EL METODO TIENE QUE TENER async
        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            //OBJETO PARA SELECCIONAR EL FICHERO
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //RECUPERAMOS LA RUTA DEL FICHERO
                string path = ofd.FileName;
                //LA CLASE FileInfo NOS DEVUELVE UN FILE CON
                //SUS CARACTERISTICAS
                string data = await HelperFiles.ReadFileAsync(path);
                this.txtContenidoFile.Text = data;
                this.DibujarNombresListBox(data);

                //FileInfo file = new FileInfo(path);
                ////CON LA CLASE TextReader VAMOS A LEER EL FICHERO (Abrirlo)
                ////CON EL CODIGO using NOS ASEGURAMOS QUE HA CREADO EL OBJETO
                ////ANTES DE UTILIZARLO
                //using (TextReader reader = file.OpenText())
                //{
                //    //LEEMOS EL CONTENIDO DEL FILE
                //    //PARA PODER LLAMAR A METODOS ASINCRONOS, NECESITAMOS LA PALABRA await
                //    string contenido = await reader.ReadToEndAsync();
                //    //UNA VEZ QUE HEMOS FINALIZADO, SIEMPRE CERRAMOS LOS LECTORES
                //    reader.Close();
                //    this.txtContenidoFile.Text = contenido;
                //    this.DibujarNombresListBox(contenido);
                //}
            }
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                string path = svf.FileName;
                string data = this.GetNombresListBox();
                await HelperFiles.WriteFileAsync(path, data);
                MessageBox.Show("Datos almacenados");


                //EN LUGAR DE READER, NECESITAMOS UN TEXTWRITER
                //FileInfo file = new FileInfo(path);
                //using (TextWriter writer = file.CreateText())
                //{
                //    //RECUPERAMOS LOS NOMBRES DEL LISTBOX
                //    string contenido = this.GetNombresListBox();
                //    //ESCRIBIMOS EL CONTENIDO DE FORMA ASINCRONA
                //    await writer.WriteAsync(contenido);
                //    //SIEMPRE QUE TRABAJEMOS CON FILES, DEBEMOS INDICAR
                //    //FLUSH DESPUES DE ESCRIBIR
                //    await writer.FlushAsync();
                //    writer.Close();
                //    MessageBox.Show("Datos Almacenados");
                //}
            }
        }


        //CUANDO LEEMOS EL FICHERO, PINTAMOS LOS NOMBRES EN EL LISTBOX
        public void DibujarNombresListBox(string data)
        {
            //LUCIA,ADRIAN,MARIA
            string[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.TrimEnd(',');
            return data;
        }
    }
}
