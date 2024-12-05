using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class Radix
    {
        // Método para ordenar un arreglo de enteros utilizando el algoritmo de ordenación Radix Sort
        public void Ordenar(int[] datos)
        {
            if (datos == null || datos.Length == 0)
            {
                throw new ArgumentException("El arreglo está vacío o es nulo, no se puede ordenar.");
            }
            // Separa los números positivos y negativos
            int[] positivos = Array.FindAll(datos, x => x >= 0);
            int[] negativos = Array.FindAll(datos, x => x < 0);
            // Ordena los números positivos
            RadixSortAlgorithm(positivos);
            // Ordena los números negativos en valor absoluto
            for (int i = 0; i < negativos.Length; i++)
            {
                negativos[i] = -negativos[i]; // Convierte a positivo para ordenación
            }
            RadixSortAlgorithm(negativos);
            for (int i = 0; i < negativos.Length; i++)
            {
                negativos[i] = -negativos[i]; // Vuelve a convertir a negativo
            }
            Array.Reverse(negativos); // Invierte el orden para los negativos
            // Fusiona negativos y positivos
            Array.Copy(negativos, 0, datos, 0, negativos.Length);
            Array.Copy(positivos, 0, datos, negativos.Length, positivos.Length);
        }
        // Método para implementar el algoritmo Radix Sort (para números positivos)
        private void RadixSortAlgorithm(int[] datos)
        {
            if (datos.Length == 0) return;
            int max = GetMax(datos); // Encuentra el valor máximo en el arreglo
            // Realiza la ordenación basada en cada dígito, aumentando la posición del dígito en cada iteración
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                OrdenarPorDigito(datos, exp);
            }
        }
        // Método para ordenar los datos en función de un dígito específico
        private void OrdenarPorDigito(int[] datos, int exp)
        {
            int n = datos.Length;
            // Realiza la ordenación utilizando un bucle de comparación
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int digitoActual = (datos[j] / exp) % 10;
                    int digitoSiguiente = (datos[j + 1] / exp) % 10;
                    if (digitoActual > digitoSiguiente)
                    {
                        Swap(ref datos[j], ref datos[j + 1]); // Intercambia los elementos
                    }
                }
            }
        }
        // Método para encontrar el valor máximo en un arreglo
        private int GetMax(int[] datos)
        {
            int max = datos[0];
            for (int i = 1; i < datos.Length; i++)
            {
                if (datos[i] > max)
                {
                    max = datos[i];
                }
            }
            return max;
        }
        // Método para intercambiar los datos de dos elementos
        private void Swap(ref int a, ref int b)
        {
            int temp = a; // Guarda el dato del primer elemento
            a = b;        // Asigna el dato del segundo elemento al primero
            b = temp;     // Asigna el dato guardado al segundo elemento
        }
    }
}

