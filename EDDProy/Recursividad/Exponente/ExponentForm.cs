using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class ExponentForm : Form
    {
        public ExponentForm()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(number.Text);
                int exp = int.Parse(number2.Text);

                Stopwatch stopwatch = Stopwatch.StartNew();
                int result = Exponente.Run(num, exp);
                stopwatch.Stop();
                labelResult.Text = "El resultado factorial de tu numero es: " + result.ToString();
                time.Text = "El tiempo de procesamiento fue de: " + stopwatch.ElapsedMilliseconds + " ms";
                complex.Text = "La complejidad del algoritmo fue de O (" + exp + ")";

            }
            catch
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
