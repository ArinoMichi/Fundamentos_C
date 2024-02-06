using ProyectoClases;

namespace Fundamentos
{
    public partial class Form20TestingClases : Form
    {
        public Form20TestingClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Andres";
            persona.Apellidos = "Leon";
            persona.Edad = 12;
            persona.Nacionalidad = Paises.Andorra;
            persona.Genero = TipoGenero.Femenino;
            persona.MetodoParametrosOpcionales(1);
            persona.MetodoParametrosOpcionales(1, 2);
            //SOLO QUIERO ENVIAR EL PARAMETRO 1 y 3
            persona.MetodoParametrosOpcionales(1, numero3: 88);



            this.lstDatosClases.Items.Add(persona.GetNombreCompleto(true));
            this.lstDatosClases.Items.Add("Edad: " + persona.Edad);
            this.lstDatosClases.Items.Add("Genero: " + persona.Genero);
            this.lstDatosClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);

            persona.Domicilio = new Direccion("Tajamar", "Madrid");
            this.lstDatosClases.Items.Add("Calle: " + persona.Domicilio.Calle);
            persona.DomicilioVacaciones = new Direccion("Calle Juerga", "Marbella", 2837);
            this.lstDatosClases.Items.Add("Ciudad de vacaciones: " + persona.DomicilioVacaciones.Calle);

            persona[0] = "ojos azules";
            persona[1] = "Estilosa";

            this.lstDatosClases.Items.Add("Descripcion[0]: " + persona[0]);
            this.lstDatosClases.Items.Add("Descripcion[1]: " + persona[1]);


        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Empleado";
            emp.Apellidos = "Empleado";
            this.lstDatosClases.Items.Add(emp.ToString());
            this.lstDatosClases.Items.Add("Salario Minimo empleado: " + emp.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones Empleado: " + emp.GetDiasVacaciones());  

        }

        private void btnCrearDirector_Click(object sender, EventArgs e)
        {
            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstDatosClases.Items.Add(dire.ToString());
            this.lstDatosClases.Items.Add("Salario Minimo Director: "+ dire.Apellidos+ " " + dire.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones Director: " + dire.GetDiasVacaciones());
        }
    }
}
