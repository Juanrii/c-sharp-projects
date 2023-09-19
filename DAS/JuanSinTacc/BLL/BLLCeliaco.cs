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

        public bool Baja(BECeliaco producto)
        {
            return _mppCeliaco.Baja(producto);
        }

        public bool Guardar(BECeliaco producto)
        {
            return _mppCeliaco.Guardar(producto);
        }

        public List<BECeliaco> Listar()
        {
            return _mppCeliaco.Listar();
        }

        public List<BECeliaco> ObtenerStocks(BECeliaco producto)
        {
            return _mppCeliaco.ObtenerStocks(producto);
        }

        

        public List<BEProducto> ListarTodo()
        {
            return _mppCeliaco.ListarTodo();
        }

        
    }
}
