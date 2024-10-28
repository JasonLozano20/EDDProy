using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleEnlazada
{
    public partial class Form4 : Form
    {
        private ListaDoble lista;
        public Form4()
        {
            InitializeComponent();
            lista = new ListaDoble();
        }
        

        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor))
            {
                lista.InsertarInicio(valor);
                ActualizarLista();
                lblMensaje.Text = "Elemento insertado al inicio.";
                txtInput.Text = "";
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido.";
            }
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor))
            {
                lista.InsertarFinal(valor);
                ActualizarLista();
                lblMensaje.Text = "Elemento insertado al final.";
                txtInput.Text = "";
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido.";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor))
            {
                if (lista.Borrar(valor))
                {
                    ActualizarLista();
                    lblMensaje.Text = $"Elemento {valor} borrado.";
                }
                else
                {
                    lblMensaje.Text = $"Elemento {valor} no encontrado.";
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido.";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor))
            {
                Nodo nodoEncontrado = lista.Buscar(valor);
                if (nodoEncontrado != null)
                {
                    lblMensaje.Text = $"Elemento {valor} encontrado.";
                }
                else
                {
                    lblMensaje.Text = $"Elemento {valor} no encontrado.";
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido.";
            }
        }
        private void ActualizarLista()
        {
            listBoxElementos.Items.Clear();
            foreach (var elemento in lista.ObtenerElementos())
            {
                listBoxElementos.Items.Add(elemento);
            }
        }

        
    }
    
}
