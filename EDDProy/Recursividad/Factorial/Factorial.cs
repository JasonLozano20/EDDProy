using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_recursividad
{
    class Factorial
    {
        public static int run(int number)
        {
            // Caso base: 0! = 1
            if (number == 0)
                return 1;
            else
                // Caso recursivo: n! = n * (n-1)!
                return number * run(number - 1);
        }
    }
}
