using BE;
using BE.Pago;
using BLL.Persona;
using Interfaces;
using MPP.Pago;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Pago
{
    public class BLLPago : IABM<BEPago>
    {
        private MPPPago _mppPago;
        public BLLPago() 
        {
            _mppPago = new MPPPago();
        }

        public void Alta(BEPago beObject)
        {
            _mppPago.Alta(beObject);
        }

        public void Baja(BEPago beObject)
        {
            _mppPago.Baja(beObject);
        }

        public List<BEPago> ListarTodo()
        {
            List<BEPago> lista = _mppPago.ListarTodo();

            foreach (BEPago pago in lista)
            {
                pago.Persona = ObtenerPersonaPorDNI(pago.PersonaDoc);
            }

            return lista;
        }

        private BEPersona ObtenerPersonaPorDNI(string personaDoc)
        {
            BLLInternacional bLLInternacional = new BLLInternacional();
            return bLLInternacional.ObtenerPersonaPorDNI(personaDoc);
        }

        public void Modificar(BEPago beObject)
        {
            throw new NotImplementedException();
        }

        public List<BEPago> ListarPagosPorPersona(BEPersona personaSeleccionada)
        {
            List<BEPago> lista = _mppPago.ListarTodo();

            List<BEPago> pagos = lista.Where(p => p.PersonaDoc.Equals(personaSeleccionada.Documento)).ToList();

            return pagos;
        }

        /*
        * Cuando una persona con identidad nacional realiza un pago si la fecha de pago es 10 días 
        * anterior a la de hoy se le realiza un descuento del 20%, 
        * mientras que si es internacional del 10%
        */
        public decimal CalcularImporte(DateTime fecha, decimal importe, BEPersona personaSeleccionada)
        {
            BLLPersona bllPersona;

            if (personaSeleccionada is BENacional)
                bllPersona = new BLLNacional();
            else
                bllPersona = new BLLInternacional();

            // Aca se genera el polimorfismo, segun que tipo de persona sea
            decimal descuento = bllPersona.CalcularDescuento(fecha);

            decimal importeFinal = importe - (importe * descuento / 100);

            return importeFinal;
        }

        public bool ValidarImporte(decimal importe)
        {
            return importe > 50000;
        }

        public object ListarDataPorPersona(BEPersona personaSeleccionada)
        {
            var listaPagos = ListarPagosPorPersona(personaSeleccionada);

            // Calcular la suma de todos los importes pagados y descontados
            decimal sumaImportesPagados = listaPagos.Sum(pago => pago.Importe);

            decimal sumaImportesDescontados = 0;

            BLLPersona bllPersona;
            
            if (personaSeleccionada is BENacional)
                bllPersona=new BLLNacional();
            else
                bllPersona = new BLLInternacional();

            sumaImportesDescontados = bllPersona.CalcularDescuentoTotal(sumaImportesPagados);


            int edad = DateTime.Now.Year - personaSeleccionada.FechaNac.Year;
            if (personaSeleccionada.FechaNac > DateTime.Now.AddYears(-edad)) edad--;

            var data = new[] {
                new {
                    Documento = personaSeleccionada.Documento,
                    ApellidoNombre = $"{personaSeleccionada.Apellido}, {personaSeleccionada.Nombre}",
                    Edad = edad,
                    SumaImportesPagados = sumaImportesPagados,
                    SumaImportesDescontados = sumaImportesDescontados
                }
            };

            return data;
        }
    }
}
