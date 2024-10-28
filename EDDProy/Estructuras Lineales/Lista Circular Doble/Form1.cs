using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Circular_Doble
{
    public partial class Form6 : Form
    {
        private ListaCircularDoble
        listaCircularDoble = new ListaCircularDoble();
        public Form6()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int posicion, dato;

            // Validar si los TextBoxes contienen números válidos
            if (int.TryParse(txtPosicion.Text.Trim(), out posicion) && int.TryParse(txtDato.Text.Trim(), out dato))
            {
                listaCircularDoble.Insertar(posicion, dato);

                // Actualizar el ListBox
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion;

            // Validar si el TextBox de posición contiene un número válido
            if (int.TryParse(txtPosicion.Text.Trim(), out posicion))
            {
                int eliminado = listaCircularDoble.Eliminar(posicion);

                if (eliminado != 0)
                {
                    MessageBox.Show($"Elemento eliminado: {eliminado}");
                    ActualizarLista(); 
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, posición inválida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
            }
        }
        // Método para actualizar el ListBox con los elementos actuales de la lista circular
        private void ActualizarLista()
        {
            listBoxDatos.Items.Clear(); 

            Nodo actual = listaCircularDoble.Inicio;

            if (actual != null)
            {
                do
                {
                    // Agregar el dato del nodo al ListBox
                    listBoxDatos.Items.Add(actual.Dato); 
                    actual = actual.Sig;
                 // Recorrer hasta que vuelva al inicio
                } while (actual != listaCircularDoble.Inicio); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaCircularDoble = new ListaCircularDoble();
            listBoxDatos.Items.Clear ();
        }
    }
}
