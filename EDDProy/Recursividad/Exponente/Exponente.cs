using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_recursividad
{
    class Exponente
    {
        public static void RunTest()
        {
            Console.Write("Ingrese la base: ");
            int @base = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el exponente: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = Run(@base, exponent);
            stopwatch.Stop();

            Console.WriteLine($"El resultado de {@base} elevado a {exponent} es {result}");
            Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Complejidad: O({exponent})");
        }

        // Calcula el exponente de un número utilizando recursión
        public static int Run(int @base, int exponent)
        {
            // Caso base: 0^x = 1
            if (exponent == 0)
                return 1;
            else
                // Caso recursivo: x^n = x * x^(n-1)
                return @base * Run(@base, exponent - 1);
        }
    }
}
