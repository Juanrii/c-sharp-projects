using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreParcial2
{
    public class Alumno
    {

        public Alumno(int legajo)
        {
            this.Legajo = legajo;
        }

        public Alumno(string linea)
        {
            string[] datos = linea.Split(',');

            this.Legajo = Convert.ToInt32(datos[0]);
            this.Nombre = datos[1];
            this.Apellido = datos[2];
        }

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string GenerarRegistro()
        {
            return $"{Legajo},{Nombre},{Apellido}";
        }
    }
}
