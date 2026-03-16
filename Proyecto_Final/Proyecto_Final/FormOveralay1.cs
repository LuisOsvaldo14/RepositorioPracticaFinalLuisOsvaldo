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
    public partial class FormOveralay1 : Form
    {
        public FormOveralay1()
        {
            InitializeComponent();
        }

        private void FormOveralay1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.5) {this.Opacity += 0.05;}
            else { timer1.Stop(); }
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
