using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_Doble
{
    internal class Nodo
    {
        // Dato del nodo
        public int Dato { get; set; }
        // Puntero al siguiente nodo
        public Nodo Sig { get; set; }
        // Puntero al nodo anterior
        public Nodo Prev { get; set; }    

        public Nodo(int dato)
        {
            Dato = dato;
            Sig = null;
            Prev = null;
        }
    }
}
