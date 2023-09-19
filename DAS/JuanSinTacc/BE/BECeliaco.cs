using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECeliaco : BEProducto
    {
        public BECeliaco()
        {
        }

        public override decimal ObtenerPrecioXCantidad()
        {
            return CantidadUni * Precio;
        }
    }
}
