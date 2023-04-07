using SegundoParcialRiosJuanIgnacio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRiosJuanIgnacio.Gestores
{
    public class GestorSocios : ICloneable
    {
        public List<Socio> ListaSocios = new List<Socio>();

        public void Agregar(string legajo, string nombre, string apellido, Socio socio)
        {
            socio.Legajo    = legajo;
            socio.Nombre    = nombre;
            socio.Apellido  = apellido;
                
            ListaSocios.Add(socio);
        }

        public object Clone()
        {
            List<Socio> cloneSocios = new List<Socio>();

            cloneSocios.AddRange(ListaSocios);

            return cloneSocios;
        }

        public List<Socio> ObtenerSocios()
        {
            List<Socio> cloneSocios = new List<Socio>();

            foreach (Socio s in ListaSocios)
            {
                cloneSocios.Add(s);
            }
            return cloneSocios;
        }

        public bool LegajoExistente(string legajo)
        {
            Socio e = ListaSocios.Find(x => x.Legajo == legajo);
            return e is Socio;
        }

        public void Modificar(string nombre, string apellido, Socio socio)
        {
            foreach (var s in from s in ListaSocios where s.Legajo == socio.Legajo select s)
            {
                s.Nombre = nombre;
                s.Apellido = apellido;
            }
        }

        public void Eliminar(Socio socio)
        {
            Socio socioExiste = ListaSocios.Find(s => s == socio);
            if (socioExiste != null) ListaSocios.Remove(socioExiste);
        }

        public void AsginarCuota(Socio socio, Cuota cuota)
        {
            foreach (var s in from s in ListaSocios where s.Legajo == socio.Legajo select s)
                s.AsignarCuota(cuota);
        }

        internal object ObtenerCuotasPagadas()
        {
            // Utilizar LinQ y tipos anonimos
            var query = from socio in ListaSocios
                        from cuota in socio.ObtenerCuotasPagadas()
                        select new
                        {
                            Nombre = socio.Nombre,
                            ImporteConAdicional = cuota.Importe + socio.ObtenerAdicional(cuota)
                        };
            return query.ToList();
        }
    }
}
