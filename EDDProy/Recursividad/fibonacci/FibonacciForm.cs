using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FibonacciForm : Form
    {
        public FibonacciForm()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int fib = int.Parse(number.Text);

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = Factorial.run(fib);
            stopwatch.Stop();


            string message;

            message = $"El número de Fibonacci en la posición {fib} es: {result}";
            message +=$"\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
            message += $"\nComplejidad: O (2^n)";

            MessageBox.Show(message);
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            FormRecursividad recursivity = new FormRecursividad();
            recursivity.Show();

            this.Close();
        }
    }
}
