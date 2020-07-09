using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAsimov.Clases
{
    class M_Cruze
    {
        private M_Eno m;
        private int[] lista;
        private int x, y;
        private bool flag;
        public M_Cruze(M_Eno m)
        {
            this.m = m;
        }
        private void aplicarMetodo()
        {
            int aux = 0;
            do
            {
                aux = contarPosiciones();
                lista = new int[aux];
                for (int i = 0; i < m.m.x; i++)
                {
                    for (int s = 0; i < m.m.y; s++)
                    {
                        if (m.mb[i, s] == false)
                        {
                            
                        }
                    }
                        
                }
            } while (quedanNegativos());
        }
        private int resultado(int f, int c,int d)
        {
            if (f == x && c == y && flag == false)
            {
                return 0;
            }
            else
            {
                flag = false;
                if (d == 0)
                {

                }
                else
                {

                }
            }
        }
        private 
        private bool quedanNegativos()
        {
            for(int i = 0; i < lista.Length; i++)
            {
                if (lista[i] < 0)
                {
                    return true;
                }
            }
            return false;
        }
        private int contarPosiciones()
        {
            int temp = 0;
            for (int i = 0; i < m.m.x; i++)
            {
                for (int s = 0; i < m.m.y; s++)
                {
                    if (m.mb[i, s] == false)
                    {
                        temp++;
                    }
                }
            }
            return temp;
        }
    }
}
