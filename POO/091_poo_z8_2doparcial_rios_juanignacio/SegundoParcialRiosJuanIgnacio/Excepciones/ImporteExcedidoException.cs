using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Excepciones
{
    public class ImporteExcedidoException : Exception
    {
        public ImporteExcedidoException(string message) : base(message) { }
    }
}
