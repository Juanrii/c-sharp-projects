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
                }
            }
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
    }
}
