using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Gestores
{
    /*
     * Esta clase se encarga de gestionar la logica de EmpleadoAdelantoVista
     */
    public class GestorEmpleadoAdelantoVista
    {
        private List<EmpleadoAdelantoVista> _listaEmpleadosAdelantos = new List<EmpleadoAdelantoVista>();

        public List<EmpleadoAdelantoVista> ObtenerListadoEmpleadosAdelantos(Empleado empleado = null)
        {
            // Se crea una lista clone
            List<EmpleadoAdelantoVista> lista = new List<EmpleadoAdelantoVista>();

            foreach (EmpleadoAdelantoVista ea in _listaEmpleadosAdelantos)
            {
                // Si empleado esta seteado, se obtiene una lista de solo los adelantos asignados al empleado
                if (empleado != null)
                {
                    if (ea.ObtenerEmpleado() == empleado)
                    {
                        lista.Add(ea);
                    }
                }
                // De lo contrario se devuelve una lista completa
                else
                {
                    lista.Add(ea);
                }
            }

            return lista;
        }

        public EmpleadoAdelantoVista AgregarEmpleadoAdelanto(Adelanto adelanto, Empleado empleado)
        {
            // Se crea una instancia de la clase EmpleadoAdelantoVista
            EmpleadoAdelantoVista ea = new EmpleadoAdelantoVista()
            {
                Codigo            = adelanto.Codigo,
                FechaOtorgamiento = adelanto.FechaOtorgamiento,
                ImporteOtorgado   = adelanto.ImporteOtorgado,
            };

            // Se realiza el calculo del beneficio
            string beneficio = (adelanto.ImporteOtorgado * empleado.ObtenerBeneficio()).ToString("F2");
            ea.Beneficio = Convert.ToDouble(beneficio);

            // Se realiza el calculo del saldo adeudado
            string saldoAdeudado = (ea.ImporteOtorgado - ea.Beneficio).ToString("F2");
            ea.SaldoAdeudado = Convert.ToDouble(saldoAdeudado);

            // Se setea el Empleado
            ea.AgregarEmpleado(empleado);

            // Se agrega el nuevo EmpleadoAdelantoVista a la lista
            _listaEmpleadosAdelantos.Add(ea);

            // Se retorna el nuevo objeto para utilizarlo como actualizacion de las demas DataGridViews
            return ea;
        }

        public void PagarAdelanto(EmpleadoAdelantoVista empleadoAdelantoSeleccionado, double importe)
        {
            // Se filtra en la lista de empleados con adelantos asignados por el seleccionado
            EmpleadoAdelantoVista ea = _listaEmpleadosAdelantos.Find(x => x == empleadoAdelantoSeleccionado);
        

            if (ea != null)
            {
                // Si se encuentra, se actualiza el importe pagado y el saldo adeudado
                string importePagado = (ea.ImportePagado + importe).ToString("F2");
                ea.ImportePagado = Convert.ToDouble(importePagado);
                string nuevoSaldoAdeudado = (ea.SaldoAdeudado - importe).ToString("F2");
                ea.SaldoAdeudado = Convert.ToDouble(nuevoSaldoAdeudado);

                if (ea.SaldoAdeudado == 0)
                {
                    // Si el saldo adeudado es cero, significa que el pago ha sido realizado
                    // Por lo tanto de setea la fecha de devolucion
                    ea.FechaDevolucion = DateTime.Now;
                }
            }
        }

        public double ObtenerImporteTotal(Empleado empleado)
        {
            // Devuelve la suma del importe otorgado segun el empleado seleccionado
            List<EmpleadoAdelantoVista> lista = _listaEmpleadosAdelantos.FindAll(x => x.ObtenerEmpleado() == empleado);

            return (lista.Count > 0) ? lista.Sum(x => x.ImporteOtorgado) : 0;

        }

        public double ObtenerDeudaTotal(Empleado empleado)
        {
            // Devuelve la suma del saldo adeudado segun el empleado seleccionado
            List<EmpleadoAdelantoVista> lista = _listaEmpleadosAdelantos.FindAll(x => x.ObtenerEmpleado() == empleado);

            return (lista.Count > 0) ? lista.Sum(x => x.SaldoAdeudado) : 0;
        }
    }
}
