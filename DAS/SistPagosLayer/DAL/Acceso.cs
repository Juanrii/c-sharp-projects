using System;
using System.Data;
using System.IO;

namespace DAL
{
    public class Acceso
    {
        private static DataSet _ds = null;
        private DataTable _tablePersona;
        private DataTable _tablePago;
        private DataRelation _relation;
        private const string NOMBRE_ARCHIVO = "Datos.xml";

        //public Acceso()
        //{
        //    _ds = new DataSet();

        //    if (!File.Exists(NOMBRE_ARCHIVO))
        //        CrearArchivo();
        //    else
        //        _ds.ReadXml(NOMBRE_ARCHIVO);

        //}

        // Tuve que hacer static a _ds porque sino se me sobreescribia el dataSet cuando
        // agregaba disintos tipos de personas. Con este cambio, la instancia del _ds es unica.
        public Acceso()
        {
            if (_ds == null)
            {
                _ds = new DataSet();
                Inicializar();
            }
        }

        private void Inicializar()
        {
            if (!File.Exists(NOMBRE_ARCHIVO))
                CrearArchivo();
            else
                _ds.ReadXml(NOMBRE_ARCHIVO);
        }

        private void CrearArchivo()
        {
            try
            {

                CrearTablePersona();

                CrearTablePago();

                // Agregar tablas al DataSet
                _ds.Tables.AddRange(new DataTable[]
                {
                    _tablePersona,
                    _tablePago
                });

                // Relacion entre tablas (clave foranea FK)
                _relation = new DataRelation(
                    "FK_Persona_Pago", 
                    _tablePersona.Columns["Documento"], 
                    _tablePago.Columns["PersonaDoc"]
                );

                // Agregar la relacion al DataSet
                _ds.Relations.Add(_relation);
                

                // Insertar los datos al XML
                Guardar();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void CrearTablePersona()
        {
            // Nombre de la tabla
            _tablePersona = new DataTable("Persona");

            // Columnas
            _tablePersona.Columns.Add("Documento", typeof(string));
            _tablePersona.Columns.Add("Nombre", typeof(string));
            _tablePersona.Columns.Add("Apellido", typeof(string));
            _tablePersona.Columns.Add("FechaNac", typeof(DateTime));
            _tablePersona.Columns.Add("Extranjero", typeof(bool));

            // Primary Key - El 0 hace referencia al campo Documento
            _tablePersona.PrimaryKey = new DataColumn[] { _tablePersona.Columns[0] };
        }

        private void CrearTablePago()
        {
            // Nombre de la tabla
            _tablePago = new DataTable("Pago");

            // Columnas
            _tablePago.Columns.Add("PagoId", typeof(int));
            _tablePago.Columns.Add("Fecha", typeof(DateTime));
            _tablePago.Columns.Add("Importe", typeof(decimal));
            _tablePago.Columns.Add("PersonaDoc", typeof(string));

            // Primary Key - El 0 hace referencia al campo PagoId
            _tablePago.PrimaryKey = new DataColumn[] { _tablePago.Columns[0] };
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
