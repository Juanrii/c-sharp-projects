using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_ListasEjercicio2
{
    public class ListaAlumnos
    {
        public Nodo nodoInicial = null;

        /*
         * Array asociativo datosAlumno => ["key" => value]
         * **/
        public void AgregarAlumno(Dictionary<string, string> datosAlumno)
        {
            try
            {
                Nodo nuevoAlumno = new Nodo();
                nuevoAlumno.nombre = datosAlumno["nombre"];
                nuevoAlumno.apellido = datosAlumno["apellido"];
                nuevoAlumno.dni = Convert.ToInt32(datosAlumno["dni"]);
                nuevoAlumno.direccion = datosAlumno["direccion"];
                nuevoAlumno.telefono = datosAlumno["tel"];
                nuevoAlumno.fechaNacimiento = datosAlumno["fechaNacimiento"];

                if (nodoInicial == null)
                {
                    nodoInicial = nuevoAlumno;
                }
                else
                {
                    Nodo aux = nodoInicial;
                    nodoInicial = nuevoAlumno;
                    nodoInicial.siguiente = aux;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos. Por favor vuelva a ingresarlos", "Datos invalidos");
            }
            
        }

        internal void EliminarAlumno(Nodo nodoSeleccionado)
        {
            if (nodoInicial != null)
            {
                if (nodoInicial == nodoSeleccionado)
                {
                    EliminarPrimero();
                }
                else
                {
                    Nodo ultimoAlumno = BuscarUltimo(nodoInicial);
                    if (ultimoAlumno != null && ultimoAlumno.dni == nodoSeleccionado.dni)
                    {
                        EliminarUltimo();
                    }
                    else
                    {
                        Nodo alumnoAnterior = BuscarAnterior(nodoInicial, nodoSeleccionado);
                        EliminarSeleccionado(alumnoAnterior);
                    }
                }
            }
        }

        private void EliminarSeleccionado(Nodo alumnoAnterior)
        {
            if (alumnoAnterior != null)
                alumnoAnterior.siguiente = alumnoAnterior.siguiente.siguiente;
        }

        private Nodo BuscarAnterior(Nodo nodoInicial, Nodo nodoSeleccionado)
        {
            if (nodoInicial.siguiente != null && nodoInicial.siguiente.dni == nodoSeleccionado.dni)
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
            if (nodoInicial.siguiente.siguiente == null) return nodoInicial;
            return BuscarAnteultimo(nodoInicial.siguiente);
        }

        private Nodo BuscarUltimo(Nodo nodoInicial)
        {
            if (nodoInicial == null) return null;
            if (nodoInicial.siguiente == null) return nodoInicial;
            return BuscarUltimo(nodoInicial.siguiente);
        
        }

        private void EliminarPrimero()
        {
            if (nodoInicial != null)
                nodoInicial = nodoInicial.siguiente;
        }

        internal void AgregarDespues(Nodo nodoSeleccionado, Dictionary<string, string> datosAlumno)
        {
            Nodo nuevoAlumno = new Nodo();
            nuevoAlumno.nombre = datosAlumno["nombre"];
            nuevoAlumno.apellido = datosAlumno["apellido"];
            nuevoAlumno.dni = Convert.ToInt32(datosAlumno["dni"]);
            nuevoAlumno.direccion = datosAlumno["direccion"];
            nuevoAlumno.telefono = datosAlumno["tel"];
            nuevoAlumno.fechaNacimiento = datosAlumno["fechaNacimiento"];

            Nodo aux = nodoSeleccionado.siguiente;
            nodoSeleccionado.siguiente = nuevoAlumno;
            nuevoAlumno.siguiente = aux;
        }

        internal void AgregarAntes(Nodo nodoSeleccionado, Dictionary<string, string> datosAlumno)
        {
            Nodo nuevoAlumno = new Nodo();
            nuevoAlumno.nombre = datosAlumno["nombre"];
            nuevoAlumno.apellido = datosAlumno["apellido"];
            nuevoAlumno.dni = Convert.ToInt32(datosAlumno["dni"]);
            nuevoAlumno.direccion = datosAlumno["direccion"];
            nuevoAlumno.telefono = datosAlumno["tel"];
            nuevoAlumno.fechaNacimiento = datosAlumno["fechaNacimiento"];

            Nodo alumnoAnterior = BuscarAnterior(nodoInicial, nodoSeleccionado);

            if (alumnoAnterior == null)
            {
                nodoInicial = nuevoAlumno;
                nodoInicial.siguiente = nodoSeleccionado;
            }
            else
            {
                alumnoAnterior.siguiente = nuevoAlumno;
                nuevoAlumno.siguiente = nodoSeleccionado;
            }

        }

    }
}
