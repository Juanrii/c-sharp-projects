using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Excepciones
{
    internal class PatenteExistenteException : Exception
    {
        public PatenteExistenteException(string msg) : base(msg) { }
    }
}
