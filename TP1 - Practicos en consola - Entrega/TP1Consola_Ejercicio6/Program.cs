using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Ejercicio 6 - Si la circunferencia de un círculo es pi * Diámetro,
    desarrollar una aplicación que dada la circunferencia calcule el diámetro. */

namespace TP1Consola_Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            double circunferencia, diametro;
            int precision;

            Console.WriteLine("Ingrese la circunferencia: ");
            circunferencia = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese la precision (decimales a mostrar): ");
                precision = Convert.ToInt32(Console.ReadLine());
            } while (precision < 0 || precision > 9);
            
            diametro = Math.Round( PI * circunferencia, precision);

            Console.WriteLine($"El diametro calculado es: {diametro}");
            Console.ReadKey();
        }
    }
}
