using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECeliaco : BEProducto
    {
        public string Harina { get; set; }

        public BECeliaco(string harina)
        {
            Harina = harina;
        }
        public BECeliaco() { }
        
    }
}
