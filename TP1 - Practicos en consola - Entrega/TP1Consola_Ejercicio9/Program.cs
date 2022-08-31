using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 9 - Dadas dos frases concatenarlas y mostrar el resultado. 

namespace TP1Consola_Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1, cadena2, resultado;

            Console.WriteLine("Ingrese una frase: ");
            cadena1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra frase para concatenar: ");
            cadena2 = Console.ReadLine();

            resultado = cadena1 + " " + cadena2;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
