using SegundoParcialRiosJuanIgnacio.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Clases
{
    public abstract class Socio
    {
        // Cada socio tendra su lista de cuotas
        protected List<Cuota> _listaCuotas = new List<Cuota>();
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        protected virtual double ADICIONAL { get; set; }
        public abstract double ObtenerAdicional(Cuota cuota);

        private const double IMPORTE_MAX = 10000;

        public event EventHandler<ImporteExcedidoEventArgs> ImporteExcedido;


        public int ObtenerCantidadCuotas()
        {
            return (from cuota in _listaCuotas select cuota).Count();
        }

        public List<Cuota> ObtenerCuotasPagadas()
        {
            return (from cuota in _listaCuotas where cuota.GetPagada() == true select cuota).ToList();
        }

        public List<Cuota> ObtenerCuotas()
        {
            return _listaCuotas;
        }

        public void AsignarCuota(Cuota cuota)
        {
            _listaCuotas.Add(cuota);
        }

        public void Pagar(double importe)
        {
            if (importe > IMPORTE_MAX)
            {
                ImporteExcedido?.Invoke(this, new ImporteExcedidoEventArgs(importe));
            }
        }

        public double Adicional()
        {
            return ADICIONAL;
        }

        public int ObtenerCuotasAdeudadas()
        {
            return (from c in _listaCuotas where c.GetPagada() == false select c).Count();
        }

        public bool ObtenerCuotaPorFecha(int mes, int anio)
        {
            return (from c in _listaCuotas where c.Mes == mes && c.Anio == anio select c).Count() > 0;
        }
    }

}
