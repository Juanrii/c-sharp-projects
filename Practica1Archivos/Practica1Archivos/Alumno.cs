using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Archivos
{
    public class Alumno
    {
        public Alumno(long dni)
        {
            this.DNI = dni;
        }

        public Alumno(string linea)
        {
            string[] datos = linea.Split(',');

            this.DNI = long.Parse(datos[0]);
            this.Apellido = datos[1];
            this.Nombre = datos[2];
        }


        public long DNI { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string GenerarRegistro()
        {
            return $"{DNI},{Apellido},{Nombre}";
        }
    }
}
