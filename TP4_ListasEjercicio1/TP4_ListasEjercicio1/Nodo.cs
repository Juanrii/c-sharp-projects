using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_ListasEjercicio1
{
    public class Nodo
    {
        public string codigo;
        public string nombre;
        public string apellido;
        public string direccion;
        public string telefono;
        public Nodo siguiente;

        // Necesario para mostrar correctamente la lista
        public override string ToString()
        {
            return string.Format($"{codigo} - {nombre} {apellido} - Direc: {direccion} - Tel: {telefono}");
        }

    }
}
