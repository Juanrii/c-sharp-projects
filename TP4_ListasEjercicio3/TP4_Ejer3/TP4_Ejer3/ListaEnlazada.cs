using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Ejer3
{
    public class ListaEnlazada
    {
        public NodoCliente nodoInicial = null;

        internal void AgregarAlFinal(NodoCliente nuevoCliente)
        {
            NodoCliente ultimoCliente = BuscarUltimo(nodoInicial);
            if (nodoInicial == null)
            {
                nodoInicial = nuevoCliente;
            } 
            else if (ultimoCliente != null)
            {
                ultimoCliente.siguiente = nuevoCliente;
            }
        }

        private NodoCliente BuscarUltimo(NodoCliente nodo)
        {
            if (nodoInicial == null) return null;

            if (nodo.siguiente != null)
                return BuscarUltimo(nodo.siguiente);
            else
                return nodo;
        }

        internal void EliminarSeleccionado(NodoCliente clienteSeleccionado)
        {
            if (nodoInicial == clienteSeleccionado)
                EliminarPrimero();
            else
            {
                NodoCliente ultimoCliente = BuscarUltimo(nodoInicial);
                if (ultimoCliente == clienteSeleccionado)
                    EliminarUltimo(clienteSeleccionado);
                else
                    EliminarCliente(nodoInicial, clienteSeleccionado);
            }
        }

        private void EliminarCliente(NodoCliente nodoInicial, NodoCliente clienteSeleccionado)
        {
            if (nodoInicial.siguiente == clienteSeleccionado)
                nodoInicial.siguiente = nodoInicial.siguiente.siguiente;
            else
                EliminarCliente(nodoInicial.siguiente, clienteSeleccionado);
        }

        private void EliminarUltimo(NodoCliente clienteSeleccionado)
        {
            NodoCliente anteriorCliente = BuscarAnterior(nodoInicial, clienteSeleccionado);
            if (anteriorCliente != null)
                anteriorCliente.siguiente = null;
            
        }

        private NodoCliente BuscarAnterior(NodoCliente nodoInicial, NodoCliente clienteSeleccionado)
        {
            if (nodoInicial.siguiente == clienteSeleccionado) return nodoInicial;

            return BuscarAnterior(nodoInicial.siguiente, clienteSeleccionado);
        }

        private void EliminarPrimero()
        {
            nodoInicial = nodoInicial.siguiente;
        }

        internal void ActualizarSeleccionado(NodoCliente clienteInicial, NodoCliente clienteSeleccionado)
        {
            if (clienteInicial != null)
            {
                if (clienteInicial.siguiente == clienteSeleccionado)
                    clienteInicial.siguiente.edad = clienteSeleccionado.edad;
                else
                    ActualizarSeleccionado(clienteInicial.siguiente, clienteSeleccionado);
            }
        }
    }
}
