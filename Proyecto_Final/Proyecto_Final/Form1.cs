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
    
    }
}
