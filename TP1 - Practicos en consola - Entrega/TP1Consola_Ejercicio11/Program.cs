using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 11 - Dada una frase informar la cantidad de caracteres que tiene.

namespace TP1Consola_Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int caracteres = 0, opcion;
            bool excluirEspacios;

            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
           
            do
            {
                Console.WriteLine("Desea excluir los espacios vacios? (1 - Si / 0 - No): ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 1 && opcion != 0);

            excluirEspacios = Convert.ToBoolean(opcion);

            if (excluirEspacios)
            {
                frase = frase.Replace(" ", "");
            }

            for (int i = 0; i < frase.Length; i++)
            {
                caracteres++;
            }

            Console.WriteLine($"La cantidad de caracteres de la frase \"{frase}\" es: {caracteres}");
            Console.ReadKey();
        }
    }
}
