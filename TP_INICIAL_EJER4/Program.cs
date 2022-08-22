using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio nro 4 - Ingresar dos valores, indicar si son iguales y de ser diferentes indicar cuál es menor.

namespace TP_INICIAL_EJER4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string str;

            Console.WriteLine("Ingrese el primer valor: ");
            str = Console.ReadLine();
            num1 = Convert.ToInt32(str);

            Console.WriteLine("Ingrese el segundo valor: ");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str);

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"El numero {num2} es menor");
            } else
            {
                Console.WriteLine($"El numero {num1} es menor");
            }

            Console.ReadKey();

        }
    }
}
