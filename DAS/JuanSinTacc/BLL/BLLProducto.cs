using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using Abstraccion;

namespace BLL
{
    public class BLLProducto : IGestor<BEProducto>
    {
        #region Propiedades
        private MPPProducto _mppProducto;
        #endregion

        #region Constructor
        public BLLProducto()
        {
            _mppProducto = new MPPProducto();
        }
        #endregion

        public bool Baja(BEProducto ObjBE)
        {
            return _mppProducto.Baja(ObjBE);
        }

        public bool Guardar(BEProducto ObjBE)
        {
            return _mppProducto.Guardar(ObjBE);
        }

        public List<BEProducto> Listar()
        {
            return _mppProducto.Listar();
        }

        public BEProducto ListarObjeto(BEProducto ObjBE)
        {
            throw new NotImplementedException();
        }
    }
}
