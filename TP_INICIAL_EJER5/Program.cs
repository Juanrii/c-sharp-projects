using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio nro 5 - Ingresar 4 valores y sumarlos.

namespace TP_INICIAL_EJER5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, resultado = 0;
            string str;
            const int MAX = 4;

            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                str = Console.ReadLine();
                valor = Convert.ToInt32(str);

                resultado += valor;
            }

            Console.WriteLine($"El total es: {resultado}");
            Console.ReadKey();
        }
    }
}
