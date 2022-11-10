using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialModelo
{
    public class Promedio
    {
        public int Legajo { get; set; }
        public double ValorPromedio { get; set; }
        
        public Promedio(int legajo, double valorPromedio)
        {
            Legajo = legajo;
            ValorPromedio = valorPromedio;
        }

        public Promedio(string linea)
        {
            string[] datos = linea.Split(',');
            Legajo = Convert.ToInt32(datos[0]);
            ValorPromedio = Convert.ToDouble(datos[1]);
        }

        public string GenerarRegistro()
        {
            return $"{Legajo},{ValorPromedio}";
        }

    }
}
