using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 15 - Informar cuantos días faltan para el 25/12/2023


namespace TP1Consola_Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime targetDate = new DateTime(2023, 12, 25);

            int dias = (int)(targetDate - today).TotalDays;

            Console.WriteLine($"Faltan {dias} dias para la fecha {targetDate.ToString("yyyy-MM-dd")}");
            Console.ReadKey();
        }
    }
}
