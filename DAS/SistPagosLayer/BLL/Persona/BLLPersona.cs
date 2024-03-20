using System;

namespace BLL.Persona
{
    public abstract class BLLPersona
    {
        public abstract decimal Descuento { get; }
        public abstract decimal CalcularDescuento(DateTime fechaPago);
        public abstract decimal CalcularDescuentoTotal(decimal importeTotal);
    }
}
