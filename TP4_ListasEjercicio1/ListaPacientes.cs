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
            nuevoNodo.codigo = codigo;
            nuevoNodo.nombre = nombre;
            nuevoNodo.apellido = apellido;
            nuevoNodo.direccion = direc;
            nuevoNodo.telefono = tel;

            if (nodoInicial == null)
            {
                nodoInicial = nuevoNodo;
            } 
            else
            {
                Nodo aux = nodoInicial;
                nodoInicial = nuevoNodo;
                nodoInicial.siguiente = aux;
            }

        }

        internal void EliminarPaciente(Nodo nodoSeleccionado)
        {
            if (nodoInicial != null)
            {
                if (nodoInicial.codigo == nodoSeleccionado.codigo)
                {
                    EliminarPrimero();
                }
                else
                {
                    Nodo ultimo = BuscarUltimo(nodoInicial);
                    if (ultimo != null && ultimo.codigo == nodoSeleccionado.codigo)
                    {
                        EliminarUltimo();
                    }
                    else
                    {
                        Nodo pacienteAnterior = BuscarAnterior(nodoInicial, nodoSeleccionado);
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
                nodoInicial = nodoInicial.siguiente;
        }
    }
}
