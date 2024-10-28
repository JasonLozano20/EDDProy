using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo;

namespace Pila1
{
    public partial class Form2 : Form
    {
        Pila MiPila = new Pila();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                Nodo NuevoNodo = new Nodo();
                NuevoNodo.Dato = txtDato.Text;
                txtDato.Clear();

                MiPila.Push(NuevoNodo);
                MostrarPila();
            }
            else
            {
                MessageBox.Show("Ingresa un valor para apiilar");
            }

        }
        void MostrarPila()
        {

            listPila.Items.Clear();
            if (MiPila.Tope() != null)
            {
                MostrarNodoEnLista(MiPila.Tope());
            }

        }
        void MostrarNodoEnLista(Nodo dato)
        {
            listPila.Items.Add(dato.Dato);
            if (dato.Siguiente != null)
            {
                MostrarNodoEnLista(dato.Siguiente);
            }

        }
        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            MiPila.Pop();
            MostrarPila();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            MiPila = new Pila();
            listPila.Items.Clear();
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            string graphVizString;
            Nodo tope = MiPila.Tope();
            if (tope == null)
            {
                MessageBox.Show("La pila esta vacia");
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            sb.Append(MiPila.ToDot(tope));
            sb.Append("{");
            graphVizString = sb.ToString();
            Bitmap bm = FileDotEngine.Run(graphVizString);

            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();

        }
    }
}
