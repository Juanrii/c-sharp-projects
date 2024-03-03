using System;
using System.Data;
using System.IO;

namespace DAO
{
    public class Acceso
    {
        private DataSet _ds;
        private DataTable _tableAuto;
        private const string NOMBRE_ARCHIVO = "Datos.xml";

        public Acceso()
        {
            _ds = new DataSet();

            if (! File.Exists(NOMBRE_ARCHIVO))
                CrearArchivo();

            _ds.ReadXml(NOMBRE_ARCHIVO);
        }

        private void CrearArchivo()
        {
            try
            {
                // Nombre de la tabla
                _tableAuto = new DataTable("Auto");

                // Columnas
                _tableAuto.Columns.Add("AuPatente", typeof(string));
                _tableAuto.Columns.Add("AuAnio", typeof(int));
                _tableAuto.Columns.Add("AuEnUso", typeof(bool));
                _tableAuto.Columns.Add("AuValor", typeof(decimal));
                _tableAuto.Columns.Add("AuFechaIngreso", typeof(DateTime));
                _tableAuto.Columns.Add("AuFechaBaja", typeof(DateTime));

                // Primary Key - El 0 hace referencia al campo AuPatente
                _tableAuto.PrimaryKey = new DataColumn[] { _tableAuto.Columns[0] };

                // Agregar la tabla al DataSet
                _ds.Tables.Add(_tableAuto);

                // Insertar los datos al XML
                Guardar();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void Guardar()
        {
            _ds.WriteXml(NOMBRE_ARCHIVO, XmlWriteMode.WriteSchema);
        }

        public DataSet ObtenerDataSet()
        {
            return _ds;
        }
    }
}
