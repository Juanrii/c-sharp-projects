using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Clases
{
    public class SocioEspecial : Socio
    {
        #region "Constantes"
        private const double VALOR_ADICIONAL = 100;
        #endregion

        #region "Propiedades"
        protected override double ADICIONAL { get => VALOR_ADICIONAL; }
        #endregion

        #region "Constructor"
        public SocioEspecial() { }
        #endregion

        #region "Destructor"
        ~SocioEspecial() { }
        #endregion

        public override double ObtenerAdicional(Cuota cuota)
        {
            return (DateTime.Now >= cuota.FechaVencimiento) ? (DateTime.Now - cuota.FechaVencimiento).Days * ADICIONAL : 0;
        }
    }
}
