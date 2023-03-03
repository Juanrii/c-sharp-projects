using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases
{
    public class Adelanto
    {
        #region "Propiedades"
        public string Codigo { get; set; }
        public DateTime FechaOtorgamiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public double ImporteOtorgado { get; set; }
        public double ImportePagado { get; set; }
        public double Beneficio { get; set; }
        public double SaldoAdeudado { get; set; }

        // Los adelantos solo pueden tener un empleado asignado
        private Empleado _empleado;
        #endregion

        #region "Constructor"
        public Adelanto()
        {
            _empleado = null;
        }
        #endregion

        #region "Destructor"
        ~Adelanto() { }
        #endregion

        #region "Metodos"
        public void AgregarEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        public Empleado ObtenerEmpleado()
        {
            return _empleado;
        }

        public bool TieneBeneficiario()
        {
            return ObtenerEmpleado() is Empleado;
        }
        #endregion
    }
}
