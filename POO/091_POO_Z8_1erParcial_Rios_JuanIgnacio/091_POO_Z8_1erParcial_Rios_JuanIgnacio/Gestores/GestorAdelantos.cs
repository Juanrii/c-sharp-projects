using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Gestores
{
    /*
     * Esta clase se encarga de gestionar la logica de Adelantos
     * Implementa la Interfaz: InterfaceAgregarMultiples para la carga masiva
     */
    public class GestorAdelantos : InterfaceAgregarMultiples<Adelanto>
    {
        private List<Adelanto> _listaAdelantos = new List<Adelanto>();

        public void CrearAdelanto(string codigo, double importeOtorgado)
        {
            // Se crea una instancia de la clase Adelanto
            Adelanto nuevoAdelanto = new Adelanto()
            {
                // Se asignan los valores de las propiedades
                Codigo              = codigo,
                ImporteOtorgado     = importeOtorgado
            };

            // Se agrega el nuevo adelanto a la lista de adelantos
            _listaAdelantos.Add(nuevoAdelanto);
        }

        public List<Adelanto> ObtenerListadoAdelantos()
        {
            // Se crea un clone de la lista original
            List<Adelanto> lista = new List<Adelanto>();

            // Se recorre la lista y se añade cada adelanto
            foreach (Adelanto a in _listaAdelantos)
            {
                lista.Add(a);
            }
            // Retorno del clone de lista
            return lista;
        }

        public void EliminarAdelanto(Adelanto adelanto)
        {
            // Se busca si el adelanto en la lista de adelantos
            Adelanto adExiste = _listaAdelantos.Find(a => a == adelanto);

            // Si el adelanto existe, se lo elimina de la lista
            if (adExiste != null) _listaAdelantos.Remove(adExiste);
        }

        public void ModificarAdelanto(double importeOtorgado, Adelanto adelantoSeleccionado)
        {
            // Se busca el adelanto seleccionado en la lista
            Adelanto a = _listaAdelantos.Find(x => x == adelantoSeleccionado);

            // Si existe el adelanto
            if (a != null)
            {
                // Se actualizan el importe otorgado
                a.ImporteOtorgado = importeOtorgado;
            }
        }

        public void AgregarEmpleado(Adelanto adelanto, Empleado empleado)
        {
            try
            {
                // Se busca el adelanto en la lista
                Adelanto a = _listaAdelantos.Find(x => x == adelanto);

                if (a != null)
                {
                    // Si existe el adelanto, se verifica que no tenga un empleado asignado
                    if (a.ObtenerEmpleado() != null) throw new Exception($"El adelanto ya tiene asignado un empleado: {empleado.Nombre} {empleado.Apellido}");

                    // En caso de que no tenga un empleado, se le asigna el seleccionado
                    a.AgregarEmpleado(empleado);

                    // Se asigna la fecha de otorgamiento
                    a.FechaOtorgamiento = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public bool EmpleadoExistente(Adelanto adelanto)
        {
            // Se busca en la lista de adelantos el adelanto seleccionado
            Adelanto a = _listaAdelantos.Find(x => x == adelanto);

            // Si existe el adelanto
            if (a != null)
            {
                // Devuelve verdadero si posee un empleado, de lo contrario devuelve false
                return a.ObtenerEmpleado() is Empleado;
            }

            return false;
        }

        public bool CodigoExistente(string codigo)
        {
            // Se busca en la lista de adelantos si existe un adelanto con el codigo ingresado
            Adelanto a = _listaAdelantos.Find(x => x.Codigo == codigo);

            // Si existe devuelve true, sino false
            return a is Adelanto;
        }

        internal void ActualizarDatosAdelantos(double beneficio, double saldoAdeudado, Adelanto adelanto)
        {
            // Se busca el adelanto en la lista de adelantos
            Adelanto a = _listaAdelantos.Find(x => x == adelanto);

            if (a != null)
            {
                // Se le actualizan los valores
                a.Beneficio     = beneficio;
                a.SaldoAdeudado = saldoAdeudado;
            }
        }

        public void CrearMultiplesRegistros(List<Adelanto> lista)
        {
            // Recorro la lista de adelantos pre cargados
            foreach (Adelanto a in lista)
            {
                // Si el adelanto no existe, lo agrego a la lista original
                Adelanto adExistente = _listaAdelantos.Find(x => x.Codigo == a.Codigo);
                if (adExistente == null)
                {
                    _listaAdelantos.Add(a);
                }
            }
        }

        public void ActualizarImporteAdelantos(string codigo, double importe)
        {
            // Se busca el adelanto por el codigo
            Adelanto adExistente = _listaAdelantos.Find(x => x.Codigo == codigo);

            // Si el adelanto existe
            if (adExistente != null)
            {
                // Se actualiza el importe pagado y el saldo adeudado
                string importePagado = (adExistente.ImportePagado + importe).ToString("F2");
                adExistente.ImportePagado = Convert.ToDouble(importePagado);

                string nuevoSaldoAdeudado = (adExistente.SaldoAdeudado - importe).ToString("F2");
                adExistente.SaldoAdeudado = Convert.ToDouble(nuevoSaldoAdeudado);

                // Si el saldo adeudado es cero, significa que el adelanto esta pago
                // Debido a eso se asigna la fecha de devolucion
                if (adExistente.SaldoAdeudado == 0)
                {
                    adExistente.FechaDevolucion = DateTime.Now;
                }
            }
        }

        public bool SuperaSumatoriaAdelantos(Empleado empleado, Adelanto adelanto)
        {
            // Se obtiene una lista de adelantos filtrada por el empleado seleccionado
            List<Adelanto> adelantosDelEmpleado = _listaAdelantos.FindAll(x => x.ObtenerEmpleado() == empleado);

            // Se acumula el importe otorgado + el nuevo importe ingresado por el usuario
            double accImporte = adelantosDelEmpleado.Sum(a => a.ImporteOtorgado) + adelanto.ImporteOtorgado;

            // Si el importe acumulado es mayor al sueldo retorna true, sino false
            return accImporte > empleado.Sueldo;
            
        }

        public bool SuperaMitadDelSueldo(Empleado empleadoSeleccionado, Adelanto adelantoSeleccionado)
        {
            // Se obtiene la mitad del sueldo
            double mitadSueldo = empleadoSeleccionado.Sueldo / 2;

            return adelantoSeleccionado.ImporteOtorgado > mitadSueldo;
        }

    }
}
