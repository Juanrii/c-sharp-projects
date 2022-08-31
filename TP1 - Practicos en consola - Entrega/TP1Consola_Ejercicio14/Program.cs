using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 14 - Dadas dos fechas calcular la diferencia en días entre una y la otra.

namespace TP1Consola_Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            // seteo la fecha actual
            DateTime currentDate = DateTime.Now;
            // creo otra fecha
            DateTime date = new DateTime(2022,8,1);
            
            // guardo la diferencia de dias
            int diff = (int) (currentDate - date).TotalDays;

            // mostrar los resultados
            Console.WriteLine($"La diferencia entre {currentDate.ToString("yyyy-MM-dd")} y {date.ToString("yyyy-MM-dd")} es de: {diff} dias");
            
            Console.ReadKey();
        }
    }
}
