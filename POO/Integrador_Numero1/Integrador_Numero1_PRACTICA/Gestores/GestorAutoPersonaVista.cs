using Integrador_Numero1_PRACTICA.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_Numero1_PRACTICA.Gestores
{
    public class GestorAutoPersonaVista
    {
        List<AutoPersonaVista> _autoPersonaList = new List<AutoPersonaVista>();

        public void AgregarAutoPersona(Auto auto)
        {
            AutoPersonaVista apv = new AutoPersonaVista()
            {
                Marca   = auto.Marca,
                Anio    = auto.Anio,
                Modelo  = auto.Modelo,
                Patente = auto.Patente,
                DNI     = auto.Duenio().DNI,
                Duenio  = auto.Duenio().Apellido + ", " + auto.Duenio().Nombre
            };
            _autoPersonaList.Add(apv);
        }

        public List<AutoPersonaVista> ObtenerAutosDuenios()
        {
            List<AutoPersonaVista> clone = new List<AutoPersonaVista>();
            foreach (AutoPersonaVista ap in _autoPersonaList)
            {
                clone.Add(ap);
            }
            return clone;
        }

        public int CantidadAutosDuenios()
        {
            return _autoPersonaList.Count;
        }

        public void BorrarDuenio(Persona persona)
        {
            List<AutoPersonaVista> itemsABorrar = _autoPersonaList.FindAll(apv => apv.DNI == persona.DNI);
            foreach (AutoPersonaVista apv in itemsABorrar)
                if (apv is AutoPersonaVista) _autoPersonaList.Remove(apv);
        }

        public void BorrarAuto(Auto auto)
        {
            AutoPersonaVista ap = _autoPersonaList.Find(apv => apv.Patente == auto.Patente);
            if (ap is AutoPersonaVista) _autoPersonaList.Remove(ap);
        }
    }
}
