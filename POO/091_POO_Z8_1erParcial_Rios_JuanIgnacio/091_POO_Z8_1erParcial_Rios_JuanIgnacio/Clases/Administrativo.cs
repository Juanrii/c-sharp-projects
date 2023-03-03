﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases
{
    /*
     * Esta clase hereda de empleado
     */
    public class Administrativo : Empleado
    {
        #region "Constantes"
        private const double VALOR_BENEFICIO = 0.05;
        #endregion

        #region "Propiedades"
        protected override double BENEFICIO { get => VALOR_BENEFICIO; }
        #endregion

        #region "Constructor"
        public Administrativo() { }
        #endregion

        #region "Destructor"
        ~Administrativo() { }
        #endregion
    }
}
