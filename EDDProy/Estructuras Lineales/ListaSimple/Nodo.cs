using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    internal class Nodo
    {
        // El dato almacenado en el nodo
        public string Dato { get; set; }
        // Puntero al siguiente nodo
        public Nodo Siguiente { get; set; } 

        public Nodo(string dato)
        {
            Dato = dato;
            Siguiente = null; 
        }
    }
}
