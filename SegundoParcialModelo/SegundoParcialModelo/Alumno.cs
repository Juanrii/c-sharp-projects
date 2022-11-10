using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialModelo
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Alumno(int legajo)
        {
            this.Legajo = legajo;
        }

        public Alumno(string linea)
        {
            string[] datos = linea.Split(',');

            Legajo = Convert.ToInt32(datos[0]);
            Nombre = datos[1];
            Apellido = datos[2];
        }

        public string GenerarRegistro()
        {
            return $"{Legajo},{Nombre},{Apellido}";
        }
    }
}
