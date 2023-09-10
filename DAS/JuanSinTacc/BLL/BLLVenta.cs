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
    public class BLLVenta : IGestor<BEVenta>
    {
        private MPPVenta _mppVenta;

        public BLLVenta()
        {
            _mppVenta = new MPPVenta();
        }

        public bool Baja(BEVenta ObjBE)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEVenta ObjBE)
        {
            return _mppVenta.Guardar(ObjBE);
        }

        public bool GuardarDetalleVenta(BEVenta venta, BEProducto producto)
        {
            return _mppVenta.GuardarDetalleVenta(venta, producto);
        }

        public List<BEVenta> Listar()
        {
            throw new NotImplementedException();
        }

        public BEVenta ListarObjeto(BEVenta ObjBE)
        {
            throw new NotImplementedException();
        }
    }
}
