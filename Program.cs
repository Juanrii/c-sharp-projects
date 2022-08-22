using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio nro 6 - Ingresar los sueldos de empleados, sumarlos, indicar su Valor promedio, finaliza con legajo = 0.

namespace TP_INICIAL_EJER6
{
    class Program
    {
        static void Main(string[] args)
        {
            float prom = 0, sueldoTotal = 0, sueldo;
            int contSueldos = 0, legajo;
            string str;

            Console.WriteLine("Ingrese el numero de legajo (0 Finaliza): ");
            str = Console.ReadLine();
            legajo = Convert.ToInt32(str);

            while (legajo != 0)
            {
                contSueldos++;
                Console.WriteLine($"Legajo {legajo} - Ingrese el sueldo del empleado: ");
                str = Console.ReadLine();
                sueldo = float.Parse(str);
                sueldoTotal += sueldo;

                Console.WriteLine("Ingrese el numero de legajo (0 Finaliza): ");
                str = Console.ReadLine();
                legajo = Convert.ToInt32(str);
            }

            if (contSueldos == 0)
            {
                Console.WriteLine("No se han ingresados legajos.");
                Console.ReadKey();
                return;
            }

            prom = (float)(sueldoTotal / contSueldos);

            Console.WriteLine($"Sueldos ingresados: {contSueldos}");
            Console.WriteLine($"Sueldo Total: ${sueldoTotal}");
            Console.WriteLine($"El valor promedio de los sueldos ingresados es ${prom}");
            
            Console.ReadKey();
        }
    }
}
