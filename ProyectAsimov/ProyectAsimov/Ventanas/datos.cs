using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectAsimov.Ventanas
{
    public partial class datos : Form
    {
        public datos()
        {
            InitializeComponent();
        }
        private void unaFilaMas()
        {
            TextBox nuevo = new TextBox();
            Tabla.Controls.Add(nuevo);
        }
        private void mas_fila_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            unaFilaMas();
        }
    }
}
