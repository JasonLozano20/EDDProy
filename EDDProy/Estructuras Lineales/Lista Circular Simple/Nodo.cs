using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_SImple
{
    internal class Nodo
    {
        // Dato almacenado en el nodo
        public int Dato { get; set; }
        // Puntero al siguiente nodo
        public Nodo Sig { get; set; }   

        public Nodo(int dato)
        {
            this.Dato = dato;
            this.Sig = null;
        }
    }
}
