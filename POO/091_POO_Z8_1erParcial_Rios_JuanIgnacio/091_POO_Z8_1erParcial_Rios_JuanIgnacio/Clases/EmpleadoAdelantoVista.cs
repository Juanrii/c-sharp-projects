using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases
{
    /*
     * Esta es una clase vista
     */
    public class EmpleadoAdelantoVista
    {
        #region "Propiedades"
        public string Codigo { get; set; }
        public DateTime FechaOtorgamiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public double ImporteOtorgado { get; set; }
        public double ImportePagado { get; set; }
        public double Beneficio { get; set; }
        public double SaldoAdeudado { get; set; }

        private Empleado _empleado;
        #endregion

        #region "Eventos"
        public event EventHandler<ImportePagadoInvalidoEventArgs> ImportePagadoInvalido;
        #endregion

        #region "Constructor"
        public EmpleadoAdelantoVista() { }
        #endregion
        
        #region "Destructor"
        ~EmpleadoAdelantoVista() { }
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

        public void Pagar(double importe)
        {
            // Se suma el importe pagado con el importe ingresado y se guarda en nuevoImportePagado
            double nuevoImportePagado = ImportePagado + importe;

            // Si el nuevoImportePagado no es exactamente el saldo adeudado
            if (nuevoImportePagado != SaldoAdeudado)
            {
                // Se invoca el evento ImportePagadoInvalidoEventArgs que recibe
                // como argumento el saldo adeudado y el importe ingresado
                ImportePagadoInvalido?.Invoke(this, new ImportePagadoInvalidoEventArgs(SaldoAdeudado, importe));
            }
        }
        #endregion
    }
}
