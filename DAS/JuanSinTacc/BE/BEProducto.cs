using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEProducto : Entidad
    {
        #region Propiedades
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        private int _cantidad;
        public int DetalleCantidad;

        public enum Cantidad
        {
            Unidad,
            Gramos,
            Kilogramos
        }
        public Cantidad cantidad { get; set; }

        #endregion

        public void SetCantidad(int cantidad)
        {
            _cantidad = cantidad;
        }

        public int ObtenerCantidad()
        {
            return _cantidad;
        }

        public decimal ObtenerPrecioXCantidad()
        {
            return _cantidad * Precio;
        }
    }
}
