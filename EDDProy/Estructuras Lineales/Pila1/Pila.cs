using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace Pila1
{
    internal class Pila
    {
        Nodo tope;

        public Nodo Tope()
        {
            return tope;
        }
        public string ToDot(Nodo tope)
        {
            StringBuilder b = new StringBuilder();
            Nodo aux = tope;
            while (aux != null)
            {
                if(aux.Siguiente != null)
                {
                    b.AppendFormat("{0} -> {1};{2}", aux.Dato.ToString(), aux.Siguiente.Dato.ToString(), Environment.NewLine);
                }
                aux=aux.Siguiente;
            }
            return b.ToString();
        }
        //Metodo para insertar un elemento
        public void Push(Nodo dato)
        {
            
            if (tope == null)
            {
                tope = dato;
            }
            else
            {
                Nodo Aux = tope;
                tope = dato;
                tope.Siguiente = Aux;
            }
        }
        //Metodo para Eliminar un elemnto
        public void Pop()
        {
            if (tope != null)
            {
                tope = tope.Siguiente;
            }

        }
        public bool EstaVacia()
        {
            return tope == null;
        }
    }
}
