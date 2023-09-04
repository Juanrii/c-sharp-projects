using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPais
    {
        public int IdPais { get; set; }
        public string Nombre { get; set; }

        public BEPais() { }

        public BEPais(int idPais, string nombre)
        {
            IdPais = idPais;
            Nombre = nombre;
        }
    }
}
