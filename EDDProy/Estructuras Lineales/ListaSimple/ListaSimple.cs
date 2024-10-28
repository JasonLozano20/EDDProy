using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    internal class ListaSimple
    {
        private Nodo cabeza; 
        public ListaSimple()
        {
            cabeza = null; 
        }
        // Método para agregar un nodo al final de la lista
        public void Agregar(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevoNodo; 
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    // Avanza al último nodo
                    actual = actual.Siguiente; 
                }
                // Inserta el nuevo nodo al final
                actual.Siguiente = nuevoNodo; 
            }
        }
        // Método para eliminar un nodo con un valor específico
        public bool Eliminar(string dato)
        {
            // Si la lista está vacía, no se puede eliminar
            if (cabeza == null) 
                return false; 
            if (cabeza.Dato == dato)
            {
                // Si el nodo a eliminar es la cabeza
                cabeza = cabeza.Siguiente; 
                return true;
            }
            Nodo actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
            {
                // Busca el nodo anterior al que se va a eliminar
                actual = actual.Siguiente; 
            }
            if (actual.Siguiente != null)
            {
                // Salta el nodo a eliminar
                actual.Siguiente = actual.Siguiente.Siguiente; 
                return true;
            }
            return false; 
        }
        // Método para buscar un nodo en la lista
        public bool Buscar(string dato)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato == dato)
                    // Dato encontrado
                    return true; 
                actual = actual.Siguiente;
            }
            return false; 
        }
        // Método para verificar si la lista está vacía
        public bool EstaVacia()
        {
            return cabeza == null; 
        }
        // Método para obtener todos los elementos de la lista
        public List<string> ObtenerElementos()
        {
            List<string> elementos = new List<string>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                elementos.Add(actual.Dato); 
                actual = actual.Siguiente;
            }
            return elementos;
        }
    }
}
