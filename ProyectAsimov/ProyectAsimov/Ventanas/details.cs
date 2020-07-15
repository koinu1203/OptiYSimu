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
        datos d;
        public details()
        {
            this.vent = null;
            this.d = null;
            InitializeComponent();
        }
        public details(Form1 vent,datos d)
        {
            this.vent = vent;
            this.d=d;
            InitializeComponent();
        }
        public details(datos d)
        {
            this.d = d;
            vent = null;
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
            if (d != null)
            {
                d.Show();
            }
            else
            {
                if (vent != null)
                {
                    vent.Show();
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (d != null)
            {
                d.o = (int)numeroX.Value;
                d.p = (int)numeroY.Value;
                //Console.WriteLine(d.o +" "+ d.p);
                d.Show();
                this.Close();
            }
        }
    }
}
