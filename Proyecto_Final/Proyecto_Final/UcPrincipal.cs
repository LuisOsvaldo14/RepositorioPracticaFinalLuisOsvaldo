using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class UcPrincipal : UserControl
    {
        public UcPrincipal()
        {
            InitializeComponent();
            string[] paises = new string[]
            {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Esuatini",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea",
            "Guinea-Bisáu",
            "Guinea Ecuatorial",
            "Guyana",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"
            };
            comboBoxPais.Items.AddRange(paises);
            comboBoxPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPais.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void UcPrincipal_Load(object sender, EventArgs e)
        {
            flpAgregar.Height = flpAgregar.MinimumSize.Height;
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        bool expandir;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (flpAgregar.Height < flpAgregar.MaximumSize.Height)
            {
                expandir = false;
            }
            else { expandir = true; }
            timerAnimacion.Start();


        }


        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (expandir)
            {
                flpAgregar.Height -= 20;
                if (flpAgregar.Height == flpAgregar.MinimumSize.Height)
                {
                    timerAnimacion.Stop();
                }
            }
            else
            {
                flpAgregar.Height += 20;
                if (flpAgregar.Height == flpAgregar.MaximumSize.Height)
                {
                    timerAnimacion.Stop();
                }
            }

        }

        bool Combopais;
        bool txtNombre;

        private void comboBoxPais_TextChanged(object sender, EventArgs e)
        {
            string[] paises = new string[]
            {

            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Esuatini",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea",
            "Guinea-Bisáu",
            "Guinea Ecuatorial",
            "Guyana",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"
            };

            string VerificarPais = comboBoxPais.Text;
            if (string.IsNullOrWhiteSpace(VerificarPais))
            {
                labelMensajePais.ForeColor = Color.Red;
                labelMensajePais.Text = "Introduce no solo espacios.";
                Combopais = false;
            }
            else if(!paises.Contains(VerificarPais))
            {
                labelMensajePais.ForeColor = Color.Red;
                labelMensajePais.Text = "El pais que introdujiste no esta en nuestro sistema.";
                Combopais = false;
            }
            else 
            { 
                labelMensajePais.Text = "";
                Combopais = true;
            }

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            string VerficarNombre = textBoxNombre.Text;
            if (string.IsNullOrWhiteSpace(VerficarNombre))
            {
                labelMensajeNombre.ForeColor = Color.Red;
                labelMensajeNombre.Text = "Introduce no solo espacios";
                txtNombre = false;
            }
            else if (VerficarNombre.Length < 4 || VerficarNombre.Length > 15)
            {
                labelMensajeNombre.ForeColor = Color.Red;
                labelMensajeNombre.Text = "El nombre del tour debe tener entre 4 y 15 caracteres.";
                txtNombre = false;
            }
            else if (!Regex.IsMatch(VerficarNombre, @"^[a-zA-Z0-9ñÑáéíóúÁÉÍÓÚüÜ_]+$"))
            {
                labelMensajeNombre.ForeColor = Color.Red;
                labelMensajeNombre.Text = "Solo se permiten letras,números o" + " '_' " + "(sin espacios ni símbolos)";
                txtNombre = false;
            }
            else
            {
                labelMensajeNombre.Text = "";
                txtNombre = true;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre == true && Combopais == true)           
            {
                //Precio,Itbis,Nombre,Pais,
                decimal Precio = numericUpDownPrecio.Value;
                decimal Itbis = Precio * 0.18m;
                string Nombre = textBoxNombre.Text;
                string Pais = comboBoxPais.Text;
                int id = dataGridViewDatos.Rows.Count + 1;

                //Calcular Fecha,hora y estado:
                DateTime Fecha = dtpFecha.Value.Date;
                DateTime Hora = dtpHora.Value;
                DateTime FechayHora = Fecha.Add(Hora.TimeOfDay);
                string Estado;
                if (FechayHora > DateTime.Now)
                {
                    Estado = "Vigente";
                }
                else { Estado = "Vencida"; }

                //Calcular el destino y la Duracion del tour
                string Destino = "Aeropuerto de " + Pais; //JAJAJAJ XD
                string Tiempo = "XD JAJAJAJA";

                //Agregar al datagridView
                dataGridViewDatos.Rows.Add
                (
                    id,
                    Nombre,
                    Pais,
                    Destino,
                    Fecha,
                    Hora,
                    Precio,
                    Itbis,
                    Tiempo,
                    Estado

                );
                dataGridViewDatos.ClearSelection();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDatos.CurrentRow != null)
            {
                // 2. Pedimos confirmación al usuario (Opcional, pero muy profesional)
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar este tour?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // 3. Obtenemos el índice de la fila seleccionada y la eliminamos
                    int indice = dataGridViewDatos.CurrentRow.Index;
                    dataGridViewDatos.Rows.RemoveAt(indice);

                    // 4. Limpiamos la selección para que no se quede nada azul por error
                    dataGridViewDatos.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para borrar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
