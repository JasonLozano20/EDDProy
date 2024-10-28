using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_recursividad
{
    class HanoiTower
    {
        // Método que resuelve el problema de las Torres de Hanoi
        public static void Hanoi(int numDiscos, char origen, char destino, char auxiliar, List<string> movimientos)
        {
            if (numDiscos == 1)
            {
                movimientos.Add($"Mover disco 1 de {origen} a {destino}");
                return;
            }

            int numDiscosAux = numDiscos / 2;
            int numDiscosRestantes = numDiscos - numDiscosAux;

            // Mover los discos más pequeños del origen al auxiliar
            for (int i = 1; i <= numDiscosAux; i++)
            {
                movimientos.Add($"Mover disco {i} de {origen} a {auxiliar}");
            }

            // Mover el disco más grande del origen al destino
            movimientos.Add($"Mover disco {numDiscos} de {origen} a {destino}");

            // Mover los discos más pequeños del auxiliar al destino
            for (int i = numDiscosAux; i >= 1; i--)
            {
                movimientos.Add($"Mover disco {i} de {auxiliar} a {destino}");
            }

            // Repetir el proceso para los discos restantes
            if (numDiscosRestantes > 0)
            {
                Hanoi(numDiscosRestantes, origen, auxiliar, destino, movimientos);
            }
        }
    }
}
