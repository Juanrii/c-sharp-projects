using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 4 - Dados los datos necesarios de un Cuadrado calcular la superficie.

namespace TP1Consola_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, superficie;

            Console.WriteLine("Ingrese el lado del cuadrado: ");
            lado = Convert.ToDouble(Console.ReadLine());

            superficie = Math.Pow(lado, 2);

            Console.WriteLine($"La superficie del cuadrado de lado {lado} es: {superficie}");
            Console.ReadKey();
        }
    }
}
