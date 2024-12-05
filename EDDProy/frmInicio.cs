using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algoritmos_recursividad;
using EDDemo.Hash;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_ordenamiento;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pila1.Form2 pila = new Pila1.Form2();
            pila.MdiParent = this;
            pila.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColaDinamica.Form1 cola=new ColaDinamica.Form1();
            cola.MdiParent = this;
            cola.Show();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaSimple.Form3 simple = new ListaSimple.Form3();
            simple.MdiParent = this;
            simple.Show();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDobleEnlazada.Form4 doble = new ListaDobleEnlazada.Form4();
            doble.MdiParent = this;
            doble.Show();
        }

        private void circularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Circular_SImple.Form5 circular= new Lista_Circular_SImple.Form5();
            circular.MdiParent = this;
            circular.Show();

        }

        private void circularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Circular_Doble.Form6 circularDoble = new Lista_Circular_Doble.Form6();
            circularDoble.MdiParent = this;
            circularDoble.Show();

        }

        

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecursividad Recursividad = new FormRecursividad();
            Recursividad.MdiParent = this;
            Recursividad.Show();
        }

        private void metodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMetodo metodo = new FormMetodo();
            metodo.MdiParent = this;
            metodo.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Hash = new Form1();
            Hash.MdiParent = this;
            Hash.Show();

        }
    }
}
