using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_ListasEjercicio1
{
    class ListaPacientes
    {
        public Nodo nodoInicial = null;

        public void AgregarAlPrinicipio(string codigo, string nombre, string apellido, string direc, string tel)
        {
            Nodo nuevoNodo = new Nodo();

            nuevoNodo.codigo        = codigo;
            nuevoNodo.nombre        = nombre;
            nuevoNodo.apellido      = apellido;
            nuevoNodo.direccion     = direc;
            nuevoNodo.telefono      = tel;

            // Si la lista esta vacia, se setea como nodo inicial
            if (nodoInicial == null)
            {
                nodoInicial = nuevoNodo;
            } 
            else
            {
                // Sino el nuevo nodo pasa a ser el inicial
                Nodo aux = nodoInicial;
                nodoInicial = nuevoNodo;
                nodoInicial.siguiente = aux;
            }

        }

        // Elimina un paciente seleccionado
        internal void EliminarPaciente(Nodo nodoSeleccionado)
        {
            // Verificar que la lista no este vacia
            if (nodoInicial != null)
            {
                // Verificar si el codigo del paciente seleccionado coincide con el primero
                if (nodoInicial.codigo == nodoSeleccionado.codigo)
                {
                    EliminarPrimero();
                }
                else
                {
                    Nodo ultimo = BuscarUltimo(nodoInicial);
                    // Verificar si el codigo del paciente seleccionado coincide con el ultimo
                    if (ultimo != null && ultimo.codigo == nodoSeleccionado.codigo)
                    {
                        EliminarUltimo();
                    }
                    else
                    {
                        // Si no es primero ni el ulitmo, se busca al paciente anterior
                        Nodo pacienteAnterior = BuscarAnterior(nodoInicial, nodoSeleccionado);

                        // Si encontro al anterior, se elimina la referencia hacia el seleccionado
                        if (pacienteAnterior != null)
                        {
                            pacienteAnterior.siguiente = pacienteAnterior.siguiente.siguiente;
                        }
                    }
                }
            }
        }

        private Nodo BuscarAnterior(Nodo nodoInicial, Nodo nodoSeleccionado)
        {

            if (nodoInicial.siguiente != null && nodoInicial.siguiente.codigo == nodoSeleccionado.codigo)
                return nodoInicial;
            if (nodoInicial.siguiente != null)
                return BuscarAnterior(nodoInicial.siguiente, nodoSeleccionado);
            return null;
        }

        // Elimina el ultimo paciente ingresado
        private void EliminarUltimo()
        {
            Nodo anteUltimo = BuscarAnteultimo(nodoInicial);

            if (anteUltimo != null)
                anteUltimo.siguiente = null;
            else
                nodoInicial = null;
        }

        private Nodo BuscarAnteultimo(Nodo nodoInicial)
        {
            if (nodoInicial == null) return null;

            if (nodoInicial.siguiente == null) return null;

            if (nodoInicial.siguiente.siguiente != null)
                return BuscarAnteultimo(nodoInicial.siguiente);
            else
                return nodoInicial;
        }

        private Nodo BuscarUltimo(Nodo nodoInicial)
        {
            if (nodoInicial == null) return null;

            if (nodoInicial.siguiente != null)
            {
                return BuscarUltimo(nodoInicial.siguiente);
            }
            else
            {
                return nodoInicial;
            }
        }

        private void EliminarPrimero()
        {
            if (nodoInicial != null)
                // Se elimina la refencia del primero
                nodoInicial = nodoInicial.siguiente;
        }

        internal void AgregarDespues(Nodo nodoSeleccionado, string[] datosPaciente)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.codigo = datosPaciente[0];
            nuevoNodo.nombre = datosPaciente[1];
            nuevoNodo.apellido = datosPaciente[2];
            nuevoNodo.direccion = datosPaciente[3];
            nuevoNodo.telefono = datosPaciente[4];

            Nodo aux = nodoSeleccionado.siguiente;
            nodoSeleccionado.siguiente = nuevoNodo;
            nuevoNodo.siguiente = aux;
        }
    }
}
