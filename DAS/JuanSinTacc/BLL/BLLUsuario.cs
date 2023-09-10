using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLUsuario
    {
        private MPPUsuario _mppUsuario;

        public BLLUsuario()
        {
            _mppUsuario = new MPPUsuario();
        }

        public int Buscar(BEUsuario usuario)
        {
            return _mppUsuario.Buscar(usuario);
        }
    }
}
