using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            Console.Write("Ingrese el valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de c: ");
            c = double.Parse(Console.ReadLine());
            d = b * b - 4.0 * a * c;

            if (b >= 0)
            {
                //Math.Sqrt es prte de la libreria el cual nos permite  obtener la raiz cuadrada

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Valor de discriminante: " + d);
                Console.WriteLine("Valor de x1: " + x1);
                Console.WriteLine("Valor de x2: " + x2);
            }
            else
            {
                Console.WriteLine("la solucion es imaginaria");
            }
            Console.ReadKey();
        }
    }
}
