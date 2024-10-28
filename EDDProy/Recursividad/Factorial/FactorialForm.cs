using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FactorialForm : Form
    {
        public FactorialForm()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                int fact = int.Parse(number.Text);

                Stopwatch stopwatch = Stopwatch.StartNew();
                int result = Factorial.run(fact);
                stopwatch.Stop();
                labelResult.Text = "El resultado factorial de tu numero es: " + result.ToString(); 
                time.Text = "El tiempo de procesamiento fue de: " + stopwatch.ElapsedMilliseconds + " ms";
                complex.Text = "La complejidad del algoritmo fue de O (" + fact + ")";

            } catch
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            FormRecursividad recursivity = new FormRecursividad();
            recursivity.Show();

            this.Close();
        }
    }
}
