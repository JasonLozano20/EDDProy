using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaDinamica
{
    internal class Nodo
    {
        public string Dato { get; set; } 
        public Nodo Siguiente { get; set; } 

        public Nodo(string dato)
        {
            Dato = dato;
            Siguiente = null; 
        }
    }
}
