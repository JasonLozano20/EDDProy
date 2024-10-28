using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_recursividad
{
    class BusquedaBinaria
    {
        // Busca un elemento en un arreglo ordenado utilizando búsqueda binaria
        public static int Run(int[] array, int target, int low, int high)
        {
            // Caso base: rango de búsqueda vacío
            if (low > high)
                return -1;

            int mid = (low + high) / 2;

            // Si el elemento es encontrado, devuelve su índice
            if (array[mid] == target)
                return mid;
            // Si el elemento es menor que el elemento medio, busca en la mitad izquierda
            else if (array[mid] < target)
                return Run(array, target, mid + 1, high);
            // Si el elemento es mayor que el elemento medio, busca en la mitad derecha
            else
                return Run(array, target, low, mid - 1);
        }
    }
}
