using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAsimov.Clases
{
    class Matriz
    {
        private int x { get; set; }
        private int y { get; set; }
        private int[,] mp { get; set; }
        private int[,] ms { get; set; }
        private bool[,] mb { get; set; }
        private int[] lineaX { get; set; }
        private int[] lineaY { get; set; }

        public Matriz(int x, int y)
        {
            this.x = x;
            this.y = y;
            crearmatriz();
        }

        private void crearmatriz()
        {
            ms = new int[x, y];
            mp = new int[x, y];
            mb = new bool[x.y];
            lineaX = new int[x];
            lineaY = new int[y];
        }

    }
}
