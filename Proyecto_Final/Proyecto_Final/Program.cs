using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string NLV_Carpeta_appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoLimitsEvents";

            string Carpeta_Usuarios = NLV_Carpeta_appdata + "\\Usuarios";
            string Carpeta_configuracion = NLV_Carpeta_appdata + "\\Configuracion";
            string Carpeta_log = NLV_Carpeta_appdata + "\\Logs";
            

            string archivo_Usuarios = Path.Combine(Carpeta_Usuarios,"usuarios.txt");
            string archivo_configuracion = Path.Combine(Carpeta_configuracion,"configuracion.txt");
            string archivo_log = Path.Combine(Carpeta_log,"Log.txt");
            string archivo_Recuerdame = Path.Combine(NLV_Carpeta_appdata,"Recuerdame.txt");


            if (!File.Exists(archivo_Usuarios))
            {
                File.Create(archivo_Usuarios).Close();
            }

            if (!File.Exists(archivo_configuracion))
            {
                File.Create(archivo_configuracion).Close();
            }

            if (!File.Exists(archivo_log))
            {
                File.Create(archivo_log).Close();
            }
            if (!File.Exists(archivo_Recuerdame))
            {
                File.Create(archivo_Recuerdame).Close();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSingin());
        }
    }
}
