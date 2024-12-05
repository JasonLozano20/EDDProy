using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EDDemo.Busqueda
{
    public partial class FrmHash: Form
    {
        private EDDemo.Hash.Hash hashTable; 
        public FrmHash()
        {
            InitializeComponent();
            hashTable = new EDDemo.Hash.Hash(); ;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDato.Text))
            {
                string resultado = hashTable.Buscar(txtDato.Text);
                if (resultado != null)
                {
                    MessageBox.Show($"Clave encontrada: {resultado}");
                }
                else
                {
                    MessageBox.Show("Clave no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una clave para buscar.");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            hashTable = new Hash.Hash();
            listDatos.Items.Clear();
            Random random = new Random();

            for (int i = 0; i < 10; i++) 
            {
                // Clave única: un número aleatorio del 1 al 100
                int clave = random.Next(1, 100);

                // Valor: Un dato relacionado con la clave
                string valor = $"Valor_{clave}";

                hashTable.Insertar(clave.ToString(), valor);
            }

            ActualizarListBox();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        hashTable.CargarDesdeArchivo(openFileDialog.FileName);
                        ActualizarListBox(); 
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"Error en el formato del archivo: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo.");
                }
            }
        }

        private void ActualizarListBox()
        {
            listDatos.Items.Clear();
            List<string> elementos = hashTable.ObtenerElementos();
            foreach (var elemento in elementos)
            {
                listDatos.Items.Add(elemento);
            }
        }
    }
}