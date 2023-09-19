using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEVegano : BEProducto
    {
        public int Huevo { get; set; }

        public BEVegano(int huevo)
        {
            Huevo = huevo;
        }
        public BEVegano() { }

        public override decimal ObtenerPrecioXCantidad()
        {
            decimal precio = CantidadUni * Precio;
            decimal descuento = precio * 0.10m;
            return precio - descuento;
        }
    }
}
