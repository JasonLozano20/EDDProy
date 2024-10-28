using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class HanoiForm : Form
    {
        public HanoiForm()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int numDiscos = (int)diskNumeric.Value;
            char origen = 'A';
            char destino = 'C';
            char auxiliar = 'B';

            Stopwatch stopwatch = Stopwatch.StartNew();
            List<string> movimientos = new List<string>();
            HanoiTower.Hanoi(numDiscos, origen, destino, auxiliar, movimientos);
            stopwatch.Stop();

            Movimientos.Items.Clear();
            foreach (string movimiento in movimientos)
            {
                Movimientos.Items.Add(movimiento);
                time.Text = "El tiempo de procesamiento: " + stopwatch.ElapsedMilliseconds + " ms";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            FormRecursividad recursivity = new FormRecursividad();
            recursivity.Show();

            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Movimientos.Items.Clear();
        }

        private void HanoiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
