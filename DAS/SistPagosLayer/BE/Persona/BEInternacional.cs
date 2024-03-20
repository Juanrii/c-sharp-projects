using System;

namespace BE
{
    public class BEInternacional : BEPersona
    {
        #region Propiedades
        public bool Extranjero { get; set; }
        #endregion


        #region Constructores
        public BEInternacional() 
        {
        }
        public BEInternacional(bool extranjero) 
        {
            Extranjero = extranjero;
        }
        #endregion
    }
}
