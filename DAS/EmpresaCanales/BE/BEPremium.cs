using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPremium : BEPaquete
    {
        protected float Abono = 0.20f;

        public BEPremium()
        {
            Codigo = Guid.NewGuid();
            Canales = new List<BECanal>();
        }
    }
}
