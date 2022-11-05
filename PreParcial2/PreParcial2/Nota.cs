using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreParcial2
{
    public class Nota
    {
        public Nota(int legajo)
        {
            this.Legajo = legajo;
        }

        public Nota(string linea)
        {
            string[] datos = linea.Split(',');

            this.Legajo = Convert.ToInt32(datos[0]);
            this.Materia = datos[1];
            this.ValorNota = Convert.ToInt32(datos[2]);
            this.Fecha = datos[3];
        }
        public int Legajo { get; set; }
        public string Materia { get; set; }
        public int ValorNota { get; set; }
        public string Fecha { get; set; }

        public string GenerarRegistro()
        {
            return $"{Legajo},{Materia},{ValorNota},{Fecha}";
        }
    }
}
