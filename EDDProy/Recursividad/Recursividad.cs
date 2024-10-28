using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FormRecursividad : Form
    {
        public FormRecursividad()
        {
            InitializeComponent();
        }

        private void ShowForm<T>() where T : Form, new()
        {
            T form = new T();
            form.Show();
            this.Hide();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            ShowForm<FactorialForm>();
        }

        private void Exponent_Click(object sender, EventArgs e)
        {
            ShowForm<ExponentForm>();
        }

        private void SumArray_Click(object sender, EventArgs e)
        {
            ShowForm<SumArregloForm>();
        }

        private void Fibonacci_Click(object sender, EventArgs e)
        {
            ShowForm<FibonacciForm>();
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            ShowForm<BusquedaBinariaForm>();
        }

        private void HanoiTower_Click(object sender, EventArgs e)
        {
            ShowForm<HanoiForm>();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}