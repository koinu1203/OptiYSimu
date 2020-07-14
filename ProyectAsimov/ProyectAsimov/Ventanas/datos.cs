using Microsoft.Win32;
using ProyectAsimov.Clases;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAsimov.Ventanas
{
    public partial class datos : Form
    {
        details m;
        int[,] mp;
        int[] x;
        int[] y;

        public datos()
        {
            InitializeComponent();
            matriz.Rows.Add();
        }
        public datos(details m)
        {
            InitializeComponent();
            this.m=m; 
        }
        private void unaColumnaMas()
        {
            matriz.Columns.Add(intToLetter(matriz.ColumnCount), intToLetter(matriz.ColumnCount));
        }
        private void mas_fila_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            unaColumnaMas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m != null)
            {
                m.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (matriz.ColumnCount>0)
            {
                matriz.Columns.Remove(intToLetter(matriz.ColumnCount - 1));
            }
            else
            {
                MessageBox.Show("No columns less");
            }
            
        }
        private string intToLetter(int x)
        {
            char l = 'A';
            l = Convert.ToChar(x+65);
             return  Convert.ToString(l); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (matriz.ColumnCount <= 0)
                matriz.Columns.Add(intToLetter(matriz.ColumnCount), intToLetter(matriz.ColumnCount));
            matriz.Rows.Add();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (matriz.RowCount > 0)
            {
                matriz.Rows.RemoveAt(matriz.RowCount - 1);
            }
            else
            {
                MessageBox.Show("No row less");
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] temp = new int[matriz.ColumnCount, matriz.RowCount];
            int s = 0;
            foreach(DataGridViewRow row in matriz.Rows)
            {
                for(int i = 0; i < matriz.ColumnCount; i++)
                {
                    try
                    {
                        if(i+1==matriz.ColumnCount && s + 1 == matriz.RowCount)
                        {
                            temp[i, s] = 0;
                        }
                        else
                        {
                            temp[i, s] = int.Parse(row.Cells[intToLetter(i)].Value.ToString());
                        }
                    }catch(FormatException ex)
                    {
                        MessageBox.Show("Value Incorrect, pls only number in table");
                        temp = null;
                        return;
                    }
                }
                s++;
            }
            MessageBox.Show(mp[0,0].ToString());

            mp = new int[matriz.ColumnCount - 1, matriz.RowCount - 1];
            x = new int[matriz.ColumnCount-1];
            y = new int[matriz.RowCount - 1];
            for (int i = 0;i< matriz.ColumnCount; i++)
            {
                for(s = 0; s < matriz.RowCount; s++)
                {
                    if (i + 1 == matriz.ColumnCount)
                    {
                        if(s + 1 != matriz.RowCount)
                        {
                            y[i] = temp[i, s];
                        }                    
                    }
                    else
                    {
                        if (s + 1 == matriz.RowCount)
                        {
                            x[i] = temp[i, s];
                        }
                        else
                        {
                            mp[i, s] = temp[i, s];
                        }
                    }
                }
            }
            Matriz nuevo = new Matriz(mp,x,y);
            M_Eno m = new M_Eno(nuevo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(matriz.ColumnCount.ToString() + matriz.RowCount.ToString());
        }
    }
}
