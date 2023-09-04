using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BESocio
    {
        public int IdSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public BEPais Pais { get; set; }
        public BEProvincia  Provincia { get; set; }

        public BESocio()
        {

        }

        public BESocio(int idSocio, string nombre, string apellido, string email, BEPais pais, BEProvincia provincia)
        {
            IdSocio = idSocio;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Pais = pais;
            Provincia = provincia;
        }
    }
}
