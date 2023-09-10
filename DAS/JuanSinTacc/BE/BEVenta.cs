using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEVenta : Entidad
    {
        public BECliente Cliente { get; set; }
        public List<BEProducto> ListaProductos { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public BEVenta() 
        {
            Fecha = DateTime.Now;
            ListaProductos = new List<BEProducto>();
        }

        public BEVenta(BECliente cliente, List<BEProducto> listaProductos, decimal monto)
        {
            Cliente = cliente;
            ListaProductos = listaProductos;
            Monto = monto;
            Fecha = DateTime.Now;
            ListaProductos = new List<BEProducto>();
        }
    }
}
