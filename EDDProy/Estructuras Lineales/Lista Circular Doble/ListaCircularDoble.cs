using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_Doble
{
    internal class ListaCircularDoble
    {
        public Nodo Inicio { get; set; } 
        public Nodo Fin { get; set; }    

        public ListaCircularDoble()
        {
            Inicio = null;
            Fin = null;
        }

        // Funcion para insertar un nodo en una posición especifica
        public void Insertar(int posicion, int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                nuevo.Sig = nuevo;
                nuevo.Prev = nuevo;
            }
            // Insertar al inicio
            else if (posicion == 0 || posicion == 1)
            {
                nuevo.Sig = Inicio;
                nuevo.Prev = Fin;
                Inicio.Prev = nuevo;
                Fin.Sig = nuevo;
                Inicio = nuevo;
            }
            // Insertar en cualquier otra posicion
            else 
            {
                int pos = 1;
                Nodo aux = Inicio;
                while (pos < posicion && aux.Sig != Inicio)
                {
                    aux = aux.Sig;
                    pos++;
                }

                if (aux != null)
                {
                    nuevo.Sig = aux;
                    nuevo.Prev = aux.Prev;
                    aux.Prev.Sig = nuevo;
                    aux.Prev = nuevo;
                }
            }
        }

        // Función para eliminar un nodo de una posición especifica
        public int Eliminar(int posicion)
        {
            if (Inicio == null && Fin == null) 
            {
                return 0;  
            }

            int pos = 1;
            Nodo aux = Inicio;
            while (pos < posicion && aux.Sig != Inicio)
            {
                aux = aux.Sig;
                pos++;
            }

            if (aux != null)
            {
                if (aux == Inicio && aux == Fin) 
                {
                    Inicio = null;
                    Fin = null;
                }
                else if (aux == Inicio) 
                {
                    Inicio = aux.Sig;
                    Fin.Sig = Inicio;
                    Inicio.Prev = Fin;
                }
                else if (aux == Fin) 
                {
                    Fin = aux.Prev;
                    Fin.Sig = Inicio;
                    Inicio.Prev = Fin;
                }
                else 
                {
                    aux.Prev.Sig = aux.Sig;
                    aux.Sig.Prev = aux.Prev;
                }

                return aux.Dato; 
            }

            return 0; 
        }
    }
}
