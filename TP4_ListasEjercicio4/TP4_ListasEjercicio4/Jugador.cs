using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_ListasEjercicio4
{
    public class Jugador
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int dni;
        public Jugador siguiente;

        public override string ToString()
        {
            return String.Format($"Nombre: {nombre} - Apellido: {apellido} - Edad: {edad} - DNI: {dni}");
        }
    }
}
