using System;

namespace UI.Eventos
{
    public class PagoExcedidoEventArgs : EventArgs
    {
        public string Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public decimal ImportePagado { get; set; }
        public decimal Descuento { get; set; }

        public PagoExcedidoEventArgs(string documento, string apellido, string nombre, decimal importePagado, decimal descuento)
        {
            Documento       = documento;
            Apellido        = apellido;
            Nombre          = nombre;
            ImportePagado   = importePagado;
            Descuento       = descuento;
        }
    }    
}