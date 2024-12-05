using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class Burbuja
    {
        // Método para ordenar un arreglo de enteros utilizando el algoritmo de ordenación Burbuja
        public void Ordenar(int[] datos)
        {
            if (datos == null || datos.Length == 0)
            {
                throw new ArgumentException("El arreglo está vacío o es nulo, no se puede ordenar.");
            }
            bool swaped; // Variable para verificar si se realizaron intercambios
            int n = datos.Length; // Longitud del arreglo
            // Bucle para recorrer el arreglo
            do
            {
                swaped = false; // Inicializa la variable en false
                // Recorre el arreglo hasta el penúltimo elemento
                for (int i = 0; i < n - 1; i++)
                {
                    // Compara el elemento actual con el siguiente
                    if (datos[i] > datos[i + 1])
                    {
                        // Si el elemento actual es mayor que el siguiente, intercambia los datos
                        Swap(ref datos[i], ref datos[i + 1]);
                        swaped = true; // Marca que se ha realizado un intercambio
                    }
                }
                n--; // Reduce el tamaño del arreglo a revisar, ya que el último elemento está en su lugar
            } while (swaped); // Repite mientras se realicen intercambios
        }
        // Método para intercambiar los datos de dos elementos
        private void Swap(ref int a, ref int b)
        {
            int temp = a; // Guarda el dato del primer elemento
            a = b;        // Asigna el dato del segundo elemento al primero
            b = temp;    // Asigna el dato guardado al segundo elemento
        }
    }
}
