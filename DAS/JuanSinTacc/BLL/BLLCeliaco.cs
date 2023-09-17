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
    public class BLLCeliaco : BLLProducto, IGestor<BEProducto>
    {
        private MPPCeliaco _mppCeliaco;

        public BLLCeliaco()
        {
            _mppCeliaco = new MPPCeliaco();
        }

        public bool Baja(BEProducto ObjBE)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEProducto ObjBE)
        {
            throw new NotImplementedException();
        }

        public List<BEProducto> Listar()
        {
            return _mppCeliaco.Listar();
        }

        public BEProducto ListarObjeto(BEProducto ObjBE)
        {
            throw new NotImplementedException();
        }
    }
}
