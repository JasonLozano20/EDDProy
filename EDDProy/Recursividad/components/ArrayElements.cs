using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class ArrayElements : Form
    {

        private int[] array;
        private int currentIndex;
        public ArrayElements(int size)
        {
            InitializeComponent();
            array = new int[size];
            currentIndex = 0;
        }

        private void AddElement_Click(object sender, EventArgs e)
        {
            int element;
            if (int.TryParse(number.Text, out element))
            {
                array[currentIndex] = element;
                currentIndex++;

                if (currentIndex < array.Length)
                {
                    number.Text = string.Empty;
                    number.Focus();
                }
                else
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    int result = ArraySum.Run(array);
                    stopwatch.Stop();

                    string message;
                   
                    message = $"La suma de los elementos del arrglo es de {result}";
                    message += $"\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
                    message += $"\nComplejidad: O({array.Length})";

                    MessageBox.Show(message);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
