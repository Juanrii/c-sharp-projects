using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BESilver : BEPaquete
    {
        public float Abono = 0.15f;

        public BESilver()
        {
            Codigo = Guid.NewGuid();
            Canales = new List<BECanal>();
        }
    }
}
