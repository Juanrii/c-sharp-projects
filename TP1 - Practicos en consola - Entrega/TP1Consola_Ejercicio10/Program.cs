using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Ejercicio 10 - Dada una frase cualquiera llamada x, mostrar como resultado una frase
    formada por la segunda mitad de x más la primer mitad de x. (usar el método substring) */


namespace TP1Consola_Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string x, parteA, parteB;

            Console.WriteLine("Ingrese una frase: ");
            x = Console.ReadLine();

            int mitad = x.Length / 2;

            // substring(desde, hasta)
            parteA = x.Substring(0, mitad);
            // desde la mitad hasta el final
            parteB = x.Substring(mitad);

            Console.WriteLine(parteB+parteA);
            Console.ReadKey();
        }
    }
}
