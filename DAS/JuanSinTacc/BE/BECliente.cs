using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente : Entidad
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Constructores
        public BECliente(string nombre, string apellido, string telefono, string direccion)
        {
            Nombre      = nombre;
            Apellido    = apellido;
            Telefono    = telefono;
            Direccion   = direccion;
        }

        public BECliente() { }
        #endregion

        public override string ToString()
        {
            return $"{Nombre} - {Apellido}";
        }
    }
}
