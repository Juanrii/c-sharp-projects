using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 13 - Dada una fecha mostrarla en el formato AAAAMMDD.

namespace TP1Consola_Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            string fecha = localDate.ToString("yyyyMMdd");
            Console.WriteLine($"La fecha actual en formato AAAAMMDD es: {fecha}");
            Console.ReadKey();
        }
    }
}
