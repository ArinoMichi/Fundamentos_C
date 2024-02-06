using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperListaCompra
    {
        public List<Producto> listaCompra {get; set; }
        public HelperListaCompra()
        {
            this.listaCompra = new List<Producto>();
        }

        public async Task WriteListaAsync(string path)
        {
            string data = this.ConvertListaString();
            await HelperFiles.WriteFileAsync(path, data);

        }

        public async Task ReadListaAsync(string path)
        {
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertirListaCompra(data);
        }




        private string ConvertListaString()
        {
            string data = "";
            foreach (Producto producto in listaCompra)
            {
                data += producto.Nombre + "," + producto.Cantidad + "!";

            }
            data = data.TrimEnd('!');
            return data;
        }

        private void ConvertirListaCompra(string data)
        {
            this.listaCompra.Clear();

            string[] productos = data.Split('!');
            foreach (string producto in productos)
            {
                string[] propiedades = producto.Split(",");
                Producto product = new Producto();
                product.Nombre = propiedades[0];
                product.Cantidad = int.Parse(propiedades[1]);
                this.listaCompra.Add(product);
            }
        }
    }
}
