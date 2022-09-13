using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_ListasEjercicio2
{
    public class Nodo
    {
        public string nombre;
        public string apellido;
        public int dni;
        public string direccion;
        public string telefono;
        public string fechaNacimiento;
        public Nodo siguiente;

        public override string ToString()
        {
            return $"Alumno: {nombre} {apellido} - DNI: {dni} - Fecha Nacimiento: {fechaNacimiento} - Direc: {direccion} - Tel: {telefono}";
        }
    }
}
