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
    public partial class details : Form
    {
        Form1 vent;
        public details()
        {
            this.vent = new Form1();
            InitializeComponent();
        }
        public details(Form1 vent)
        {
            this.vent = vent;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconSandHX()
        {
            if (numeroX.Value > 10)
            {
                alertaX.Show();
            }
            else
            {
                alertaX.Hide();
            }
        }

        private void iconSandHY()
        {
            if (numeroY.Value > 10)
            {
                alertaY.Show();
            }
            else
            {
                alertaY.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void details_FormClosed(object sender, FormClosedEventArgs e)
        {
            vent.Show();
        }

        private void numeroX_Click(object sender, EventArgs e)
        {
            iconSandHX();
        }

        private void alertaY_Click(object sender, EventArgs e)
        {
            iconSandHX();
        }

        private void numeroX_Validating(object sender, CancelEventArgs e)
        {
            iconSandHX();
        }

        private void numeroX_MouseCaptureChanged(object sender, EventArgs e)
        {
            iconSandHX(); 
        }

        private void details_MouseMove(object sender, MouseEventArgs e)
        {
            iconSandHX();
            iconSandHY();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            iconSandHX();
            iconSandHY();
        }

        private void numeroX_Enter(object sender, EventArgs e)
        {
            iconSandHX();
        }
    }
}
