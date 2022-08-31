using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 2 - Desarrollar una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.

namespace TP1Consola_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, count = 0;

            do
            {
                Console.WriteLine("Ingrese el numero desde donde contar: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese hasta que numero contar: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                if (number1 > number2)
                {
                    Console.WriteLine($"El primer numero: {number1} no puede ser mayor al ultimo!");
                }

            } while (number1 > number2);

            Console.WriteLine($"Los numeros que estan entre {number1} y {number2} son: ");
            for (int i = number1+1; i < number2; i++)
            {
                count++;
                Console.WriteLine($"{i}");
            }
            
            Console.WriteLine($"En total son {count} numeros que hay entre {number1} y {number2}");
            Console.ReadKey();
        }
    }
}
