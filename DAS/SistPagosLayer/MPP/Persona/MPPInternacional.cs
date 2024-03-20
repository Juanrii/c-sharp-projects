using BE;
using DAL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPInternacional : IABM<BEInternacional>
    {
        private Acceso _acceso;
        private DataSet _ds;

        public MPPInternacional()
        {
            _acceso = new Acceso();
            _ds = _acceso.ObtenerDataSet();
        }

        

        public void Alta(BEInternacional persona)
        {
            try
            {
                DataTable tablePersona = _ds.Tables["Persona"];

                DataRow nuevaFila = tablePersona.NewRow();

                nuevaFila.ItemArray = new object[]
                {
                    persona.Documento,
                    persona.Nombre,
                    persona.Apellido,
                    persona.FechaNac,
                    persona.Extranjero
                };

                tablePersona.Rows.Add(nuevaFila);

                _acceso.Guardar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(BEInternacional persona)
        {
            try
            {
                DataTable table = _ds.Tables["Persona"];

                // Busco la fila a eliminar en cuestion
                DataRow filaAEliminar = table.Rows.Find(persona.Documento);

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

        public List<BEPersona> ListarTodo()
        {
            List<BEPersona> lista = new List<BEPersona>();

            BEPersona persona;

            foreach (DataRow fila in _ds.Tables["Persona"].Rows)
            {

                if (Convert.ToBoolean(fila.ItemArray[4]) == true)
                {
                    persona = new BEInternacional()
                    {
                        Documento = fila.ItemArray[0].ToString(),
                        Nombre = fila.ItemArray[1].ToString(),
                        Apellido = fila.ItemArray[2].ToString(),
                        FechaNac = Convert.ToDateTime(fila.ItemArray[3].ToString()),
                        Extranjero = true
                    };
                }
                else
                {
                    persona = new BENacional()
                    {
                        Documento = fila.ItemArray[0].ToString(),
                        Nombre = fila.ItemArray[1].ToString(),
                        Apellido = fila.ItemArray[2].ToString(),
                        FechaNac = Convert.ToDateTime(fila.ItemArray[3].ToString())
                    };
                }

                lista.Add(persona);
            }

            return lista;
        }

        public void Modificar(BEInternacional persona)
        {
            DataTable table = _ds.Tables["Persona"];

            // Busco la fila a modificar en cuestion
            DataRow filaAModificar = table.Rows.Find(persona.Documento);

            // Asigno los datos actualizados a cada campo
            filaAModificar["Nombre"] = persona.Nombre;
            filaAModificar["Apellido"] = persona.Apellido;
            filaAModificar["FechaNac"] = persona.FechaNac;
            filaAModificar["Extranjero"] = persona.Extranjero;

            _acceso.Guardar();
        }

        List<BEInternacional> IABM<BEInternacional>.ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
