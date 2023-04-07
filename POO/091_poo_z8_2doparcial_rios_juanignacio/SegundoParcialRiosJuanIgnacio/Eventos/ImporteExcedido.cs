using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Eventos
{
    public class ImporteExcedidoEventArgs : EventArgs
    {
        #region "Propiedades"
        public double ImporteTotalAPagar { get; }
        #endregion

        #region "Constructor"
        public ImporteExcedidoEventArgs(double importe)
        {
            ImporteTotalAPagar = importe;
        }
        #endregion
    }
}
