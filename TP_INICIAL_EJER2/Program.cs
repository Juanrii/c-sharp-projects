using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio nro 2 - Dados dos valores indicar si son iguales

namespace TP_INICIAL_EJER2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string str, result;

            Console.WriteLine("Ingrese el primer numero: ");
            str = Console.ReadLine();
            num1 = Convert.ToInt32(str);

            Console.WriteLine("Ingrese el segundo numero: ");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str);

            // Forma facil, usando el Operador Ternario ?:
            // result = (condicion) ? entra por verdadero : entra por falso
            result = (num1 == num2) ? "Los numeros son iguales" : "Los numeros son distintos";
            Console.WriteLine(result);

            /* Forma comun: if-else
            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            } 
            else
            {
                Console.WriteLine("Los numeros son distintos");
            }*/

            Console.ReadKey();
        }
    }
}
