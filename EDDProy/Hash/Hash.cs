using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EDDemo.Busqueda

{
    public class Hash
    {
        private int tamanio;
        private List<KeyValuePair<string, string>>[] tabla;

        public Hash()
        {
            tamanio = 100;
            tabla = new List<KeyValuePair<string, string>>[tamanio];
            for (int i = 0; i < tamanio; i++)
            {
                tabla[i] = new List<KeyValuePair<string, string>>();
            }
        }

        private double CalcularCarga()
        {
            int elementosTotales = tabla.Sum(lista => lista.Count);
            return (double)elementosTotales / tamanio;
        }

        private void Redimensionar()
        {
            int nuevoTamanio = tamanio * 2;
            var nuevaTabla = new List<KeyValuePair<string, string>>[nuevoTamanio];

            for (int i = 0; i < nuevoTamanio; i++)
            {
                nuevaTabla[i] = new List<KeyValuePair<string, string>>();
            }

            foreach (var lista in tabla)
            {
                foreach (var par in lista)
                {
                    int nuevoIndice = FuncionHashAvanzada((uint)par.Key.GetHashCode()) % nuevoTamanio;
                    nuevaTabla[nuevoIndice].Add(par);
                }
            }

            tabla = nuevaTabla; // Actualizar referencia a la nueva tabla
            tamanio = nuevoTamanio; // Actualizar tamaño (¡esto debería funcionar!)
        }

        private int FuncionHashAvanzada(uint clave)
        {
            const int primo = 31;
            const uint mezclaBits = 0x9E3779B9;
            uint hash = clave;

            hash ^= (hash >> 16);
            hash *= mezclaBits;
            hash ^= (hash >> 13);
            hash *= primo;
            hash ^= (hash >> 16);

            return (int)(Math.Abs(hash) % tamanio);
        }

        public void Insertar(string clave, string valor)
        {
            if (CalcularCarga() > 0.7)
            {
                Redimensionar(); // Redimensionar si la carga es alta
            }

            int indice = FuncionHashAvanzada((uint)clave.GetHashCode());
            int contador = 0;

            foreach (var par in tabla[indice])
            {
                if (par.Key.StartsWith(clave))
                {
                    contador++;
                }
            }

            if (contador > 0)
            {
                clave += $".{contador}";
            }

            tabla[indice].Add(new KeyValuePair<string, string>(clave, valor));
        }

        public string Buscar(string clave)
        {
            int indice = FuncionHashAvanzada((uint)clave.GetHashCode());
            foreach (var par in tabla[indice])
            {
                if (par.Key == clave)
                {
                    return par.Value;
                }
            }
            return null;
        }

        public List<string> ObtenerElementos()
        {
            List<string> elementos = new List<string>();
            foreach (var lista in tabla)
            {
                foreach (var par in lista)
                {
                    elementos.Add($"{par.Key}: {par.Value}");
                }
            }
            return elementos;
        }
        public void CargarDesdeArchivo(string ruta)
        { 
            
            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            try
            {
                var lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    MessageBox.Show($"Procesando línea: {linea}");
                    var partes = linea.Split(',');
                    if (partes.Length == 2)
                    {
                        string clave = partes[0].Trim();
                        string valor = partes[1].Trim();
                        Insertar(clave, valor);
                    }
                    else
                    {
                        MessageBox.Show("Formato incorrecto en línea: " + linea);
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
