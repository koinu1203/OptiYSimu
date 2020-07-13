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
        details x;

        public datos()
        {
            InitializeComponent();
            matriz.Rows.Add();
        }
        public datos(details x)
        {
            InitializeComponent();
            this.x=x; 
        }
        private void unaColumnaMas()
        {
            matriz.Columns.Add(intToLetter(matriz.ColumnCount), intToLetter(matriz.ColumnCount));
            matriz.Rows.Add();
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
            if (x != null)
            {
                x.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private string intToLetter(int x)
        {
            char l = 'A';
            l = Convert.ToChar(x+65);
             return  Convert.ToString(l); 
        }
    }
}
