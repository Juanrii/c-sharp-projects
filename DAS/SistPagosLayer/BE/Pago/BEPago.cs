using System;

namespace BE.Pago
{
    public class BEPago
    {
        #region Propiedades
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string PersonaDoc { get; set; }
        public BEPersona Persona { get; set; }
        #endregion

        #region Constructores
        public BEPago() { }
        public BEPago(int pagoId, DateTime fecha, decimal importe, string personaDoc, BEPersona persona)
        {
            PagoId  = pagoId;
            Fecha   = fecha;
            Importe = importe;
            PersonaDoc = personaDoc;
            Persona = persona;
        }
        #endregion
    }
}
