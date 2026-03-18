using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormCopiaryPegar : Form
    {
        public FormCopiaryPegar()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        bool mover = false;
        int X, Y;
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover) { this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y); }
        }
        private void panelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            X = e.X; Y = e.Y;
        }
        private void labelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            X = e.X; Y = e.Y;
        }
        private void labelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover) { this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y); }
        }
        private void labelBarra_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void FormCopiaryPegar_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrarContra_Click(object sender, EventArgs e)
        {
        }
    }
}
