﻿using Microsoft.Win32;
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
        Form1 f;
        private int[,] mp;
        private int[] x;
        private int[] y;
        public int o { get; set; }
        public int p { get; set; } 
        public datos()
        {
            InitializeComponent();
            matriz.Rows.Add();
        }
        public datos(int o, int p,Form1 f)
        {
            InitializeComponent();
            this.o = o;
            this.p = p;
            this.f = f;
        }
        public datos(Form1 f)
        {
            this.f = f;
            InitializeComponent();
            matriz.Rows.Add();
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
            if (f != null)
            {
                f.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            
        }
        private string intToLetter(int x)
        {
            char l;
            l = Convert.ToChar(x+65);
             return  Convert.ToString(l); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
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
                            try
                            {
                                temp[i, s] = int.Parse(row.Cells[intToLetter(i)].Value.ToString());
                            }
                            catch (NullReferenceException)
                            {
                                MessageBox.Show("Empty cells");
                                temp = null;
                                return;
                            }

                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Value Incorrect, pls only number in table");
                        temp = null;
                        return;
                    }catch(Exception)
                    {
                        MessageBox.Show("Error With Sintaxys");
                        temp = null;
                        return;
                    }
                    
                }
                s++;
            }
            
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
                            y[s] = temp[i, s];
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
            GenerarExcel g=new GenerarExcel(m,"Prueba1");
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Result.xlsx");
            MessageBox.Show("Libro Generado");
            m = null;
            nuevo = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            details temp = new details(this);
            temp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (matriz.ColumnCount <= 0)
                matriz.Columns.Add(intToLetter(matriz.ColumnCount), intToLetter(matriz.ColumnCount));
            matriz.Rows.Add();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            unaColumnaMas();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (matriz.ColumnCount > 0)
            {
                matriz.Columns.Remove(intToLetter(matriz.ColumnCount - 1));
            }
            else
            {
                MessageBox.Show("No columns less");
            }
        }

        private void datos_VisibleChanged(object sender, EventArgs e)
        {
            if (o != 0 && p != 0)
            {
                matriz.ColumnCount = 0;
                matriz.RowCount = 0;
                for(int i = 0; i < o; i++)
                {
                    unaColumnaMas();
                }
                for(int s = 0; s < p; s++)
                {
                    matriz.Rows.Add();
                }
            }
        }

        private void datos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (f != null)
            {
                f.Show();
            }
        }
    }
}
