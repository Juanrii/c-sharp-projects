using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Ejercicio 7 - Si 1Byte tiene 8 bits, desarrolle una solución programática que permita 
 * calcular cuántos bits hay en cualquier combinación de x KBytes. Explique cómo llegó a esa conclusión. 
 */

namespace TP1Consola_Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int bits;
            byte kbytes;

            Console.WriteLine("Ingrese la cantidad de Bytes: ");
            kbytes = Convert.ToByte(Console.ReadLine());

            /* Por regla de 3. Si 8 bits son 1 byte, n bits seran: (kbytes x 8 / 1 ) */
            bits = (kbytes * 8);

            Console.WriteLine($"Hay {bits} bits en {kbytes} bytes");
            Console.ReadKey();
        }
    }
}
