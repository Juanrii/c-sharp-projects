using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Ejercicio nro 1 - Dado dos valores, sumarlos.

namespace TP_INICIAL_EJER1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, sum;
            string str;

            Console.WriteLine("Ingrese el primer numero: ");
            str = Console.ReadLine();
            num1 = float.Parse(str);

            Console.WriteLine("Ingrese el segundo numero: ");
            str = Console.ReadLine();
            num2 = float.Parse(str);

            sum = (num1 + num2);

            Console.WriteLine($"Resultado: {num1} + {num2} = {sum}");
            
            Console.ReadKey();
        }
    }
}
