using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEAuto
    {
        public string AuPatente { get; set; }
        public DateTime AuFechaIngreso { get; set; }
        public DateTime AuFechaBaja { get; set; }
        public int AuAnio { get; set; }
        public bool AuEnUso { get; set; }
        public decimal AuValor { get; set; }
        public decimal ValorResidual { get; set; }

        public BEAuto() { }

        public BEAuto(string patente)
        {
            AuPatente = patente;
        }
    }
}
