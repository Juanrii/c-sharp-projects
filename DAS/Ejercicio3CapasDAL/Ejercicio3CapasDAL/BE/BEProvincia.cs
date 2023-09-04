using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProvincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }

        public BEProvincia() { }

        public BEProvincia(int idProvincia, string nombre)
        {
            IdProvincia = idProvincia;
            Nombre = nombre;
        }
    }
}
