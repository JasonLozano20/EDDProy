using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    public partial class Form3 : Form
    {
        private ListaSimple lista; 

        public Form3()
        {
            InitializeComponent();
            lista = new ListaSimple();
        }
        // Método para actualizar el ListBox con los elementos actuales de la lista
        private void ActualizarLista()
        {
            // Limpia el ListBox
            listBoxLista.Items.Clear(); 
            foreach (var item in lista.ObtenerElementos())
            {
                // Añade los elementos al ListBox
                listBoxLista.Items.Add(item); 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                // Agregar el dato a la lista
                lista.Agregar(txtInput.Text); 
                txtInput.Clear();
                ActualizarLista(); 
            }
            else
            {
                MessageBox.Show("Ingresa un valor para agregar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                // Eliminar el dato de la lista
                lista.Eliminar(txtInput.Text); 
                txtInput.Clear();
                ActualizarLista(); 
            }
            else
            {
                MessageBox.Show("Ingresa un valor para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                // Buscar el dato en la lista
                bool encontrado = lista.Buscar(txtInput.Text); 
                if (encontrado)
                {
                    MessageBox.Show("El dato fue encontrado en la lista.");
                }
                else
                {
                    MessageBox.Show("El dato no se encuentra en la lista.");
                }
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Ingresa un valor para buscar.");
            }

        }
    }
}
