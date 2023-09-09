using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEUsuario : Entidad
    {
        #region Propiedades
        public string Usuario { get; set; }
        public string Contra { get; set; }
        #endregion

        #region Constructor
        public BEUsuario() { }
        #endregion
    }
}
