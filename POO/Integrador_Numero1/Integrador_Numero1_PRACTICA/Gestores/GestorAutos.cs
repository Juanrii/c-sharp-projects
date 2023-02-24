using Integrador_Numero1_PRACTICA.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Numero1_PRACTICA.Gestores
{
    public class GestorAutos
    {
        List<Auto> _autoList = new List<Auto>();

        public int CantidadAutos()
        {
            return _autoList.Count();
        }

        internal void CrearAuto(string patente, string marca, string modelo, string anio, decimal precio)
        {
            Auto nuevoAuto = new Auto(patente, marca, modelo, anio, precio);
            _autoList.Add(nuevoAuto);
        }

        public void EliminarAuto(Auto auto)
        {
            _autoList.Remove(auto);
        }

        internal List<Auto> ObtenerAutos()
        {
            List<Auto> clone = new List<Auto>();
            foreach (Auto a in _autoList)
            {
                clone.Add(a);
            }
            return clone;
        }

        internal bool PatenteExistente(string patente)
        {
            return _autoList.Find(a => a.Patente == patente) is Auto;
        }

        public void AsignarDuenio(Persona persona, Auto auto)
        {
            try
            {
                foreach (Auto a in ObtenerAutos())
                {
                    if (a.Patente == auto.Patente)
                    {
                        if (a.Duenio() != null) throw new Exception("El auto ya posee duenio");
                        a.SetearDuenio = persona;
                        persona.AgregarAuto(a);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); throw;
            }
            
        }

        public void EliminarDuenio(Persona personaSeleccionada)
        {
            Auto auto = _autoList.Find(a => a.Duenio() == personaSeleccionada);
            if (auto is Auto) auto.SetearDuenio = null;
        }
    }
}
