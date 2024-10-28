using System;

namespace Algoritmos_recursividad
{
    class ArraySum
    {
        // Método que suma los elementos de un arreglo
        public static int Run(int[] array)
        {
            // Inicializamos la variable que almacenará la suma
            int sum = 0;

            // Iteramos sobre cada elemento del arreglo
            for (int i = 0; i < array.Length; i++)
            {
                // Sumamos el elemento actual al resultado final
                sum += array[i];
            }

            // Devolvemos la suma final
            return sum;
        }
    }
}
