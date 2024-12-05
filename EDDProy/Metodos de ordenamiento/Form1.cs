using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class FormMetodo : System.Windows.Forms.Form
    {
        public FormMetodo()
        {

            InitializeComponent();

        }
        private void FormMetodo_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearList_Click(object sender, EventArgs e)
        {
           if(numericUpDown1.Value == 0)
            {
                MessageBox.Show("Por favor ingrese un valor mayor a 0, para generar una lista");
            }
           
            txtLista.Text = ",";
            lblQuickSort.Text = "";
            lblShellSort.Text = " ";
            lblRadix.Text = " ";
            lblBurbuja.Text = " ";  
            int CantidadElementos = (int)numericUpDown1.Value;
            // Creamos una lista para almacenar los numeros aleatorios
            List<int> ListaEnteros = new List<int>();
            Random rnd = new Random();  
            for(int i = 0; i < CantidadElementos; i++)
            {
                ListaEnteros.Add(rnd.Next(-50,100));
            }
            txtLista.Text = string.Join(",  ", ListaEnteros);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("La lista esta vacia");
                return;
            }
            
            try
            {
                int[] datos = txtLista.Text
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x.Trim()))
                .ToArray();

                QuickSort qs = new QuickSort();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                qs.QuickSortAlgorithm(datos, 0, datos.Length - 1);          
                lblQuickSort.Text = " " + string.Join(", ", datos);
                sw.Stop();
                time.Text = "Tiempo: " + sw.Elapsed.TotalMilliseconds+ " ms";

                ShellShort ss = new ShellShort();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                ss.Ordenar(datos);
                lblShellSort.Text = " "+ string.Join(", ", datos);
                stopwatch.Stop();
                time1.Text = "Tiempo: " + stopwatch.Elapsed.TotalMilliseconds+ " ms";

                Radix radix = new Radix();
                Stopwatch stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                radix.Ordenar(datos);
                lblRadix.Text = " "+ string.Join(", ",datos);
                stopwatch1.Stop();
                time2.Text = "Tiempo: "+ stopwatch1.Elapsed.TotalMilliseconds + " ms";

                Burbuja burbuja = new Burbuja();
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                burbuja.Ordenar(datos);
                lblBurbuja.Text = " " + string.Join(", ", datos);
                stopwatch2.Stop();
                time3.Text = "Tiempo: "+ stopwatch2.Elapsed.TotalMilliseconds + " ms";
            }

            catch (FormatException)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblQuickSort.Text))
            {
                MessageBox.Show("Primero ordena la lista para buscar un valor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                MessageBox.Show("Ingresa un valor para buscar.");
                return;
            }

            try
            {
                
                // Convertimos la lista ordenada del Label a un arreglo de enteros
                int[] listaOrdenada = lblQuickSort.Text
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();
                Stopwatch stp = new Stopwatch();
                stp.Start();
                int valorABuscar = int.Parse(txtBox.Text.Trim());

                // Buscar el índice del valor
                int posicion = Array.IndexOf(listaOrdenada, valorABuscar);

                if (posicion >= 0)
                {
                    lblResultado.Text = $"Valor {valorABuscar} encontrado en la posición {posicion + 1}.";
                }
                else
                {
                    lblResultado.Text = $"Valor {valorABuscar} no encontrado.";
                }
                stp.Stop();
                TimeBusqueda.Text = "Tiempo de busqueda: " + stp.ElapsedMilliseconds + " ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un número válido.");
            }
        }
    }
}
