using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Eventos
{
    /*
     * Clase ImportePagadoInvalidoEventArgs que hereda de EventArgs 
     */
    public class ImportePagadoInvalidoEventArgs : EventArgs
    {
        #region "Propiedades"
        public double SaldoAdeudado { get; }
        public double ImportePagado { get; }
        #endregion

        #region "Constructor"
        public ImportePagadoInvalidoEventArgs(double saldoAdeudado, double importe)
        {
            SaldoAdeudado = saldoAdeudado;
            ImportePagado = importe;
        }
        #endregion
    }
}
