using PracticaCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCore.Repositories
{
    public class RepositoryEmpresasPedidos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryEmpresasPedidos()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=NETCORE;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Cliente> GetEmpresasClientes()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_CLIENTES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            
            while (this.reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.CodigoCliente = this.reader["CodigoCliente"].ToString();
                cliente.Empresa = this.reader["Empresa"].ToString();
                cliente.Contacto = this.reader["Contacto"].ToString();
                cliente.Cargo = this.reader["Cargo"].ToString();
                cliente.Ciudad = this.reader["Ciudad"].ToString();
                cliente.Telefono = int.Parse(this.reader["Telefono"].ToString());
                clientes.Add(cliente);
            }
            this.reader.Close();
            this.cn.Close();
            return clientes;

        }

        public List<Pedido> GetPedidos(string codCliente)
        {
            string sql = "select * from PEDIDOS "
               + " WHERE CodigoCliente=@CODIGO";
            SqlParameter pamCodigoCliente = new SqlParameter("@CODIGO", codCliente);
            this.com.Parameters.Add(pamCodigoCliente);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Pedido> pedidos = new List<Pedido>();
            while (this.reader.Read())
            {
                Pedido pedido = new Pedido();
                pedido.CodigoPedido = this.reader["CodigoPedido"].ToString();
                pedido.CodigoCliente = this.reader["CodigoCliente"].ToString();
                pedido.FechaEntrega = DateTime.Parse(this.reader["FechaEntrega"].ToString());
                pedido.FormaEnvio = this.reader["FormaEnvio"].ToString();
                pedido.Importe = int.Parse(this.reader["Importe"].ToString());
                pedidos.Add(pedido);
            }
            {
                
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return pedidos;
        }

        public int InsertarPedido(string codPedido, string codCliente, DateTime fechaEntrega, string formaEnvio, int importe )
        {
            this.com.CommandType = CommandType.StoredProcedure;
            //(@CODIGOPEDIDO nvarchar(50), @CODIGOCLIENTE nvarchar(50), @FECHAENTREGA datetime, @FORMAENVIO nvarchar(50), @IMPORTE int)
            this.com.CommandText = "SP_INSERT_PEDIDO";
            this.com.Parameters.Add(new SqlParameter("@CODIGOPEDIDO", codPedido));
            this.com.Parameters.Add(new SqlParameter("@CODIGOCLIENTE", codCliente));
            this.com.Parameters.Add(new SqlParameter("@FECHAENTREGA", fechaEntrega));
            this.com.Parameters.Add(new SqlParameter("@FORMAENVIO", formaEnvio));
            this.com.Parameters.Add(new SqlParameter("@IMPORTE", importe));
            this.cn.Open();
            int filasAfectadas = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return filasAfectadas;

        }
        public int DeletePedido(string codPedido)
        {
            string sql = "DELETE from PEDIDOS WHERE CodigoPedido=@CODIGO";
            SqlParameter pamCodigoPedido = new SqlParameter("@CODIGO", codPedido);
            this.com.Parameters.Add(pamCodigoPedido);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.com.Parameters.Clear();
            this.cn.Close();
            return eliminados;
        }
    }
}
