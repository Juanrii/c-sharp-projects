using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETipo : Entidad
    {
        #region Propiedades
        public string Nombre { get; set; }
        #endregion

        #region Constructores
        public BETipo(string nombre)
        {
            Nombre = nombre;
        }
        public BETipo() { }
        #endregion

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
