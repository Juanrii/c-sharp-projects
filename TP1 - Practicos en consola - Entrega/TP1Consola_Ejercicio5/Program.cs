using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 5 - Dados los datos necesarios de un Rectángulo calcular la superficie.

namespace TP1Consola_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, superficie;

            do
            {
                Console.WriteLine("Ingrese el uno de los lados del rectangulo: ");
                ladoA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el otro lado del rectangulo: ");
                ladoB = Convert.ToDouble(Console.ReadLine());

                if (ladoA == 0 || ladoB == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Los lados no pueden ser cero");
                }

            } while (ladoA == 0 || ladoB == 0);
            
            /* La superficie de un rectangulo se calculo como sup = a x b */
            superficie = ladoA * ladoB;

            Console.WriteLine($"La superficie del rectangulo es: {superficie}");
            Console.ReadKey();
        }
    }
}
