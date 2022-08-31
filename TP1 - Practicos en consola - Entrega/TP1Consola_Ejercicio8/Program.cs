using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Ejercicio 8 - Calcular el factorial de 6. */

namespace TP1Consola_Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            int number = 6;
            int fact = 1;

            ShowMenu();

            option = GetOption();

            switch (option)
            {
                case 1:
                    fact = CalcRecursive(number);
                    break;
                case 2:
                    fact = CalcWithFor(number);
                    break;

                default:
                    break;
            }
            Console.WriteLine($"El factorial de {number} es: {fact}");
            Console.ReadKey();
        }

        private static int CalcWithFor(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Elija un metodo para caclular el factorial de 6");
            Console.WriteLine("1) - Recursividad\n2) - Con ciclo FOR");
        }
        private static int GetOption()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int CalcRecursive(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * CalcRecursive(number - 1);
        }
    }
}
