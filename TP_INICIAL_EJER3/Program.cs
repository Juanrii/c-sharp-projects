using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio nro 3 - Ingresar el valor de la hora y el tiempo de trabajo de  operador, indicar su sueldo.

namespace TP_INICIAL_EJER3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorHora, sueldo;
            int horasTrabajadas;
            string str;

            Console.WriteLine("Ingrese el valor de la hora del empleado: ");
            str = Console.ReadLine();
            valorHora = Convert.ToDouble(str);

            Console.WriteLine("Ingrese las horas trabajadas: ");
            str = Console.ReadLine();
            horasTrabajadas = Convert.ToInt32(str);

            sueldo = CalcularSueldo(valorHora, horasTrabajadas);

            ImprimirSueldo(sueldo);
        }

        static double CalcularSueldo(double valor, int horas)
        {
            return valor * horas;
        }

        static void ImprimirSueldo(double sueldo)
        {
            Console.WriteLine($"EL sueldo del empleado es: {sueldo}");
            Console.ReadKey();
        }
    }
}
