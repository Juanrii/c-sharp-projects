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
    public class BLLVegano : BLLProducto, IGestor<BEProducto>
    {
        private MPPVegano _mppVegano;
        public BLLVegano()
        {
            _mppVegano = new MPPVegano();
        }
        public bool Baja(BEProducto ObjBE)
        {
            return _mppVegano.Baja(ObjBE);
        }

        public bool Guardar(BEProducto ObjBE)
        {
            return _mppVegano.Guardar(ObjBE);
        }

        public List<BEProducto> Listar()
        {
            return _mppVegano.Listar();
        }

        public BEProducto ListarObjeto(BEProducto ObjBE)
        {
            throw new NotImplementedException();
        }
    }
}
