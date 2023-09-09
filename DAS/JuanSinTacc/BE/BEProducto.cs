using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProducto : Entidad
    {
        #region Propiedades
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public BETipo Tipo { get; set; }
        #endregion

        #region Constructores
        public BEProducto(string nombre, decimal precio, BETipo tipo)
        {
            Nombre = nombre;
            Precio = precio;
            Tipo = tipo;
        }
        public BEProducto() { }
        #endregion

        
    }
}
