using SegundoParcialRiosJuanIgnacio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialRiosJuanIgnacio.Gestores
{
    public class GestorCuotas : ICloneable
    {
        public List<Cuota> ListaCuotas = new List<Cuota>();

        private const string ORDEN_ASC  = "ASC";
        private const string ORDEN_DESC = "DESC";

        public bool CodigoExistente(string codigo)
        {
            Cuota c = ListaCuotas.Find(x => x.Codigo == codigo);
            return c is Cuota;
        }

        public Cuota Asginar(string codigo, int mes, int anio, double importe, Socio socioSeleccionado)
        {
            Cuota nuevaCuota = new Cuota()
            {
                Codigo              = codigo,
                Mes                 = mes,
                Anio                = anio,
                Importe             = importe,
                FechaVencimiento    = new DateTime(anio, mes, 1).AddMonths(1),
            };

            nuevaCuota.SetSocio(socioSeleccionado);

            ListaCuotas.Add(nuevaCuota);

            return nuevaCuota;
        }

        public object Clone()
        {
            List<Cuota> cloneCuotas = new List<Cuota>();

            cloneCuotas.AddRange(ListaCuotas);

            return cloneCuotas;
        }

        public object ObtenerCuotasAsignadas(Socio socio)
        {
            return (from c in ListaCuotas where c.GetSocio().Legajo == socio.Legajo select c).ToList();
        }

        public List<Cuota> ObtenerCuotasPagadas(Socio socio)
        {
            var pagadas = (from c in ListaCuotas where c.GetSocio().Legajo == socio.Legajo && c.GetPagada() == true select c).ToList();
            return pagadas; 
        }

        public void Pagada(Cuota cuota)
        {
            foreach (var c in from c in ListaCuotas where c.Codigo == cuota.Codigo select c)
            {
                c.SetPagada(true);
            }
        }

        public Object ObtenerCuotasPagadasOrdenadas(Socio socioSeleccionado)
        {
            List<Cuota> lista = ObtenerCuotasPagadas(socioSeleccionado);
            return lista;
        }

        internal List<Cuota> ObtenerCuotasPendientes(Socio socio)
        {
            var pendientes = (from c in ListaCuotas where c.GetSocio().Legajo == socio.Legajo && c.GetPagada() == false select c).ToList();
            return pendientes;
        }
    }
}
