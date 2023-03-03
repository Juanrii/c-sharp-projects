using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases
{
    /*
     * Esta clase hereda de empleado
     */
    public class Operario : Empleado
    {
        #region "Constantes"
        private const double VALOR_BENEFICIO = 0.10;
        #endregion
        
        #region "Propiedades"
        protected override double BENEFICIO { get => VALOR_BENEFICIO; }
        #endregion

        #region "Constructor"
        public Operario() { }
        #endregion

        #region "Destructor"
        ~Operario() { }
        #endregion
    }
}
