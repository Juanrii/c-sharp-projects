using BE;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using Interfaces;

namespace MPP
{
    public class MPPAuto : IABM<BEAuto>
    {
        private Acceso _acceso;
        private DataSet _ds;

        public MPPAuto()
        {
            _acceso = new Acceso();
            _ds = _acceso.ObtenerDataSet();
        }

        public void Alta(BEAuto auto)
        {
            try
            {
                DataTable tableAuto = _ds.Tables["Auto"];

                DataRow nuevaFila = tableAuto.NewRow();

                nuevaFila.ItemArray = new object[]
                {
                    auto.AuPatente,
                    auto.AuAnio,
                    auto.AuEnUso,
                    auto.AuValor,
                    auto.AuFechaIngreso,
                    auto.AuFechaBaja
                };

                tableAuto.Rows.Add(nuevaFila);

                _acceso.Guardar();
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }
        }

        public void Baja(BEAuto autoSeleccionado)
        {
            try
            {
                DataTable table = _ds.Tables["Auto"];

                // Busco la fila a eliminar en cuestion
                DataRow filaAEliminar = table.Rows.Find(autoSeleccionado.AuPatente);

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

        public List<BEAuto> ListarTodo()
        {
            List<BEAuto> lista = new List<BEAuto>();

            foreach (DataRow fila in _ds.Tables["Auto"].Rows)
            {
                BEAuto auto = new BEAuto()
                {
                    AuPatente       = fila.ItemArray[0].ToString(),
                    AuAnio          = Convert.ToInt32(fila.ItemArray[1].ToString()),
                    ValorResidual   = 0,
                    AuEnUso         = Convert.ToBoolean(fila.ItemArray[2].ToString()),
                    AuValor         = Convert.ToDecimal(fila.ItemArray[3].ToString()),
                    AuFechaIngreso  = Convert.ToDateTime(fila.ItemArray[4].ToString()),
                    AuFechaBaja     = Convert.ToDateTime(fila.ItemArray[5].ToString()),
                };
                lista.Add(auto);
            }

            return lista;
        }

        public void Modificar(BEAuto autoSeleccionado)
        {
            DataTable table = _ds.Tables["Auto"];

            // Busco la fila a modificar en cuestion
            DataRow filaAModificar = table.Rows.Find(autoSeleccionado.AuPatente);

            // Asigno los datos actualizados a cada campo
            filaAModificar["AuFechaIngreso"]    = autoSeleccionado.AuFechaIngreso;
            filaAModificar["AuFechaBaja"]       = autoSeleccionado.AuFechaBaja;
            filaAModificar["AuAnio"]            = autoSeleccionado.AuAnio;
            filaAModificar["AuEnUso"]           = autoSeleccionado.AuEnUso;
            filaAModificar["AuValor"]           = autoSeleccionado.AuValor;

            _acceso.Guardar();
        }
    }
}
