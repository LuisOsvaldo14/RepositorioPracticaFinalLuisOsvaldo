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
            this.WindowState = FormWindowState.Maximized;
        }
        bool mover = false;
        int X, Y;
        private void tlpBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover) { this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y); }
        }
        private void tlpBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void tlpBarraTitulo_MouseDown(object sender, MouseEventArgs e)
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

        private void labelBarra_Click(object sender, EventArgs e)
        {

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

        private void FormMenuprincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                buttonMaximizar.BackgroundImage = Properties.Resources.minimizar_signo__1_;
                toolTip1.SetToolTip(buttonMaximizar, "Windows state normal");
            }
            else if (this.WindowState != FormWindowState.Maximized)
            {
                buttonMaximizar.BackgroundImage = Properties.Resources.maximizar__2_;
                toolTip1.SetToolTip(buttonMaximizar, "Windows state maximized");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool expandir;

        private void button2_Click(object sender, EventArgs e)
        {
            if (tlpBarralateral.Width < tlpBarralateral.MaximumSize.Width)
            {
                expandir = false;
            }
            else { expandir = true; }
            timerBarralaterar.Start();
        }
 

        private void timerBarralaterar_Tick(object sender, EventArgs e)
        {
            if (expandir)
            {
                tlpBarralateral.Width -= 15;
                if (tlpBarralateral.Width == tlpBarralateral.MinimumSize.Width)
                {
                    timerBarralaterar.Stop();
                }
            }
            else
            {
                tlpBarralateral.Width += 15;
                if (tlpBarralateral.Width == tlpBarralateral.MaximumSize.Width)
                {
                    timerBarralaterar.Stop();
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

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
    }
}
