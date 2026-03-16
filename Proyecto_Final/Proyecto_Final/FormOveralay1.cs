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
    }
}
