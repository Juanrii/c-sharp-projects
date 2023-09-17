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
    public class BLLCliente : IGestor<BECliente>
    {
        #region Propiedades
        private MPPCliente _mppCliente;
        #endregion

        #region Constructor
        public BLLCliente()
        {
            _mppCliente = new MPPCliente();
        }
        #endregion

        #region Metodos
        public bool Baja(BECliente ObjBE)
        {
            return _mppCliente.Baja(ObjBE);
        }

        public bool Guardar(BECliente ObjBE)
        {
            return _mppCliente.Guardar(ObjBE);
        }

        public List<BECliente> Listar()
        {
            return _mppCliente.Listar();
        }

        public BECliente ListarObjeto(BECliente ObjBE)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
