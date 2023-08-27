using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public BECliente() { }

        public BECliente(int codigo, string nombre, string apellido, int dNI, DateTime fechaNacimiento)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            FechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Apellido}, {DNI}";
        }
    }
}
