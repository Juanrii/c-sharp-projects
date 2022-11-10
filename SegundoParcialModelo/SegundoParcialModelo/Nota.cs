using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialModelo
{
    public class Nota
    {
        public int Legajo { get; set; }
        public string Materia { get; set; }
        public double ValorNota { get; set; }
        public DateTime Fecha { get; set; }

        public Nota(int legajo)
        {
            Legajo = legajo;
        }

        public Nota(string linea)
        {
            string[] datos = linea.Split(',');

            Legajo = Convert.ToInt32(datos[0]);
            Materia = datos[1];
            ValorNota = Convert.ToDouble(datos[2]);
            Fecha = Convert.ToDateTime(datos[3]);
        }

        public string GenerarRegistro()
        {
            return $"{Legajo},{Materia},{ValorNota},{Fecha}";
        }
    }
}
