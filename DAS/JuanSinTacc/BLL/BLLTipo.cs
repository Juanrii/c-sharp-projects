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
    public class BLLTipo : IGestor<BETipo>
    {
        #region Propiedades
        private MPPTipo _mppTipo;
        #endregion

        #region Constructor
        public BLLTipo()
        {
            _mppTipo = new MPPTipo();
        }
        #endregion
        public bool Baja(BETipo ObjBE)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BETipo ObjBE)
        {
            return _mppTipo.Guardar(ObjBE);
        }

        public List<BETipo> Listar()
        {
            return _mppTipo.Listar();
        }

        public BETipo ListarObjeto(BETipo ObjBE)
        {
            throw new NotImplementedException();
        }
    }
}
