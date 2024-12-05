using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class QuickSort
    {
        //Metodo que realiza el ordenamiento del arreglo
        public  void QuickSortAlgorithm(int[] datos, int menor, int mayor)
        {
            //Condicion de salida para la recursion
            if (menor < mayor)
            {
                //Obtenemos el indice del pivote despues de la particion
                int pivote = Particion(datos, menor, mayor);

                //Llama recursivamente a Quicksort(parte izquierda del pivote)
                QuickSortAlgorithm(datos, menor, pivote - 1);

                //Llama recursivamente a Quicksort(parte derecha del pivote)
                QuickSortAlgorithm(datos, pivote + 1, mayor);
            }

        }
        //Metodo para reorganizar los elementos en relacion al pivote
       public static int Particion(int[] datos, int menor, int mayor)
        {
            //Selecciona el ultimo elemento como pivote
            int pivote = datos[mayor];
            int i = menor - 1;
            // Recorre la porcion del arreglo desde "menor" hasta "mayor - 1"
            for (int j = menor; j < mayor; j++)
            {
                //Si el elemento actual es menor que el pivote
                if (datos[j] < pivote)
                {
                    i++;
                    //Intercambia el elemento actual con el elemento en índice "i"
                    Swap(datos, i, j);
                }
            }
            Swap(datos, i + 1, mayor);
            return i + 1;
        }
        // Método Swap: intercambia dos elementos en el arreglo
        public static void Swap(int[] datos, int i, int j)
        {
            //Guarda temporalmente el valor de datos[i]
            int temp = datos[i];
            datos[i] = datos[j];
            datos[j] = temp;
        }
        
    }
}
