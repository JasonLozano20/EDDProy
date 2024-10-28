using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class Search : Form
    {

        private int[] array;
        public Search(int[] array)
        {
            InitializeComponent();
            this.array = array;
        }

        private void SearchElement_Click(object sender, EventArgs e)
        {
            int target;
            if (int.TryParse(number.Text, out target))
            {
                // Realizar búsqueda binaria y mostrar resultados
                Array.Sort(array);
                Stopwatch stopwatch = Stopwatch.StartNew();
                int result = BusquedaBinaria.Run(array, target, 0, array.Length - 1);
                stopwatch.Stop();

                string message;
                if (result != -1)
                {
                    message = $"El elemento {target} se encuentra en la posición {result + 1}";
                }
                else
                {
                    message = $"El elemento {target} no se encuentra en el arreglo";
                }
                message += $"\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
                message += $"\nComplejidad: O(log n)";

                MessageBox.Show(message);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
