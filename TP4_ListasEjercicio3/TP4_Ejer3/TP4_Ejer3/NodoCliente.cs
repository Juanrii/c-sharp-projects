using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Ejer3
{
    public class NodoCliente
    {
        public int id;
        public int edad;
        public NodoCliente siguiente;

        public override string ToString()
        {
            return $"ID: {id} - Edad: {edad}";
        }
    }
}
