using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
        bool veriUsuario;


        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            labelErrorRegistrar.Text = "";

            string NLV_Carpeta_appdata = AppDomain.CurrentDomain.BaseDirectory;
            string Carpeta_Usuarios = NLV_Carpeta_appdata + "\\Usuarios";
            string archivo_Usuarios = Path.Combine(Carpeta_Usuarios, "usuarios.txt");
            string textoUsuario = textBoxUsuario.Text;
            string[] lineas = File.ReadAllLines(archivo_Usuarios);
            foreach (string line in lineas)
            {
                string[] datos = line.Split(',');
                if (datos[0] == textoUsuario)
                {
                    labelMensajeUsuario.Text = "Este nombre de usuario ya existe";
                    veriUsuario = false;
                    return;
                }
            }

            if (textoUsuario == "")
            {
                labelMensajeUsuario.Text = "El usuario no puede estar vacio";
                veriUsuario = false;
            }
            else if (textoUsuario.Length < 4 || textoUsuario.Length > 15)
            {
                labelMensajeUsuario.Text = "El nombre de usuario debe tener entre 4 y 15 caracteres";
                veriUsuario = false;
            }
            else if (!Regex.IsMatch(textoUsuario, @"^[a-zA-Z0-9ñÑáéíóúÁÉÍÓÚüÜ_]+$"))
            {
                labelMensajeUsuario.Text = "Solo se permiten letras,números o" + " '_' " + "(sin espacios ni símbolos)";
                veriUsuario = false;
            }


            else
            {
                labelMensajeUsuario.Text = "";
                veriUsuario = true;

            }
        }
        bool veriConfirmacionContra;
        bool veriContra;
        private void textBoxContra1_TextChanged(object sender, EventArgs e)
        {
            labelErrorRegistrar.Text = "";
            string textoContra1 = textBoxContra1.Text;
            if (textoContra1 == "")
            {
                labelMensajeContra1.Text = "La contraseña no puede estar vacia";
                veriContra = false;
            }
            else if (textoContra1.Length < 4 || textoContra1.Length > 15)
            {
                labelMensajeContra1.Text = "La contraseña debe tener entre 4 y 15 caracteres";
                veriContra = false;
            }
            else if (!Regex.IsMatch(textoContra1, @"^[a-zA-Z0-9ñÑáéíóúÁÉÍÓÚüÜ]+$"))
            {
                labelMensajeContra1.Text = "Solo se permiten letras y números (sin espacios ni símbolos)";
                veriContra = false;
            }
            else
            {
                labelMensajeContra1.Text = "";
                veriContra = true;
            }
            
            if (textBoxContra1.Text != textBoxContra2.Text)
            {
                labelMensajeContra2.Text = "La contraseña no es igual; verifique que sea la misma.";
                veriConfirmacionContra = false;

            }
            else
            {
                labelMensajeContra2.Text = "";
                veriConfirmacionContra = true;
            }

        }

        private void textBoxContra2_TextChanged(object sender, EventArgs e)
        {
            labelErrorRegistrar.Text = "";
            if (textBoxContra1.Text != textBoxContra2.Text)
            {
                labelMensajeContra2.Text = "La contraseña no es igual; verifique que sea la misma.";
                veriConfirmacionContra = false;

            }
            else
            {
                labelMensajeContra2.Text = "";
                veriConfirmacionContra = true;
            }
        }
        private void buttonSingin_Click(object sender, EventArgs e)
        {
            if (veriUsuario && veriContra && veriConfirmacionContra)
            {
                string NLV_Carpeta_appdata = AppDomain.CurrentDomain.BaseDirectory;
                string Carpeta_Usuarios = NLV_Carpeta_appdata + "\\Usuarios";
                string archivo_Usuarios = Path.Combine(Carpeta_Usuarios, "usuarios.txt");
                string usuario = textBoxUsuario.Text;
                string Contrasena = textBoxContra1.Text;
                File.AppendAllText(archivo_Usuarios, usuario + "," + Contrasena + Environment.NewLine);
                labelErrorRegistrar.ForeColor = Color.Green;
                labelErrorRegistrar.Text = "Usuario registrado";
                timerSalir.Start();
            }       
            else
            {
                SystemSounds.Exclamation.Play();
                labelErrorRegistrar.Text = "¡Verifique que los campos no estén vacíos o con errores!";

            }


        }
    }
    
}
