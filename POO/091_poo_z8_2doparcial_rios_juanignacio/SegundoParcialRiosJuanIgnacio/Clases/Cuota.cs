using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Clases
{
    public class Cuota
    {
        public string Codigo { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Importe { get; set; }

        private bool _pagada = false;

        private Socio _socio;

        public Cuota() { }

        ~Cuota() { }


        public void SetSocio(Socio socio)
        {
            _socio = socio;
        }

        public Socio GetSocio()
        {
            return _socio;
        }

        public double ObtenerImporte()
        {
            return Importe;
        }

        public double ObtenerRecargo()
        {
            return GetSocio().Adicional();
        }

        public double ObtenerImporteTotal()
        {
            return ObtenerImporte() + ObtenerRecargo();
        }

        public bool GetPagada()
        {
            return _pagada;
        }

        public void SetPagada(bool pagada) 
        { 
            _pagada = pagada; 
        }

        
    }
}
