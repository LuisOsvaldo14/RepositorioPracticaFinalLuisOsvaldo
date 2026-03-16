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
        private void FormSingin_Load(object sender, EventArgs e)
        {
            timerAnimacionAbrir.Start();
        }
        private void timerAnimacionAbrir_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0) { this.Opacity += 0.035; }
            else {timerAnimacionAbrir.Stop();}

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            timerSalir.Start();       
        }
        private void timerSalir_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.04;
            }
            else
            {
                timerSalir.Stop();
                this.Close();
            }

        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            Timer timerminimizar = new Timer();
            timerminimizar.Interval = 10;
            timerminimizar.Tick += (s, ve) =>
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.2;
                }
                else
                {
                    timerminimizar.Stop();
                    this.WindowState = FormWindowState.Minimized;
                }
            };
            timerminimizar.Start();
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

        private void FormSingin_Activated(object sender, EventArgs e)
        {
            Timer Mostrar = new Timer();
            Mostrar.Interval = 10;
            Mostrar.Tick += (s, ve) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.1;
                }
                else
                {
                    Mostrar.Stop();
                }
            };
            Mostrar.Start();
        }

        private void linkLabelRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormOveralay1 overlay = new FormOveralay1();
            overlay.Owner = this;
            overlay.Location = this.Location;
            overlay.Size = this.Size;
            FormRegistrar registrar = new FormRegistrar();
            registrar.StartPosition = FormStartPosition.CenterParent;
            overlay.Show();
            registrar.ShowDialog(overlay);
            Timer timerOver = new Timer();
            timerOver.Interval = 10;
            timerOver.Tick += (s, ev) =>
            {
                if (overlay.Opacity > 0) { overlay.Opacity -= 0.2; }
                else
                {
                    timerOver.Stop();
                    overlay.Close();
                }
            };
            timerOver.Start();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MAXIMIZE = 0xF030; 
            const int SC_MINIMIZE = 0xF020; 
            const int SC_RESTORE = 0xF120; 

            if (m.Msg == WM_SYSCOMMAND)
            {
                int command = m.WParam.ToInt32() & 0xFFF0;

                
                if (command == SC_MAXIMIZE || command == SC_MINIMIZE || command == SC_RESTORE)
                {
                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
}
