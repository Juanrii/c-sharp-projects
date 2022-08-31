using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

// Ejercicio 12 - Mostrar la fecha y hora actual.

namespace TP1Consola_Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine($"La fecha y hora actual es: {localDate}");
            Console.ReadKey();
        }
    }
}
