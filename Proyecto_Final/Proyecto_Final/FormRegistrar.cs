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
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
            timerAnimacionAbrir.Start();
        }

        private void buttonMostrarContra_Click(object sender, EventArgs e)
        {
            if (textBoxContra1.PasswordChar == '*') 
            {
                textBoxContra1.PasswordChar = '\0';
                textBoxContra2.PasswordChar = '\0';
                toolTip1.SetToolTip(buttonMostrarContra, "Ocultar contraseña");
                buttonMostrarContra.BackgroundImage = Properties.Resources.mostrar_contrasena;
            }
            else
            {
                textBoxContra1.PasswordChar = '*';
                textBoxContra2.PasswordChar = '*';
                toolTip1.SetToolTip(buttonMostrarContra, "Mostrar contraseña");
                buttonMostrarContra.BackgroundImage = Properties.Resources.esconder;
            }
            
        }

        private void textBoxContra2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContra1.Text != textBoxContra2.Text)
            {
                labelMensajeContra2.Text = "La contraseña no es igual; verifique que sea la misma.";

            }
            else
            {
                labelMensajeContra2.Text = " ";
            }
        }

        private void buttonSingin_Click(object sender, EventArgs e)
        {

        }
        private void timerAnimacionAbrir_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timerAnimacionAbrir.Stop();
            }
        }

        private void timerSalir_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timerSalir.Stop();
                this.Close();
            }
        }
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            timerSalir.Start();
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
