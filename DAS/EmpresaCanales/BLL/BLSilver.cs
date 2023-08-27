using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLSilver : BLPaquete
    {
        public override float ObtenerAbono(BEPaquete beSilver)
        {
            return 1500 + 1500 * beSilver.Abono;
        }
    }
}
