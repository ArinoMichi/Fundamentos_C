using System.Data;

namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //PROPIEDAD CON LLAVE INGLESA
            string texto;
            DataTable fichero;
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIREMOS AQUI
            this.txtNombre.Location = new Point(78, 10);
            
            //TENEMOS PROPIEDADES DE TIPOS DE DATOS PRIMITIVOS
            //LOS PRIMITIVOS, DIRECTAMEBTE SE ESCRIBEN
            this.txtNombre.Text = "Hola Mundo";
            //ESTO ES UNA EXCEPCION EN LA NORMA
            //TENER UNA CLASE ESTRUCTURADA O FINAL,
            //NO SE INSTANCIA, SE UTILIZA.
            //POR EJEMPLO LA CLASE COLOR
            this.BackColor = Color.White;
            //PONGAMOS QUE DESEAMOS ALINEAR EL TEXTO DE UNA CAJA
            //1. LEFT, 2. RIGHT,
            this.txtNombre.TextAlign = HorizontalAlignment.Center;


            int mayor = 888;
            short pequenio = (short)mayor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}