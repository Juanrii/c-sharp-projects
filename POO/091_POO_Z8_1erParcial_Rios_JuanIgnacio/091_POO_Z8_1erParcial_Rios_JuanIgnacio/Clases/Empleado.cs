using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases
{
    /*
     * Esta clase Empleado define las propiedades y metodos.
     * Al ser abstracta no es posible instanciarla.
     */
    public abstract class Empleado
    {
        #region "Propiedades"
        // Esta lista de adelantos es protegida para que cada clase
        // que herede de Empleado pueda utilizarla
        protected List<Adelanto> ListaAdelantos = new List<Adelanto>();

        // La propiedad BENEFICIO es el porcentaje que cada clase
        // que herede de Empleado tendra
        protected virtual double BENEFICIO { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Sueldo { get; set; }
        #endregion

        #region "Metodos"
        public void AsignarAdelanto(Adelanto adelanto)
        {
            // Se agrega el nuevo adelanto a la lista
            ListaAdelantos.Add(adelanto);
        }

        public int ObtenerCantidadAdelantos()
        {
            // Devuelve un entero con la cantidad de adelantos en la lista
            return ListaAdelantos.Count;
        }

        public bool TieneAdelantos()
        {
            // Verifica si la lista esta vacia o no
            return ListaAdelantos.Count > 0 ? true : false;
        }

        public double ObtenerBeneficio()
        {
            return BENEFICIO;
        }
        #endregion
    }
}
