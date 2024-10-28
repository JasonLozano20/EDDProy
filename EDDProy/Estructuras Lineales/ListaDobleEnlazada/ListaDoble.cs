using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    internal class ListaDoble
    {
        private Nodo cabeza;
        private Nodo cola;

        public ListaDoble()
        {
            cabeza = null;
            cola = null;
        }
        // Método para insertar al inicio
        public void InsertarInicio(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (cabeza == null) 
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = cabeza;
                cabeza.Anterior = nuevoNodo;
                cabeza = nuevoNodo;
            }
        }

        // Método para insertar al final
        public void InsertarFinal(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (cola == null) 
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = cola;
                cola = nuevoNodo;
            }
        }

        // Método para buscar un elemento
        public Nodo Buscar(int valor)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Valor == valor)
                {
                    return actual; 
                }
                actual = actual.Siguiente;
            }
            return null; 
        }

        // Método para borrar un elemento
        public bool Borrar(int valor)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Valor == valor)
                {
                    if (actual.Anterior != null) 
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                    }
                    else 
                    {
                        cabeza = actual.Siguiente;
                    }

                    if (actual.Siguiente != null) 
                    {
                        actual.Siguiente.Anterior = actual.Anterior;
                    }
                    else 
                    {
                        cola = actual.Anterior;
                    }
                    return true; 
                }
                actual = actual.Siguiente;
            }
            return false; 
        }

        // Método para obtener los elementos como un arreglo
        public int[] ObtenerElementos()
        {
            List<int> elementos = new List<int>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                elementos.Add(actual.Valor);
                actual = actual.Siguiente;
            }
            return elementos.ToArray();
        }
    }
}
