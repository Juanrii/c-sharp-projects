using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 1 - Dados dos valores ingresados por teclado mostrar la suma de ambos.

namespace TP1Consola_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, sum;

            Console.WriteLine("Ingrese el primer numero: ");
            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            number2 = float.Parse(Console.ReadLine());

            sum = number1 + number2;
            
            Console.WriteLine($"La suma de {number1} + {number2} es: {sum}");
            Console.ReadKey();
        }
    }
}
