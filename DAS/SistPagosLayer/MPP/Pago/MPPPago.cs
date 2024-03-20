using BE.Pago;
using DAL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace MPP.Pago
{
    public class MPPPago : IABM<BEPago>
    {
        private Acceso _acceso;
        private DataSet _ds;

        public MPPPago()
        {
            _acceso = new Acceso();
            _ds = _acceso.ObtenerDataSet();
        }

        public void Alta(BEPago pago)
        {
            try
            {
                DataTable tablePago = _ds.Tables["Pago"];

                DataRow nuevaFila = tablePago.NewRow();

                nuevaFila.ItemArray = new object[]
                {
                    pago.PagoId,
                    pago.Fecha,
                    pago.Importe,
                    pago.PersonaDoc,
                };

                tablePago.Rows.Add(nuevaFila);

                _acceso.Guardar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(BEPago pago)
        {
            try
            {
                DataTable table = _ds.Tables["Pago"];

                // Busco la fila a eliminar en cuestion
                DataRow filaAEliminar = table.Rows.Find(pago.PagoId);

                // Se remueve la fila que contiene la patente seleciconada
                table.Rows.Remove(filaAEliminar);

                // Grabar los cambios
                _acceso.Guardar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BEPago> ListarTodo()
        {
            List<BEPago> lista = new List<BEPago>();

            foreach (DataRow fila in _ds.Tables["Pago"].Rows)
            {
                BEPago pago = new BEPago()
                {
                    PagoId = Convert.ToInt32(fila.ItemArray[0]),
                    Fecha = Convert.ToDateTime(fila.ItemArray[1].ToString()),
                    Importe = Convert.ToDecimal(fila.ItemArray[2].ToString()),
                    PersonaDoc = fila.ItemArray[3].ToString()
                };
                lista.Add(pago);
            }

            return lista;
        }

        public void Modificar(BEPago beObject)
        {
            throw new NotImplementedException();
        }
    }
}
