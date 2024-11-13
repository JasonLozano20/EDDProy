using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }
            else
            {
                b.AppendFormat("{0}->L{1} [side=L, style=\"invis\" label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("L{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }
            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            else
            {
                b.AppendFormat("{0}->R{1} [side=R, style=\"invis\" label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("R{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);

            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }
        // Metodo de busqueda
        public bool Busqueda(int Valor, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == Valor)
                return true;

            // Busca en el subarbol izquierdo o derecho
            if (Valor < nodo.Dato)
                return Busqueda(Valor, nodo.Izq);
            else
                return Busqueda(Valor, nodo.Der);
        }
        //Elimina todo los nodos del arbol
        public void PodarArbol()
        {
            PodarNodo(ref Raiz);
            //Se reinicia la raiz
            Raiz = null;
            strArbol = string.Empty;
            strRecorrido = string.Empty;
        }
        //Metodo recursivo que elimina todo los nodos desde las hojas hasta la raiz
        private void PodarNodo(ref NodoBinario nodo)
        {
            if (nodo == null) return;

            // Llamadas recursivas para podar subarboles izquierdos y derechos
            PodarNodo(ref nodo.Izq);
            PodarNodo(ref nodo.Der);

            
            nodo.Izq = null;
            nodo.Der = null;
            nodo = null;
        }
        //Metodo para eliminar un nodo en especifico
        public bool EliminarNodo(int dato)
        {
            NodoBinario padre = null;
            NodoBinario actual = Raiz;
            bool esHijoIzquierdo = false;

            //Si el arbol esta vacio 
            if (actual == null) 
                return false;

            // Busca el nodo a eliminar
            while (actual != null && actual.Dato != dato)
            {
                padre = actual;
                if (dato < actual.Dato)
                {
                    actual = actual.Izq;
                    esHijoIzquierdo = true;
                }
                else
                {
                    actual = actual.Der;
                    esHijoIzquierdo = false;
                }
            }

            // Si no se encontro el nodo
            if (actual == null) 
                return false;

            // Caso 1: Nodo es hoja 
            if (actual.Izq == null && actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = null;
                else if (esHijoIzquierdo)
                    padre.Izq = null;
                else
                    padre.Der = null;
            }
            // Caso 2: Nodo tiene un solo hijo
            else if (actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Izq;
                else if (esHijoIzquierdo)
                    padre.Izq = actual.Izq;
                else
                    padre.Der = actual.Izq;
            }
            else if (actual.Izq == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Der;
                else if (esHijoIzquierdo)
                    padre.Izq = actual.Der;
                else
                    padre.Der = actual.Der;
            }
            // Caso 3: Nodo tiene dos hijos
            else
            {
                NodoBinario sucesor = ObtenerSucesor(actual);
                if (actual == Raiz)
                    Raiz = sucesor;
                else if (esHijoIzquierdo)
                    padre.Izq = sucesor;
                else
                    padre.Der = sucesor;
                //Conecta el sucesor con el subarbol izquierdodel nodo eliminado
                sucesor.Izq = actual.Izq;
            }

            return true;
        }

        //Encuentra el nodo sucesor (menor del subarbol derecho)
        private NodoBinario ObtenerSucesor(NodoBinario nodoEliminar)
        {
            NodoBinario sucesorPadre = nodoEliminar;
            NodoBinario sucesor = nodoEliminar;
            NodoBinario actual = nodoEliminar.Der;
            //Busca el nodo mas pequeño del subarbol derecho
            while (actual != null)
            {
                sucesorPadre = sucesor;
                sucesor = actual;
                actual = actual.Izq;
            }

            if (sucesor != nodoEliminar.Der)
            {
                sucesorPadre.Izq = sucesor.Der;
                sucesor.Der = nodoEliminar.Der;
            }

            return sucesor;
        }
        //Metodo que realiza un recorrido por niveles y lo almacena en StrRecorrido
        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            if (nodo == null) return;

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodo);

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                strRecorrido += actual.Dato + ", ";

                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq);
                if (actual.Der != null)
                    cola.Enqueue(actual.Der);
            }
        }

        public int ObtenerAltura()
        {
            return CalcularAltura(Raiz);
        }
        //Calculamos la altura recursivamente 
        private int CalcularAltura(NodoBinario nodo)
        {
            if (nodo == null) 
                return 0;
                return 1 + Math.Max(CalcularAltura(nodo.Izq), CalcularAltura(nodo.Der));
        }
        //Cuenta el numero de hojas en el arbol
        public int ContarHojas()
        {
            return ContarHojasRecursivo(Raiz);
        }
        //Metodo recursivo para contar los nodos que no tienen hijos
        private int ContarHojasRecursivo(NodoBinario nodo)
        {
            if (nodo == null) 
                return 0;
            if (nodo.Izq == null && nodo.Der == null) 
                return 1;
                return ContarHojasRecursivo(nodo.Izq) + ContarHojasRecursivo(nodo.Der);
        }
        
        public int ContarNodos()
        {
            return ContarNodosRecursivo(Raiz);
        }
       
        private int ContarNodosRecursivo(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
                return 1 + ContarNodosRecursivo(nodo.Izq) + ContarNodosRecursivo(nodo.Der);
        }

        public bool EsArbolCompleto()
        {
            return EsArbolCompletoRecursivo(Raiz, 0, ContarNodos());
        }

        private bool EsArbolCompletoRecursivo(NodoBinario nodo, int index, int numeroNodos)
        {
            if (nodo == null) 
                return true;
            if (index >= numeroNodos) 
                return false;
                 return EsArbolCompletoRecursivo(nodo.Izq, 2 * index + 1, numeroNodos) &&
                   EsArbolCompletoRecursivo(nodo.Der, 2 * index + 2, numeroNodos);
        }
        public bool EsArbolLleno()
        {
            return EsArbolLlenoRecursivo(Raiz);
        }
        private bool EsArbolLlenoRecursivo(NodoBinario nodo)
        {
            if (nodo == null) 
                return true;
            if (nodo.Izq == null && nodo.Der == null) 
                return true;
            if (nodo.Izq != null && nodo.Der != null)
                return EsArbolLlenoRecursivo(nodo.Izq) && EsArbolLlenoRecursivo(nodo.Der);
                return false;
        }
    }
}
