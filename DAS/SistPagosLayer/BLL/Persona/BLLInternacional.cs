using BE;
using BLL.Persona;
using Interfaces;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLInternacional : BLLPersona, IABM<BEInternacional>
    {
        private MPPInternacional _mppInternacional; 

        public BLLInternacional() 
        {
            _mppInternacional = new MPPInternacional();
        }

        public override decimal Descuento { get => 10; }

        public BEPersona ObtenerPersonaPorDNI(string personaDoc)
        {
            List<BEPersona> lista = _mppInternacional.ListarTodo();

            // Usa FirstOrDefault para obtener el primer elemento que coincida o null si no hay coincidencias
            BEPersona persona = lista.FirstOrDefault(p => p.Documento.Equals(personaDoc));

            return persona;
        }

        public override decimal CalcularDescuentoTotal(decimal importeTotal)
        {
            return (importeTotal * Descuento) / 100;
        }

        public void Alta(BEInternacional beObject)
        {
            _mppInternacional.Alta(beObject);
        }

        public void Baja(BEInternacional beObject)
        {
            _mppInternacional.Baja(beObject);
        }

        public List<BEPersona> ListarTodo()
        {
            return _mppInternacional.ListarTodo();
        }

        public void Modificar(BEInternacional beObject)
        {
            _mppInternacional.Modificar(beObject);
        }

        List<BEInternacional> IABM<BEInternacional>.ListarTodo()
        {
            throw new NotImplementedException();
        }

        public List<BEPersona> FiltrarPersonasPorApellido(string patronApellido)
        {
            List<BEPersona> lista = ListarTodo();

            // Utilizo StartWith para que compare de forma incremental y
            // OrdinalIgnoreCase para que ignore mayusuculas y minusculas
            List<BEPersona> personasFiltradas = lista.Where(p => p.Apellido.StartsWith(patronApellido, StringComparison.OrdinalIgnoreCase)).ToList();
            
            return personasFiltradas;
        }

        public bool ValidarDocumento(string documento)
        {
            string patron = "^[a-zA-Z0-9]{8}$";

            if (!Regex.IsMatch(documento, patron))
                return false;

            return true;
        }

        public override decimal CalcularDescuento(DateTime fechaPago)
        {
            TimeSpan diferenciaDias = DateTime.Now - fechaPago;
            int dias = diferenciaDias.Days;

            // 10% de descuento
            return dias >= 10 ? 10 : 0;
        }

        public bool DocumentoExistente(string documento)
        {
            var lista = _mppInternacional.ListarTodo();

            return lista.Exists(p => p.Documento.ToUpper() == documento.ToUpper());
        }
    }
}
