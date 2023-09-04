using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using DAL;

namespace BLL
{
    public class BLLProvincia
    {
        Acceso accesoDAL;


        public List<BEProvincia> Listar()
        {
            List<BEProvincia> lista = new List<BEProvincia>();

            DataSet dataSet;

            string query = $"SELECT IdProvincia, Nombre FROM Provincia";

            accesoDAL = new Acceso();


            dataSet = accesoDAL.Leer(query);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    BEProvincia provincia = new BEProvincia();
                    provincia.IdProvincia = Convert.ToInt32(row["IdProvincia"]);
                    provincia.Nombre = row["Nombre"].ToString();
                    lista.Add(provincia);
                }
            }

            return lista;


        }
    }
}
