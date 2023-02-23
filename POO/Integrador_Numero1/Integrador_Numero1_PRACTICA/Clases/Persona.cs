using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Numero1_PRACTICA.Clases
{
    public class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private List<Auto> _listaAutos = null;

        public Persona() 
        {
            _listaAutos = new List<Auto>();
        }

        ~Persona() 
        {
            // MessageBox.Show($"DNI: {DNI}");    
        }

        public List<Auto> ListaDeAutos()
        {
            List<Auto> autos = new List<Auto>();

            foreach (Auto a in _listaAutos)
                autos.Add(a);

            return autos;
        }

        public int CantidadDeAutos()
        {
            return ListaDeAutos().Count();
        }

        internal void AgregarAuto(Auto a)
        {
            _listaAutos.Add(a);
        }

        public void QuitarAuto(Auto autoSeleccionado)
        {
            Auto auto = _listaAutos.Find(a => a.Patente == autoSeleccionado.Patente);
            if (auto is Auto)
            {
                _listaAutos.Remove(auto);
            }
        }
    }
}
