using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_Numero1_PRACTICA.Clases
{
    public class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public decimal Precio { get; set; }

        private Persona _duenio;
        public Persona SetearDuenio { set { _duenio = value; } }
    
        public Auto(string patente, string marca, string modelo, string anio, decimal precio)
        {
            Patente     = patente;
            Marca       = marca;
            Modelo      = modelo;
            Anio        = anio;
            Precio      = precio;
            _duenio     = null;
        }


        ~Auto()
        {
            // MessageBox.Show($"Patente: {Patente}");    
        }

        public Persona Duenio()
        {
            return _duenio;            
        }
    }
}
