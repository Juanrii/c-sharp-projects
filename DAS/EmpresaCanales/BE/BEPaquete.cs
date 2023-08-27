using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPaquete
    {
        public Guid Codigo { get; set; }
        public List<BECanal> Canales { get; set; }
        public BECliente Cliente { get; set; }

        public float Abono { get; set; }

        public override string ToString()
        {
            return $"{Cliente.Nombre}";
        }
    }
}
