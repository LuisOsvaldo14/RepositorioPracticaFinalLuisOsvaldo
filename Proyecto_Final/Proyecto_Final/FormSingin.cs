using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class FormSingin : Form
    {
        public FormSingin()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool mover = false;
        int X, Y;
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover) {this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y); }
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

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void FormSingin_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrarContra_Click(object sender, EventArgs e)
        {
            if (textBoxContra.PasswordChar == '*')
            {
                textBoxContra.PasswordChar = '\0';
                toolTip1.SetToolTip(buttonMostrarContra, "Ocultar contraseña");
                buttonMostrarContra.BackgroundImage = Properties.Resources.mostrar_contrasena;
            }
            else
            {
                textBoxContra.PasswordChar = '*';
                toolTip1.SetToolTip(buttonMostrarContra, "Mostrar contraseña");
                buttonMostrarContra.BackgroundImage = Properties.Resources.esconder;
            }
        }

        private void linkLabelRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormOveralay1 overlay = new FormOveralay1();
            overlay.Location = this.Location;
            overlay.Size = this.Size;
            FormRegistrar registrar = new FormRegistrar();
            registrar.StartPosition = FormStartPosition.CenterParent;
            overlay.Show();
            registrar.ShowDialog(overlay);
            overlay.Close();

            
        }
    }
}
