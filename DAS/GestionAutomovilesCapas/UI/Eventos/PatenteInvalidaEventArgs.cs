using System;

namespace UI.Eventos
{
    public class PatenteInvalidaEventArgs : EventArgs
    {
        public string Mensaje { get; }

        public PatenteInvalidaEventArgs(string mensaje)
        {
            Mensaje = mensaje;
        }
    }
}
