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

        public List<BEVenta> Listar()
        {
            return _mppVenta.Listar();
        }

        public List<BEVenta> ListarPorCliente(BECliente cliente)
        {
            return _mppVenta.ListarPorCliente(cliente);
        }

        public List<BEProducto> ListarMasVendidos()
        {
            return _mppVenta.ListarMasVendidos();
        }

        public decimal ObtenerVentaTotal()
        {
            return _mppVenta.ObtenerVentaTotal();
        }

        public int ObtenerVentasRealizadas()
        {
            return _mppVenta.ObtenerVentasRealizadas();
        }
    }
}
