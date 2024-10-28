using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ColaDinamica
{
    internal class Cola
    {
        private Nodo inicio; 
        private Nodo final;  

        public Cola()
        {
            inicio = null;
            final = null;
        }

        // Método para agregar un elemento al final de la cola
        public void Encolar(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (final == null) 
            {
                inicio = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                // Enlaza el nuevo nodo al final
                final.Siguiente = nuevoNodo; 
                final = nuevoNodo; 
            }
        }

        // Método para eliminar el primer nodo de la cola
        public string Desencolar()
        {
            if (inicio == null) 
            {
                return null; 
            }
            // Guarda el dato del nodo que se va a desencolar
            string dato = inicio.Dato;
            // El siguiente nodo se convierte en el frente
            inicio = inicio.Siguiente; 

            if (inicio == null) 
            {
                final = null; 
            }
            return dato; 
        }
        
        // Método para ver el primer elemento sin eliminarlo
        public string VerFrente()
        {
            if (inicio == null)
            {
                return null; 
            }

            return inicio.Dato; 
        }

        // Método para verificar si la cola está vacía
        public bool EstaVacia()
        {
            return inicio == null; 
        }

        // Método para obtener todos los elementos de la cola
        public List<string> ObtenerElementos()
        {
            List<string> elementos = new List<string>();
            Nodo actual = inicio;
            while (actual != null)
            {
                // Añade el dato del nodo a la lista
                elementos.Add(actual.Dato); 
                actual = actual.Siguiente; 
            }
            return elementos;
        }
        public string ToDot(Nodo inico)
        {
            StringBuilder b = new StringBuilder();
            Nodo actual = inicio;
                while(actual != null)
            {
                if(actual.Siguiente != null)
                {
                    b.AppendFormat("{0} -> {1};{2}", actual.Dato.ToString(), actual.Siguiente.Dato.ToString(), Environment.NewLine);
                }
                actual = actual.Siguiente;
            }
                return b.ToString();
        }
        public Nodo ObtenerInicio()
        {
            return inicio;
        }
    }
}
