using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_SImple
{
    internal class ListaCircular
    {
        public Nodo Inicio;
        public Nodo Fin;

        public ListaCircular()
        {
            Inicio = null;
            Fin = null;
        }

        // Función para insertar un nodo en una posición específica
        public void Insertar(int posicion, int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (Inicio == null && Fin == null) 
            {
                Inicio = nuevo;
                Fin = nuevo;
                nuevo.Sig = nuevo; 
            }
            else if (posicion == 0 || posicion == 1) 
            {
                nuevo.Sig = Inicio;
                Inicio = nuevo;
                Fin.Sig = Inicio; 
            }
            else 
            {
                int pos = 1;
                Nodo aux = Inicio;
                Nodo previo = null;

                // Avanzar hasta la posición deseada
                while (pos < posicion && aux.Sig != Inicio)
                {
                    previo = aux;
                    aux = aux.Sig;
                    pos++;
                }

                // Insertar el nuevo nodo en la posición encontrada
                if (aux != null)
                {
                    nuevo.Sig = aux;
                    if (previo != null)
                    {
                        previo.Sig = nuevo;
                    }
                }
            }
        }

        // Función para eliminar un nodo de una posición específica
        public int Eliminar(int posicion)
        {
            if (Inicio == null && Fin == null) 
            {
                return 0; 
            }

            int pos = 1;
            Nodo aux = Inicio;
            Nodo previo = null;

            // Avanzar hasta la posición deseada
            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
            }

            if (aux != null)
            {
                if (aux == Fin)
                {
                    Fin = previo;
                }

                if (previo != null)
                {
                    previo.Sig = aux.Sig;
                }
                else
                {
                    Inicio = aux.Sig;
                    Fin.Sig = Inicio;
                }
                // Regresa el dato eliminado
                return aux.Dato; 
            }

            return 0;  
        }
    }
}
