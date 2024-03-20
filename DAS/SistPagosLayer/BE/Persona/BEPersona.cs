using System;

namespace BE
{
    public abstract class BEPersona
    {
        #region Propiedades
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        #endregion

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
