using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Clases
{
    public class SocioNormal : Socio
    {
        #region "Constantes"
        private const double VALOR_ADICIONAL = 0.05;
        #endregion

        #region "Propiedades"
        protected override double ADICIONAL { get => VALOR_ADICIONAL; }

        public override double ObtenerAdicional(Cuota cuota)
        {
            return (DateTime.Now >= cuota.FechaVencimiento) ? (DateTime.Now - cuota.FechaVencimiento).Days * (cuota.Importe * ADICIONAL) : 0;
        }
            #endregion

            #region "Constructor"
            public SocioNormal() { }
        #endregion

        #region "Destructor"
        ~SocioNormal() { }
        #endregion
    }
}
