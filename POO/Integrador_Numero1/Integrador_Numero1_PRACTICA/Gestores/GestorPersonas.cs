using Integrador_Numero1_PRACTICA.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_Numero1_PRACTICA.Gestores
{
    public class GestorPersonas
    {
        List<Persona> _personaList = new List<Persona>();

        public void CrearPersona(string dni, string nombre, string apellido)
        {
            Persona nuevaPersona = new Persona()
            {
                DNI = dni,
                Nombre = nombre,
                Apellido = apellido
            };
            _personaList.Add(nuevaPersona);
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> clone = new List<Persona>();
            foreach (Persona p in _personaList)
            {
                clone.Add(p);
            }
            return clone;
        }

        public int CantidadPersonas()
        {
            return _personaList.Count;
        }

        public bool DniExistente(string dni)
        {
            return _personaList.Find(p => p.DNI == dni) is Persona;
        }

        public void EliminarPersona(Persona persona)
        {
            _personaList.Remove(persona);
        }
    }
}
