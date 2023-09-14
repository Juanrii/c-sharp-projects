using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEVegano : BEProducto
    {
        public bool Huevo { get; set; }

        public BEVegano(bool huevo)
        {
            Huevo = huevo;
        }
        public BEVegano() { }

    }
}
