using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace MPP
{
    public class MPPUsuario
    {
        private Acceso _acceso;

        public MPPUsuario()
        {
            _acceso = new Acceso();
        }

        public bool Buscar(BEUsuario usuario)
        {
            string query = $"SELECT COUNT(*) FROM Usuario WHERE Usuario.Usuario = '{usuario.Usuario}' AND Usuario.Contrasena = '{usuario.Contra}'";
            return _acceso.LeerScalar(query);
        }
    }
}
