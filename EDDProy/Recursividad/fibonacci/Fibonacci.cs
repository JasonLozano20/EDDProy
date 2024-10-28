using System;
using System.Diagnostics;

namespace Algoritmos_recursividad
{
    class Fibonacci
    {
        // Calcula el número de Fibonacci utilizando recursión
        public static int Run(int n)
        {
            // Caso base: si 'n' es 0 o 1, devuelve el valor directamente
            if (n == 0 || n == 1)
            {
                return n;
            }
            // Llamada recursiva para calcular el número de Fibonacci en la posición 'n-1' y 'n-2'
            else
            {
                return Run(n - 1) + Run(n - 2);
            }
        }
    }
}
