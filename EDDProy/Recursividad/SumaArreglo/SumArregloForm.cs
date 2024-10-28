using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class SumArregloForm : Form
    {
        public SumArregloForm()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(arreglo.Text, out size))
            {
                ArrayElements arrayElements = new ArrayElements(size);
                arrayElements.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormRecursividad recursivity = new FormRecursividad();
            recursivity.Show();

            this.Close();
        }
    }
}
