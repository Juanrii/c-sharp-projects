using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Ejercicio nro 8 - Ingrese el valor de la hs de cada categoría
    e indique el sueldo de cada empleado, la cantidad de empleados por categoría
    y el valor total a pagar en calidad de sueldos */

namespace TP_INICIAL_EJER8
{
    class Program
    {

        static void Main(string[] args)
        {
            float[] vecValorHrCat = new float[4];
            float[] vecSueldosPorCat = new float[4];
            int[] vecEmpleadosPorCat = new int[4];
            string str;
            float sueldo, sueldoTotal = 0;
            int categoria, cantEmpleados = 0, legajo, horasTrabajadas;

            for (int i = 1; i < vecValorHrCat.Length; i++)
            {
                Console.WriteLine($"Ingrese el valor de la hora para la categoria {i}");
                str = Console.ReadLine();
                vecValorHrCat[i] = float.Parse(str);
            }

            // inicializo todos los valores en 0
            for (int i = 0; i < vecEmpleadosPorCat.Length; i++)
            {
                vecEmpleadosPorCat[i]   = 0;
                vecSueldosPorCat[i]     = 0;
            }

            Console.WriteLine("Ingrese el legajo del empleado: ");
            str = Console.ReadLine();
            legajo = Convert.ToInt32(str);

            while (legajo != 0)
            {

                do
                {
                    Console.WriteLine($"Legajo: {legajo} - Ingrese el la categoria del empleado: ");
                    str = Console.ReadLine();
                    categoria = Convert.ToInt32(str);
                } while (categoria < 1 || categoria > 3);

                // incrementar la cant de empleados por categoria
                vecEmpleadosPorCat[categoria]++;

                Console.WriteLine($"Legajo: {legajo} - Ingrese las horas trabajadas por el empleado: ");
                str = Console.ReadLine();
                horasTrabajadas = Convert.ToInt32(str);

                // calcular el sueldo
                sueldo = (float)(vecValorHrCat[categoria] * horasTrabajadas);

                // guardar suma de sueldos por categoria
                vecSueldosPorCat[categoria] += sueldo;

                // calcular sueldo total
                sueldoTotal += sueldo;

                // mostrar sueldo del empleado ingresado
                Console.WriteLine($"Legajo: {legajo} - El sueldo del empleado es: ${sueldo}");

                Console.WriteLine("Ingrese el legajo del empleado: ");
                str = Console.ReadLine();
                legajo = Convert.ToInt32(str);
            }

            Console.WriteLine("Cantidad de empleados por Categoria");
            for (int i = 1; i < vecEmpleadosPorCat.Length; i++)
            {
                Console.WriteLine($"Categoria {i}: {vecEmpleadosPorCat[i]} empleados.");
                cantEmpleados += vecEmpleadosPorCat[i];
            }

            Console.WriteLine($"El total de sueldos a pagar es de: ${sueldoTotal}");
            Console.WriteLine($"Cantidad total de empleados: {cantEmpleados}");
            Console.ReadKey();
        }
    }
}
