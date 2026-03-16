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

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
