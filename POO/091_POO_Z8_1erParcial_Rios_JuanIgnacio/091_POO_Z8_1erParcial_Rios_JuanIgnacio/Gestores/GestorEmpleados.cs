using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Gestores
{
    /*
     * Esta clase se encarga de gestionar la logica de Empleado
     * Implementa la Interfaz: InterfaceAgregarMultiples para la carga masiva
     */
    public class GestorEmpleados : InterfaceAgregarMultiples<Empleado>
    {
        public List<Empleado> ListaEmpleados = new List<Empleado>();

        // Constante para la cantidad maxida permitida de adelantos por empleado
        private const int CANT_MAX_ADELANTOS = 3;

        /*
         * Recibe los datos del nuevo empleado incluyendo la instancia del tipo seleccionado (empleado).
         */
        public void CrearEmpleado(string legajo, string nombre, string apellido, double sueldo, Empleado empleado)
        {
            // Se asignan las propiedades
            empleado.Legajo     = legajo;
            empleado.Nombre     = nombre;
            empleado.Apellido   = apellido;
            empleado.Sueldo     = sueldo;

            // Se agregar el nuevo empleado a la lista
            ListaEmpleados.Add(empleado);
        }

        public List<Empleado> ObtenerListadoEmpleados()
        {
            // Se crea una lista clone
            List<Empleado> lista = new List<Empleado>();

            foreach (Empleado e in ListaEmpleados)
                lista.Add(e);

            // Se devuelve la lista original clonada
            return lista;
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            // Se busca si el empleado existe
            Empleado emplExiste = ListaEmpleados.Find(e => e == empleado);

            // Si existe se lo elimina de la lista
            if (emplExiste != null) ListaEmpleados.Remove(emplExiste);
        }

        public void ModificarEmpleado(string nombre, string apellido, double sueldo, Empleado empleadoSeleccionado)
        {
            // Se busca el empleado seleccionado en la lista de empleados
            Empleado e = ListaEmpleados.Find(x => x == empleadoSeleccionado);

            // Si el empleado existe, se reemplazan sus propiedades
            if (e != null)
            {
                e.Nombre    = nombre;
                e.Apellido  = apellido;
                e.Sueldo    = sueldo;
            }
        }

        public void AgregarAdelanto(Empleado empelado, Adelanto adelanto)
        {
            // Se busca en la lista de empleados el empleado seleccionado
            Empleado e = ListaEmpleados.Find(x => x == empelado);

            // Si existe el empleado y la cantidad de adelantos no supera el maximo
            if (e != null && e.ObtenerCantidadAdelantos() <= CANT_MAX_ADELANTOS)
            {
                // Se le asigna el adelanto
                e.AsignarAdelanto(adelanto);
            }
        }

        public bool CantidadMaximaAdelantos(Empleado empleado)
        {
            int cant = empleado.ObtenerCantidadAdelantos();

            // Veririfica si la cantidad de adelantos es igual a la cantidad maxima
            return cant == CANT_MAX_ADELANTOS;
        }

        public void CrearMultiplesRegistros(List<Empleado> lista)
        {
            // Se recorre la lista de datos pre cargados
            foreach (Empleado e in lista)
            {
                // Si el empleado no existe en la lista original, se lo agrega
                Empleado empExistente = ListaEmpleados.Find(x => x.Legajo == e.Legajo);
                if (empExistente == null)
                {
                    ListaEmpleados.Add(e);
                }
            }
        }

        public bool LegajoExistente(string legajo)
        {
            // Se busca en la lista de empleados si existe el empleado con el legajo ingresado
            Empleado e = ListaEmpleados.Find(x => x.Legajo == legajo);

            // Si existe devuelve true, de lo contrario false
            return e is Empleado;
        }

    }
}
