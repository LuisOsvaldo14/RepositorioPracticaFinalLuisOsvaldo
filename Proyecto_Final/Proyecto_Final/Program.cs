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
            string NLV_Carpeta_appdata = AppDomain.CurrentDomain.BaseDirectory;

            string Carpeta_Usuarios = NLV_Carpeta_appdata + "\\Usuarios";

            

            string archivo_Usuarios = Path.Combine(Carpeta_Usuarios,"usuarios.txt");

            if (!Directory.Exists(Carpeta_Usuarios))
            {
                Directory.CreateDirectory(Carpeta_Usuarios);
            }

            if (!File.Exists(archivo_Usuarios))
            {
                File.Create(archivo_Usuarios).Close();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSingin());
        }
    }
}
