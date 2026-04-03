using Microsoft.VisualBasic;
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
    public partial class UcAgregarListas : UserControl
    {
        public UcAgregarListas()
        {
            InitializeComponent();
        }
        private void AgregarTarjetaALista(string nombre, string ruta)
        {
            UcTarjetas tarjeta = new UcTarjetas();
            tarjeta.NombreLista = nombre;
            tarjeta.RutaArchivo = ruta;
            tarjeta.Dock = DockStyle.Top;

            // Obtener fecha de última apertura del archivo (si existe)
            DateTime ultima = File.Exists(ruta) ? File.GetLastAccessTime(ruta) : DateTime.MinValue;
            tarjeta.UltimaApertura = ultima == DateTime.MinValue ? "Nunca" : ultima.ToString("g");

            tarjeta.Click += (s, ev) => AbrirArchivoCSV(ruta);

            panelLista.Controls.Add(tarjeta);
        }
        private string rutaArchivoAbierto;

        public void CargarDatosDesdeCSV(string ruta)
        {
            this.rutaArchivoAbierto = ruta;
                                          
        }
        private void AbrirArchivoCSV(string ruta)
        {
            // Actualizar la hora de último acceso antes de abrir
            try
            {
                if (File.Exists(ruta))
                {
                    File.SetLastAccessTime(ruta, DateTime.Now);
                }
            }
            catch
            {
                // manejar si es necesario (permisos, etc.)
            }

            // Actualizar el label en la tarjeta correspondiente
            foreach (var ctrl in panelLista.Controls.OfType<UcTarjetas>())
            {
                if (string.Equals(ctrl.RutaArchivo, ruta, StringComparison.OrdinalIgnoreCase))
                {
                    ctrl.UltimaApertura = DateTime.Now.ToString("g");
                    break;
                }
            }

            FormMenuprincipal principal = (FormMenuprincipal)this.FindForm();
            principal.CargarEdicionTours(ruta);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string nombreLista = Interaction.InputBox("Ingrese el nombre para su nueva lista de tours:",
                                            "Nueva Lista", "");
            if (!string.IsNullOrWhiteSpace(nombreLista))
            {
                string carpeta = Path.Combine(Application.StartupPath, "ListasTours");
                string rutaCompleta = Path.Combine(carpeta, nombreLista + ".csv");
                if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);
                if (File.Exists(rutaCompleta))
                {
                    MessageBox.Show("Ya existe una lista con ese nombre. Intenta con otro.",
                                    "Nombre Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string encabezados = "ID,Nombre,País,Destino,Fecha,Hora,Precio,ITBIS,Duración,Estado";
                File.WriteAllText(rutaCompleta, encabezados + Environment.NewLine, Encoding.UTF8);
                AgregarTarjetaALista(nombreLista, rutaCompleta);

            }


        }

        private void UcAgregarListas_Load(object sender, EventArgs e)
        {
            string carpeta = Path.Combine(Application.StartupPath, "ListasTours");

            if (Directory.Exists(carpeta))
            {
                panelLista.Controls.Clear();
                string[] archivos = Directory.GetFiles(carpeta, "*.csv");
                foreach (string ruta in archivos)
                {
                    string nombre = Path.GetFileNameWithoutExtension(ruta);
                    AgregarTarjetaALista(nombre, ruta);
                }
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLista_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
