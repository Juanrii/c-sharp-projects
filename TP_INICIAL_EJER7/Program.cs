using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Ejercicio nro 7 - Ingresar el valor de la hs de cada categoría, guardarlo en
    Un vector y luego ingresar los empleados de la empresa Hasta legajo = 0, 
    indicar el sueldo de cada empleado y el total a pagar */

namespace TP_INICIAL_EJER7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectValor = new int[4];
            int cat, legajo, horasTrabajadas;
            float sueldo, totSueldo = 0;
            string str;

            for (int i = 1; i < vectValor.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el valor de la hora para la categoria {i}: ");
                    vectValor[i] = Convert.ToInt32(Console.ReadLine());
                } while (vectValor[i] < 1 || vectValor[i] > 3);
            }

            Console.WriteLine("Ingrese el numero de legajo (0 FINALIZA): ");
            str = Console.ReadLine();
            legajo = Convert.ToInt32(str);

            while (legajo != 0)
            {
                Console.WriteLine("Ingrese la categoria del empleado (1 - 3): ");
                str = Console.ReadLine();
                cat = Convert.ToInt32(str);

                Console.WriteLine("Ingrese el numero de horas trabajadas: ");
                str = Console.ReadLine();
                horasTrabajadas = Convert.ToInt32(str);

                sueldo = (float)(horasTrabajadas * vectValor[cat]);

                totSueldo += sueldo;

                Console.WriteLine($"El sueldo correspondiente al legajo {legajo} es de ${sueldo}");

                Console.WriteLine("Ingrese el numero de legajo (0 FINALIZA): ");
                str = Console.ReadLine();
                legajo = Convert.ToInt32(str);
            }

            Console.WriteLine($"El total de sueldos a pagar es de: ${totSueldo}");
            Console.ReadKey();
        }
    }
}
