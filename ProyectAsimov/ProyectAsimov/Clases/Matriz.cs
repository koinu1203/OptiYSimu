using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAsimov.Clases
{
    class Matriz
    {
        public int x { get; set; }
        public int y { get; set; }
        public int[,] mp { get; set; } //matriz primaria 
        public int[] lineaX { get; set; }
        public int[] lineaY { get; set; }

        public Matriz(int[,] mp, int[] lX, int[] lY)
        {
            paso1(lX,lY);
            this.mp=copiarmatriz(mp);

        }
        private int[] copiarvector(int n,int[] v)
        {
            int[] temp;
            temp = new int[n];
            for(int i = 0; i < n; i++)
            {
                if (i<v.Length)
                {
                    temp[i] = v[i];
                }
                else
                {
                    temp[i] = 0;
                }
            }
            return temp; 
        }
        private int[,] copiarmatriz(int[,] m_copy)
        {
            int[,] temp = new int[x, y];
            for(int fila = 0; fila < x; fila++)
            {
                for (int col = 0; col < y; col++)
                {
                    if (fila < m_copy.GetLength(0) && col<m_copy.GetLength(1))
                    {
                        temp[fila, col] = m_copy[fila, col];
                    }
                    else
                    {
                        temp[fila, col] = 0;
                    }
                }
            }
            return temp;
        }
        private int sumavector(int[] s)
        {
            int sum = 0;
            for(int i = 0; i < s.Length; i++)
            {
                sum = sum + s[i];
            }
            return sum;
        }
        private void paso1(int[] lX,int[] lY)
        {
            if (sumavector(lX) == sumavector(lY))
            {
                x = lX.Length;
                y = lY.Length;
            }
            else
            {
                if(sumavector(lX) > sumavector(lY))
                {
                    x = lX.Length;
                    y = lY.Length+1;
                }
                else
                {
                    x = lX.Length+1;
                    y = lY.Length;
                }
            }
            lineaX = copiarvector(x, lX);
            lineaY = copiarvector(y, lY);
        }
        public void leerMatriz(int[,] w)
        {
            for(int i=0; i < x; i++)
            {
                for(int s=0; s < y; s++)
                {
                    Console.WriteLine(w[i,s].ToString() + " ");
                }
                Console.WriteLine('\n');
            }
        }
    }
}
