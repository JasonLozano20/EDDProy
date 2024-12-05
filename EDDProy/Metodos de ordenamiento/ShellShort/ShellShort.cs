using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class ShellShort
    {
        // Método para ordenar un arreglo de enteros utilizando el algoritmo de ordenación ShellSort
        public void Ordenar(int[] datos)
        {
            if (datos == null || datos.Length == 0)
            {
                throw new ArgumentException("El arreglo está vacío o es nulo, no se puede ordenar.");
            }
            ShellSortAlgorithm(datos); // Llama al método que implementa ShellSort
        }
        // Método para implementar el algoritmo ShellSort
        private void ShellSortAlgorithm(int[] datos)
        {
            int n = datos.Length; // Longitud del arreglo
            // Inicia el gap (intervalo) y lo reduce en cada iteración
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Realiza la ordenación para cada intervalo
                for (int i = gap; i < n; i++)
                {
                    int temp = datos[i]; // Almacena el elemento actual
                    int j = i;
                    // Desplaza los elementos mayores al intervalo hacia adelante
                    while (j >= gap && datos[j - gap] > temp)
                    {
                        datos[j] = datos[j - gap]; // Intercambia los elementos
                        j -= gap; // Reduce el índice en el intervalo
                    }
                    datos[j] = temp; // Coloca el elemento en su posición correcta
                }
            }
        }
    }
}

