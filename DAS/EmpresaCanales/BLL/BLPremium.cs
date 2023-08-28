using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLPremium : BLPaquete
    {
        public override float ObtenerAbono(BEPaquete bePremium)
        {
             return 3000 + 3000 * bePremium.Abono;
        }
    }
}
