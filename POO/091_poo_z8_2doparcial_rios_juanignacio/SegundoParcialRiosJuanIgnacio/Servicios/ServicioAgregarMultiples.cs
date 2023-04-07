using SegundoParcialRiosJuanIgnacio.Clases;
using SegundoParcialRiosJuanIgnacio.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialRiosJuanIgnacio.Servicios
{
    public class ServicioAgregarMultiples
    {
        #region "Gestores"
        private GestorCuotas _gestorCuotas;
        private GestorSocios _gestorSocios;
        #endregion

        #region "Constantes"
        const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private Random _random = new Random();
        #endregion

        #region "Constructor"
        public ServicioAgregarMultiples(int mes, int anio, double importe, GestorCuotas gestorCuotas, GestorSocios gestorSocios)
        {
            try
            {
                _gestorCuotas = gestorCuotas;
                _gestorSocios = gestorSocios;

                foreach (Socio socio in _gestorSocios.ObtenerSocios())
                {
                    var cuotasAsignadas = socio.ObtenerCuotas();

                    var query = (from ca in cuotasAsignadas where ca.Mes == mes select ca).ToList();

                    // Ignorar la asignacion para el mes ya existente
                    if (query.Count > 0)
                        continue;

                    string codigoAleatorio = new string(
                            Enumerable.Repeat(caracteres, 8)
                                      .Select(c => c[_random.Next(c.Length)])
                                      .ToArray()
                        );
                    if (String.IsNullOrEmpty(codigoAleatorio))
                        throw new Exception("El codigo no puede ser vacio");

                    if (_gestorCuotas.CodigoExistente(codigoAleatorio))
                        throw new Exception($"El codigo: {codigoAleatorio} ya existe. Por favor ingrese otro");

                    Cuota cuota = _gestorCuotas.Asginar(codigoAleatorio, mes, anio, importe, socio);
                    socio.AsignarCuota(cuota);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        #endregion

        #region "Destructor"
        ~ServicioAgregarMultiples() { }
        #endregion
    }
}
