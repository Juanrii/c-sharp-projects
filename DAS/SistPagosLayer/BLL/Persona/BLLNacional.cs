using BE;
using Interfaces;
using MPP.Persona;
using System;
using System.Collections.Generic;

namespace BLL.Persona
{
    public class BLLNacional : BLLPersona, IABM<BENacional>
    {
        private MPPNacional _mppNacional;

        public BLLNacional() 
        {
            _mppNacional = new MPPNacional();
        }

        public override decimal Descuento { get => 20;}

        public void Alta(BENacional beObject)
        {
            _mppNacional.Alta(beObject);
        }

        public void Baja(BENacional beObject)
        {
            _mppNacional.Baja(beObject);
        }

        public override decimal CalcularDescuento(DateTime fechaPago)
        {
            TimeSpan diferenciaDias = DateTime.Now - fechaPago;
            int dias = diferenciaDias.Days;

            // 20% de descuento
            return dias >= 10 ? 20 : 0;
        }

        public override decimal CalcularDescuentoTotal(decimal importeTotal)
        {
            return (importeTotal * Descuento) / 100;
        }

        public List<BEPersona> ListarTodo()
        {
            return _mppNacional.ListarTodo();
        }

        public void Modificar(BENacional beObject)
        {
            _mppNacional.Modificar(beObject);
        }

        List<BENacional> IABM<BENacional>.ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
