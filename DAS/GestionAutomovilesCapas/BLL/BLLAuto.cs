using BE;
using Interfaces;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class BLLAuto : IABM<BEAuto>
    {
        private MPPAuto _mppAuto;

        public BLLAuto()
        {
            _mppAuto = new MPPAuto();
        }

        public void Alta(BEAuto beObject)
        {
            _mppAuto.Alta(beObject);
        }

        public void Baja(BEAuto beObject)
        {
            _mppAuto.Baja(beObject);
        }

        public void Modificar(BEAuto beObject)
        {
            _mppAuto.Modificar(beObject);
        }

        public List<BEAuto> ListarTodo()
        {
            List<BEAuto> lista = _mppAuto.ListarTodo();

            foreach (BEAuto auto in lista)
            {
                auto.ValorResidual = CalcularValorResidual(auto.AuAnio, auto.AuValor);
            }
        
            return lista;
        }

        // Regla de negocio
        private decimal CalcularValorResidual(int auAnio, decimal auValor)
        {
            int anioActual = DateTime.Now.Year;

            int aniosTranscurridos = anioActual - auAnio;

            // Obtener la depreciacion en porcentaje
            decimal depreciacion = Convert.ToDecimal(aniosTranscurridos * 0.10);

            decimal valorResidual = auValor * (1 - depreciacion);

            return valorResidual < 0 ? 0 : valorResidual;
        }

        // Regla de Negocio
        public DateTime ObtenerFechaBajaEnUso()
        {
            // Si el auto aún está en posesión de la empresa en fecha de baja colocarle 01/01/2999.
            return Convert.ToDateTime("01/01/2999").Date;
        }

        /*
         *  Los autos dados de baja ordenados de manera ascendente por la cantidad de días que estuvo
         *  en la empresa. (La cantidad de días que el auto estuvo en la organización. Surge de la 
         *  diferencia en días entre la fecha de baja y la de ingreso). 
         */
        public List<BEAuto> ListarAutosDeBaja(string orden = "ASC")
        {
            List<BEAuto> listaDeBaja = new List<BEAuto>();

            foreach (BEAuto auto in ListarTodo())
            {
                if (EstaDeBaja(auto))
                    listaDeBaja.Add(auto);
            }

            if (orden.ToUpper() == "ASC")
               return listaDeBaja.OrderBy(auto => (auto.AuFechaBaja - auto.AuFechaIngreso).TotalDays).ToList();

            return listaDeBaja.OrderByDescending(auto => (auto.AuFechaBaja - auto.AuFechaIngreso).TotalDays).ToList();
        }

        private bool EstaDeBaja(BEAuto auto)
        {
            return auto.AuFechaBaja != ObtenerFechaBajaEnUso();
        }

        public object FiltrarPorPatente(string patronPatente)
        {
            List<BEAuto> lista = ListarTodo();

            // Filtra las patentes que comienzen con el patron
            List<BEAuto> autosFiltrados = lista.Where(auto => auto.AuPatente.StartsWith(patronPatente)).ToList();

            return autosFiltrados;
        }

        public bool PatenteExistente(string patente)
        {
            List<BEAuto> lista = _mppAuto.ListarTodo();

            return lista.Exists(x => x.AuPatente.ToUpper() == patente);
        }
    }
}
