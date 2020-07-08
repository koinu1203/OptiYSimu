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
        public M_Cruze(M_Eno m)
        {
            this.m = m;
        }
        private void aplicarMetodo()
        {
            int aux = 0, x, y;
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
        private int resultado(int x, int y)
        {
            int sum=m.m.mp[x,y];
            
            return sum;
        }
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
