using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using MPP;

namespace BLL
{
    public class BLLVegano : BLLProducto, IGestor<BEVegano>
    {
        private MPPVegano _mppVegano;
        public BLLVegano()
        {
            _mppVegano = new MPPVegano();
        }

        public bool Baja(BEVegano producto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEVegano producto)
        {
            return _mppVegano.Guardar(producto);
        }

        public List<BEVegano> Listar()
        {
            return _mppVegano.Listar();
        }

    }
}
