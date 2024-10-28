using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Circular_SImple
{
    public partial class Form5 : Form
    {
        private ListaCircular listaCircular = new ListaCircular();
        public Form5()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int posicion, dato;

            // Validar si los TextBoxes contienen números válidos
            if (int.TryParse(txtPosicion.Text, out posicion) && int.TryParse(txtDato.Text, out dato))
            {
                listaCircular.Insertar(posicion, dato);

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
            if (int.TryParse(txtPosicion.Text, out posicion))
            {
                int eliminado = listaCircular.Eliminar(posicion);

                if (eliminado != 0)
                {
                    MessageBox.Show($"Elemento eliminado: {eliminado}");
                    ActualizarLista(); // Actualizar la lista después de la eliminación
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, posición inválida");
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

            Nodo actual = listaCircular.Inicio;

            if (actual != null)
            {
                do
                {
                    // Agregar el dato del nodo al ListBox
                    listBoxDatos.Items.Add(actual.Dato);
                    actual = actual.Sig;
                    // Recorrer hasta que vuelva al inicio
                } while (actual != listaCircular.Inicio);
            }
        }
    }
}
