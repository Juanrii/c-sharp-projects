using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 3 - Dados los lados de un triangulo calcular el perímetro.

namespace TP1Consola_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float perimetro;
            int opcion;

            MostrarMenu();
            opcion = Convert.ToInt32(Console.ReadLine());

            while(opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opcion incorrecta, vuelva a seleccionar una opcion valida");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

            perimetro = CalcularPerimetro(opcion);

            Console.WriteLine($"El perimetro es: {perimetro}");
            Console.ReadKey();
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("Seleccione el triangulo que desea calcular (1 - 3)");
            Console.WriteLine("1) - Triangulo Equilatero\n2) - Triangulo Isosceles\n3) - Triangulo Escaleno");
        }

        private static float CalcularPerimetro(int opcion)
        {
            float perimetro = 0;
            float l1, l2, l3;
            switch (opcion)
            {
                case 1:
                    /* Equilatero: Todos los lados son iguales */
                    Console.WriteLine("Ingrese el lado del triangulo Equilatero: ");
                    l1 = float.Parse(Console.ReadLine());
                    perimetro = 3 * l1;
                    break;
                case 2:
                    /* Isosceles: 2 lados iguales y la base */
                    Console.WriteLine("Ingrese el valor la base del triangulo Isosceles: ");
                    l1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese uno de los lados iguales del triangulo Isosceles: ");
                    l2 = float.Parse(Console.ReadLine());
                    perimetro = 2 * l2 + l1;
                    break;
                case 3:
                    /* Escaleno: 3 lados distintos */
                    Console.WriteLine("Ingrese el primer lado del triangulo Escaleno: ");
                    l1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo lado del triangulo Escaleno: ");
                    l2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tercer lado del triangulo Escaleno: ");
                    l3 = float.Parse(Console.ReadLine());
                    perimetro = l1 + l2 + l3;
                    break;
                default:
                    Console.WriteLine("Error inesperado. Posible opcion invalida.");
                        break;
            }
            return perimetro;
        }
    }
}
