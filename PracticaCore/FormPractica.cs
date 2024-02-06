using PracticaCore.Models;
using PracticaCore.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCore
{
    public partial class FormPractica : Form
    {
        RepositoryEmpresasPedidos repo;
        List<Cliente> clientes;
        List<Pedido> pedidos;
        public FormPractica()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpresasPedidos();
            this.clientes = new List<Cliente>();
            this.pedidos = new List<Pedido>();
            this.LoadClientes();
        }

        private void LoadClientes()
        {
            this.cmbclientes.Items.Clear();
            this.clientes = this.repo.GetEmpresasClientes();
            foreach (Cliente cli in this.clientes)
            {
                this.cmbclientes.Items.Add(cli.Empresa);
            }
        }

        private void cmbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbclientes.SelectedIndex;
            Cliente cliente = this.clientes[index];
            this.txtcargo.Text = cliente.Cargo;
            this.txtciudad.Text = cliente.Ciudad;
            this.txtempresa.Text = cliente.Empresa;
            this.txtcontacto.Text = cliente.Contacto;
            this.txttelefono.Text = cliente.Telefono.ToString();
            this.LoadPedidos(cliente.CodigoCliente);
            

        }

        private void LoadPedidos(string codCliente)
        {
            this.txtcodigopedido.Text = "";
            this.txtfechaentrega.Text = "";
            this.txtformaenvio.Text = "";
            this.txtimporte.Text = "";

            this.lstpedidos.Items.Clear();
            this.pedidos = this.repo.GetPedidos(codCliente);
            foreach (Pedido pedido in this.pedidos)
            {
                this.lstpedidos.Items.Add(pedido.CodigoPedido);
            }
        }
        private void lstpedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstpedidos.SelectedIndex;
            Pedido pedido = this.pedidos[index];

            this.txtcodigopedido.Text = pedido.CodigoPedido;
            this.txtfechaentrega.Text = pedido.FechaEntrega.ToString();
            this.txtformaenvio.Text = pedido.FormaEnvio.ToString();
            this.txtimporte.Text = pedido.Importe.ToString();
        }

        private void btnnuevopedido_Click(object sender, EventArgs e)
        {
            string codigoPedido = this.txtcodigopedido.Text;
 
            string codigoCliente = this.clientes[this.cmbclientes.SelectedIndex].CodigoCliente;
            DateTime fechaEntrega = DateTime.Parse(this.txtfechaentrega.Text);
            string formaEnvio = this.txtformaenvio.Text;
            int importe = int.Parse(this.txtimporte.Text);

            int filasAfectadas = this.repo.InsertarPedido(codigoPedido, codigoCliente,fechaEntrega,formaEnvio,importe);
            MessageBox.Show("Filas afectadas: " + filasAfectadas);
            this.LoadPedidos(codigoCliente);
        }

        private void btneliminarpedido_Click(object sender, EventArgs e)
        {
            string codigoCliente = this.clientes[this.cmbclientes.SelectedIndex].CodigoCliente;
            int index = this.lstpedidos.SelectedIndex;
            string codigoPedido = this.pedidos[index].CodigoPedido;
            int filasAfectadas = this.repo.DeletePedido(codigoPedido);
            MessageBox.Show("Filas eliminadas: " + filasAfectadas);
            this.LoadPedidos(codigoCliente);
        }

        
    }
}
