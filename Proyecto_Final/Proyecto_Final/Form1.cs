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
    public partial class FormMenuprincipal : Form
    {
        public FormMenuprincipal()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            UcPrincipal ucprincipal = new UcPrincipal();
            AbrirUc(ucprincipal);

        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void tlpBarraTitulo_MouseDown(object sender, MouseEventArgs e)


        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {

                    double percent = (double)e.X / (double)tlpBarraTitulo.Width;

                    this.WindowState = FormWindowState.Normal;

                    this.Left = Cursor.Position.X - (int)(this.Width * percent);
                    this.Top = Cursor.Position.Y - e.Y;
                }
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void CargarControl<T>() where T : UserControl, new()
        {

            Control existente = panelContenedor.Controls.OfType<T>().FirstOrDefault();

            if (existente == null)
            {
                T nuevoControl = new T();
                nuevoControl.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(nuevoControl);
                nuevoControl.BringToFront();
            }
            else
            {

                existente.BringToFront();
            }
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
                Application.Exit();
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

        private void FormMenuprincipal_Activated(object sender, EventArgs e)
        {
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
        }


        bool expandir;


        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                Timer timernormal = new Timer();
                timernormal.Interval = 10;
                timernormal.Tick += (s, ve) =>
                {
                    if (this.Opacity > 0)
                    {
                        this.Opacity -= 0.15;
                    }
                    else
                    {
                        timernormal.Stop();
                        this.WindowState = FormWindowState.Normal;
                        this.StartPosition = FormStartPosition.CenterScreen;

                        Timer timernormal2 = new Timer();
                        timernormal2.Interval = 10;
                        timernormal2.Tick += (s2, ve2) =>
                        {
                            if (this.Opacity < 1)
                            {
                                this.Opacity += 0.15;
                            }
                            else
                            {
                                timernormal2.Stop();
                            }

                        };
                        timernormal2.Start();
                    }



                };
                timernormal.Start();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                Timer timernormal = new Timer();
                timernormal.Interval = 10;
                timernormal.Tick += (s, ve) =>
                {
                    if (this.Opacity > 0)
                    {
                        this.Opacity -= 0.15;
                    }
                    else
                    {
                        timernormal.Stop();
                        this.WindowState = FormWindowState.Maximized;

                        Timer timernormal2 = new Timer();
                        timernormal2.Interval = 10;
                        timernormal2.Tick += (s2, ve2) =>
                        {
                            if (this.Opacity < 1)
                            {
                                this.Opacity += 0.15;
                            }
                            else
                            {
                                timernormal2.Stop();
                            }

                        };
                        timernormal2.Start();
                    }



                };
                timernormal.Start();
            }
        }

        private void AbrirUc(UserControl Uc)
        {
            Uc.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(Uc);
            
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            CargarControl<UcAbout>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SlateGray;
        }

        private void buttonAbout_MouseEnter(object sender, EventArgs e)
        {
            buttonAbout.BackColor = Color.White;
        }

        

        private void buttonAbout_MouseLeave(object sender, EventArgs e)
        {
            buttonAbout.BackColor = Color.SlateGray;
        }

        private void buttonConfiguracion_MouseEnter(object sender, EventArgs e)
        {
            buttonConfiguracion.BackColor = Color.White;
        }
    

        private void buttonConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            buttonConfiguracion.BackColor = Color.SlateGray;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SlateGray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarControl<UcPrincipal>();

        }



    }
}
