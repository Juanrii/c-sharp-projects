using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreParcial2
{
    public class Promedio
    {
        public Promedio(int legajo)
        {
            this.Legajo = legajo;
        }

        public int Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public float ValorPromedio { get; set; }

        public string GenerarRegistro()
        {
            return $"{Legajo},{Apellido},{Nombre},{ValorPromedio}";
        }
    }
}
