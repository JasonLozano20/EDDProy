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

namespace ColaDinamica
{
    public partial class Form1 : Form
    {
        private Cola cola; 

        public Form1()
        {
            InitializeComponent();
            // Inicializa la cola
            cola = new Cola(); 
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                cola.Encolar(txtInput.Text); 
                txtInput.Clear();
                ActualizarLista();
                lblPeek.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa un valor para encolar.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (!cola.EstaVacia())
            {
                cola.Desencolar(); 
                ActualizarLista(); 
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (!cola.EstaVacia())
            {
                // Muestra el primer elemento
                lblPeek.Text = "Elemento en frente: " + cola.VerFrente(); 
            }
            else
            {
                lblPeek.Text = "La cola está vacía.";
            }
        }
        private void ActualizarLista()
        {
            listBoxCola.Items.Clear(); 
            foreach (var item in cola.ObtenerElementos())
            {
                listBoxCola.Items.Add(item); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cola = new Cola(); 
            ActualizarLista(); 
            lblPeek.Text = "La cola está vacía."; 
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            string graphVizString;
            Nodo inicio = cola.ObtenerInicio();
            if (inicio == null)
            {
                MessageBox.Show("La cola esta vacia");
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("digraph G { node [shape=\"box\"]; " + Environment.NewLine);
            sb.Append(cola.ToDot(inicio));
            sb.Append("}");
            graphVizString = sb.ToString();
            Bitmap bm = FileDotEngine.Run(graphVizString);

            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();

        }
    }
    
}
