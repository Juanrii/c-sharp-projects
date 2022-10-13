using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_ListasEjercicio4
{
    public class ListaCircular
    {
        public Jugador jugadorInicial;
        public Jugador jugadorFinal;

        internal void AgregarNuevo(string nombre, string apellido, int edad, int dni)
        {
            Jugador nuevoJugador = CrearNuevoJugador(nombre, apellido, edad, dni);

            if (jugadorInicial == null)
            {
                jugadorInicial = jugadorFinal = nuevoJugador;
                jugadorInicial.siguiente = jugadorFinal.siguiente = jugadorInicial;
            }
            else
            {
                Jugador jugadorFinal = BuscarJugadorFinal(jugadorInicial);
                if (jugadorFinal != null)
                {
                    jugadorFinal.siguiente = nuevoJugador;
                    this.jugadorFinal = nuevoJugador;
                    this.jugadorFinal.siguiente = jugadorInicial;
                }
            }
        }

        private Jugador CrearNuevoJugador(string nombre, string apellido, int edad, int dni)
        {
            Jugador nuevoJugador = new Jugador();
            nuevoJugador.nombre = nombre;
            nuevoJugador.apellido = apellido;
            nuevoJugador.edad = edad;
            nuevoJugador.dni = dni;
            return nuevoJugador;
        }

        private Jugador BuscarJugadorFinal(Jugador jugador)
        {
            // Si el siguiente es nulo o es jugadorInicial, es el ulitmo jugador
            if (jugador.siguiente == null || jugador.siguiente == jugadorInicial) return jugador;
            return BuscarJugadorFinal(jugador.siguiente);
        }

        internal void EliminarSeleccionado(Jugador jugadorSeleccionado)
        {
            if (jugadorSeleccionado != null)
            {
                if (EsElJugadorInicial(jugadorSeleccionado))
                    EliminarJugadorInicial();
                else if (EsElJugadorFinal(jugadorSeleccionado))
                    EliminarJugadorFinal(jugadorSeleccionado);
                else
                    EliminarJugadorSeleccionado(jugadorInicial, jugadorSeleccionado);
            }
        }

        private void EliminarJugadorSeleccionado(Jugador jugador, Jugador jugadorSeleccionado)
        {
            if (jugadorSeleccionado == jugadorInicial)
                jugadorInicial = jugadorInicial.siguiente;
            else if (jugador.siguiente == jugadorSeleccionado)
                jugador.siguiente = jugador.siguiente.siguiente;
            else
                EliminarJugadorSeleccionado(jugador.siguiente, jugadorSeleccionado);
        }

        private Jugador BuscarJugadorAnterior(Jugador jugador, Jugador jugadorSeleccionado)
        {
            if (jugador.siguiente == jugadorSeleccionado) return jugador;
            return BuscarJugadorAnterior(jugador.siguiente, jugadorSeleccionado);
        }

        private void EliminarJugadorFinal(Jugador jugadorSeleccionado)
        {
            Jugador anteUltimo = BuscarAnteUltimoJugador(jugadorInicial, jugadorSeleccionado);
            if (anteUltimo != null)
            {
                anteUltimo.siguiente = jugadorInicial;
                jugadorFinal = anteUltimo;
            }
        }

        private Jugador BuscarAnteUltimoJugador(Jugador jugador, Jugador jugadorSeleccionado)
        {
            if (jugador.siguiente == jugadorSeleccionado) return jugador;
            return BuscarAnteUltimoJugador(jugador.siguiente, jugadorSeleccionado);
        }

        private bool EsElJugadorFinal(Jugador jugadorSeleccionado)
        {
            return jugadorSeleccionado == jugadorFinal;
        }

        private void EliminarJugadorInicial()
        {
            if (jugadorInicial != null)
            {
                if (jugadorInicial.siguiente != jugadorInicial)
                {
                    jugadorInicial = jugadorInicial.siguiente;
                    jugadorFinal.siguiente = jugadorInicial;
                } 
                else
                {
                    jugadorInicial = jugadorFinal = null;
                }
            }
        }

        private bool EsElJugadorInicial(Jugador jugadorSeleccionado)
        {
            return jugadorSeleccionado == jugadorInicial;
        }

        internal void AgregarDespues(string nombre, string apellido, int edad, int dni, Jugador jugadorSeleccionado)
        {
            Jugador nuevoJugador = CrearNuevoJugador(nombre, apellido, edad, dni);

            if (jugadorSeleccionado == jugadorInicial)
            {
                Jugador aux = jugadorInicial.siguiente;
                jugadorInicial.siguiente = nuevoJugador;
                jugadorInicial.siguiente.siguiente = aux;
            }
            else if (jugadorSeleccionado == jugadorFinal)
            {
                jugadorFinal.siguiente = nuevoJugador;
                jugadorFinal.siguiente.siguiente = jugadorInicial;
            }
            else
            {
                Jugador aux = jugadorSeleccionado.siguiente;
                jugadorSeleccionado.siguiente = nuevoJugador;
                jugadorSeleccionado.siguiente.siguiente = aux;
            }

        }
    }
}
