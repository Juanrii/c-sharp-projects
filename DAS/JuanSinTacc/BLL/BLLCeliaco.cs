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
    public class BLLCeliaco : BLLProducto, IGestor<BECeliaco>
    {
        private MPPCeliaco _mppCeliaco;

        public BLLCeliaco()
        {
            _mppCeliaco = new MPPCeliaco();
        }

        public bool Baja(BECeliaco ObjBE)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BECeliaco producto)
        {
            return _mppCeliaco.Guardar(producto);
        }

        public List<BECeliaco> Listar()
        {
            return _mppCeliaco.Listar();
        }

        
    }
}
