using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAsimov.Clases
{
    class M_Eno
    {
       public Matriz m;
        public bool[,] mb; //matriz booleana
        public int[,] ms; //matriz secundaria

        public M_Eno(Matriz m)
        {

            this.m = m;
            mb = new bool[m.x,m.y];
            ms = new int[m.x, m.y];
            enoPaso1();
        }

        private void enoPaso1()
        {
            int sX = 0, sY = 0;
            int[] tempX = m.lineaX;
            int[] tempY = m.lineaY;
            for (int i = 1; i < m.x + m.y; i++)
            {
                if (tempX[sX] == tempY[sY])
                {
                    ms[sX, sY] = tempX[sX];
                    mb[sX, sY] = true;
                    tempX[sX] = 0;
                    tempY[sY] = 0;
                    if(i+1!= m.x + m.y)
                    {
                        sX++;
                        i++;
                        ms[sX, sY] = 0;
                        mb[sX, sY] = true;
                        sY++;
                    }
                }
                else
                {
                    if(tempX[sX] > tempY[sY])
                    {
                        ms[sX, sY] = tempY[sY];
                        mb[sX, sY] = true;
                        tempX[sX] = tempX[sX]-tempY[sY];
                        tempY[sY] = 0;
                        sY++;
                    }
                    else
                    {
                        ms[sX, sY] = tempX[sX];
                        mb[sX, sY] = true;
                        tempY[sY] = tempY[sY]-tempX[sX];
                        tempX[sX] = 0;
                        sX++;
                    }
                }
            }
        }
    }
}
