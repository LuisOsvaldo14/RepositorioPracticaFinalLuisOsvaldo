using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class UcTarjetas : UserControl
    {
        public UcTarjetas()
        {
            InitializeComponent();

        }
        public string RutaArchivo { get; set; }

        public string NombreLista
        {
            get => labelNombreTarjeta.Text; 
            set => labelNombreTarjeta.Text = value;
        }
        public string UltimaApertura
        {
            get => lblUltimaApertura.Text;
            set => lblUltimaApertura.Text = value ?? string.Empty;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.OnClick(e);

        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"¿Deseas eliminar \"{NombreLista}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;
            if (!string.IsNullOrWhiteSpace(RutaArchivo) && File.Exists(RutaArchivo))
            {
                try
                {
                    File.Delete(RutaArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo eliminar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            var parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Remove(this);
            }
            this.Dispose();
        }



        
    }
}
