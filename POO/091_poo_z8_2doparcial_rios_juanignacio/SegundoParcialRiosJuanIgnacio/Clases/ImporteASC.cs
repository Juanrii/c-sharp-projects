using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Clases
{
    public class ImporteASC : IComparer<Cuota>
    {
        public int Compare(Cuota x, Cuota y)
        {
            int criterio = 0;
            if (x.ObtenerImporteTotal() < y.ObtenerImporteTotal()) criterio = -1;
            if (x.ObtenerImporteTotal() > y.ObtenerImporteTotal()) criterio = 1;
            return criterio;
        }
    }
}
