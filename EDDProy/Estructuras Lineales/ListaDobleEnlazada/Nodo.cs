using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    internal class Nodo
    {
        public int Valor { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Anterior = null;
            Siguiente = null;
        }
    }
}
