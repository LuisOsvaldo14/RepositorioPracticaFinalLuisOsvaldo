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
        string[] paises;
        public UcPrincipal()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
            null, dataGridViewDatos, new object[] { true });



        }
        private TimeSpan ObtenerDuracion(string pais)
        {
         
            {
                switch (pais)
                {
                    // 🌴 Caribe (1–3 horas)
                    case "Cuba":
                    case "Haití":
                    case "Jamaica":
                    case "Bahamas":
                    case "Barbados":
                    case "Dominica":
                    case "Granada":
                    case "San Cristóbal y Nieves":
                    case "San Vicente y las Granadinas":
                    case "Santa Lucía":
                    case "Trinidad y Tobago":
                    case "Antigua y Barbuda":
                        return TimeSpan.FromHours(2);

                    // 🌎 Centroamérica (2–4 horas)
                    case "Panamá":
                    case "Costa Rica":
                    case "Nicaragua":
                    case "Honduras":
                    case "El Salvador":
                    case "Guatemala":
                    case "Belice":
                        return TimeSpan.FromHours(3);

                    // 🇺🇸 Norteamérica (4–6 horas)
                    case "Estados Unidos":
                    case "Canadá":
                    case "México":
                        return TimeSpan.FromHours(5);

                    // 🇦🇷 Sudamérica (5–9 horas)
                    case "Colombia":
                    case "Venezuela":
                    case "Ecuador":
                        return TimeSpan.FromHours(3);

                    case "Perú":
                    case "Bolivia":
                    case "Guyana":
                    case "Surinam":
                        return TimeSpan.FromHours(5);

                    case "Brasil":
                    case "Chile":
                    case "Argentina":
                    case "Uruguay":
                    case "Paraguay":
                        return TimeSpan.FromHours(8);

                    // 🇪🇺 Europa (8–11 horas)
                    case "España":
                    case "Portugal":
                    case "Francia":
                    case "Italia":
                    case "Alemania":
                    case "Países Bajos":
                    case "Bélgica":
                    case "Suiza":
                    case "Austria":
                    case "Reino Unido":
                        return TimeSpan.FromHours(9);

                    default:
                        // Más países de Europa
                        if (new[] {
                "Polonia","Hungría","Rumania","Grecia","Suecia","Noruega",
                "Finlandia","Dinamarca","Irlanda","Islandia","Croacia",
                "Serbia","Ucrania","Bulgaria","Eslovaquia","Eslovenia",
                "Estonia","Letonia","Lituania","Luxemburgo","Malta",
                "Mónaco","San Marino","Vaticano","Andorra","Albania",
                "Bosnia y Herzegovina","Montenegro","Moldavia","Bielorrusia"
            }.Contains(pais))
                            return TimeSpan.FromHours(10);

                        // 🌍 África (10–14 horas)
                        if (new[] {
                "Marruecos","Argelia","Túnez","Egipto","Senegal","Ghana",
                "Nigeria","Costa de Marfil","Camerún","Angola","Etiopía",
                "Kenia","Tanzania","Sudáfrica","Sudán","Sudán del Sur",
                "Uganda","Zambia","Zimbabue","Namibia","Botsuana","Malí",
                "Níger","Chad","Gabón","Guinea","Guinea-Bisáu",
                "Guinea Ecuatorial","Sierra Leona","Liberia","Mauritania",
                "Mauricio","Seychelles","Madagascar","Ruanda","Burundi",
                "Eritrea","Somalia","Togo","Benín","Burkina Faso","Lesoto",
                "Esuatini","Yibuti","Comoras","Cabo Verde","Gambia"
            }.Contains(pais))
                            return TimeSpan.FromHours(12);

                        // 🌏 Medio Oriente (12–16 horas)
                        if (new[] {
                "Arabia Saudita","Emiratos Árabes Unidos","Catar","Kuwait",
                "Omán","Israel","Jordania","Líbano","Irak","Irán","Siria","Yemen"
            }.Contains(pais))
                            return TimeSpan.FromHours(14);

                        // 🌏 Asia (16–25 horas)
                        if (new[] {
                "China","Japón","Corea del Sur","Corea del Norte","India",
                "Pakistán","Bangladés","Nepal","Sri Lanka","Tailandia",
                "Vietnam","Indonesia","Malasia","Singapur","Filipinas",
                "Mongolia","Kazajistán","Uzbekistán","Turkmenistán",
                "Tayikistán","Kirguistán","Laos","Camboya","Birmania","Bután"
            }.Contains(pais))
                            return TimeSpan.FromHours(20);

                        // 🌏 Oceanía (20–30 horas)
                        if (new[] {
                "Australia","Nueva Zelanda","Fiyi","Papúa Nueva Guinea",
                "Islas Salomón","Vanuatu","Samoa","Tonga","Tuvalu",
                "Kiribati","Micronesia","Palaos","Islas Marshall","Nauru"
            }.Contains(pais))
                            return TimeSpan.FromHours(26);

                        return TimeSpan.FromHours(10);
                }
            }

        }

        private void UcPrincipal_Load(object sender, EventArgs e)
        {
            tlpAgregar.Height = tlpAgregar.MinimumSize.Height;
            tlpEditar.Height = tlpEditar.MinimumSize.Height;
            paises = new string[]
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


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        bool expandir;
        bool expandireditar;
        private bool pendienteAbrirAgregar = false;
        private bool pendienteAbrirEditar = false;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (expandir)
            {
                expandir = false;
                pendienteAbrirAgregar = false;
            }
            else
            {

                pendienteAbrirAgregar = true;
                pendienteAbrirEditar = false;
                expandireditar = false;
            }
            timerAnimacion.Start();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (expandireditar)
            {
                expandireditar = false;
                pendienteAbrirEditar = false;
            }
            else
            {

                pendienteAbrirEditar = true;
                pendienteAbrirAgregar = false;
                expandir = false;
            }
            timerAnimacion.Start();
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            bool tlpAgregarEnMovimiento = false;
            bool tlpEditarEnMovimiento = false;

            if (!expandir && tlpAgregar.Height > tlpAgregar.MinimumSize.Height)
            {
                tlpAgregar.Height = Math.Max(tlpAgregar.Height - 25, tlpAgregar.MinimumSize.Height);
                tlpAgregarEnMovimiento = true;
            }
            if (!expandireditar && tlpEditar.Height > tlpEditar.MinimumSize.Height)
            {
                tlpEditar.Height = Math.Max(tlpEditar.Height - 25, tlpEditar.MinimumSize.Height);
                tlpEditarEnMovimiento = true;
            }
            if (!tlpAgregarEnMovimiento && !tlpEditarEnMovimiento)
            {
                if (pendienteAbrirAgregar)
                {
                    expandir = true;
                    pendienteAbrirAgregar = false; 
                }
                if (pendienteAbrirEditar)
                {
                    expandireditar = true;
                    pendienteAbrirEditar = false; 
                }
            }

            if (expandir && tlpAgregar.Height < tlpAgregar.MaximumSize.Height)
            {
                tlpAgregar.Height = Math.Min(tlpAgregar.Height + 25, tlpAgregar.MaximumSize.Height);
                tlpAgregarEnMovimiento = true;
            }

            if (expandireditar && tlpEditar.Height < tlpEditar.MaximumSize.Height)
            {
                tlpEditar.Height = Math.Min(tlpEditar.Height + 25, tlpEditar.MaximumSize.Height);
                tlpEditarEnMovimiento = true;
            }
            if (!tlpAgregarEnMovimiento && !tlpEditarEnMovimiento && !pendienteAbrirAgregar && !pendienteAbrirEditar)
            {
                timerAnimacion.Stop();
            }
        }
        private void timerAnimacion2_Tick(object sender, EventArgs e)
        {


        }

        bool Combopais;
        bool txtNombre;
        bool PrecioInput;
        private void comboBoxPais_TextChanged(object sender, EventArgs e)
        {
 

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
        private void numericUpDownPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            if (decimal.TryParse(numericUpDownPrecio.Text, out decimal valorEscrito))
            {
                if (valorEscrito <= 1000 || valorEscrito > 10000000)
                {
                    PrecioInput = false;
                    labelMensajePrecio.Text = "Introduce un número entre 1 y 10,000,000";
                    labelMensajePrecio.ForeColor = Color.Red;
                    labelMensajePrecio.Visible = true;
                }
                else
                {
                    PrecioInput = true;
                    labelMensajePrecio.Visible = false;
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(numericUpDownPrecio.Text, out decimal valorEscrito))
            {
                if (valorEscrito <= 1000 || valorEscrito > 10000000)
                {
                    PrecioInput = false;
                    labelMensajePrecio.Text = "Introduce un número entre 1 y 10,000,000";
                    labelMensajePrecio.ForeColor = Color.Red;
                    labelMensajePrecio.Visible = true;
                }
                else
                {
                    PrecioInput = true;
                    labelMensajePrecio.Visible = false;
                }
            }
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
            string VerificarPais = comboBoxPais.Text;
            if (string.IsNullOrWhiteSpace(VerificarPais))
            {
                labelMensajePais.ForeColor = Color.Red;
                labelMensajePais.Text = "Introduce no solo espacios.";
                Combopais = false;
            }
            if (txtNombre == true && Combopais == true && PrecioInput == true)           
            {
                //Precio,Itbis,Nombre,Pais,
                decimal Precio = numericUpDownPrecio.Value;
                decimal Itbis = Precio * 0.18m;
                string Nombre = textBoxNombre.Text;
                string Pais = comboBoxPais.Text;
                int BuscadorIdMayor = 0;
                foreach (DataGridViewRow row in dataGridViewDatos.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        int idActual = Convert.ToInt32(row.Cells[0].Value);
                        if (idActual > BuscadorIdMayor) BuscadorIdMayor = idActual;
                    }
                }
                int id = BuscadorIdMayor + 1;

                //Calcular Fecha,hora y estado:
                DateTime Fecha = dtpFecha.Value.Date;
                DateTime Hora = dtpHora.Value;
                string FechaForma = Fecha.ToString("dd/MM/yyyy");
                string HoraForma = Hora.ToString("HH:mm");
                DateTime FechayHora = Fecha.Add(Hora.TimeOfDay);


                //Calcular el destino y la Duracion del tour
                string Destino = "Aeropuerto de " + Pais; //JAJAJAJ XD
                                                         
                TimeSpan duracion = ObtenerDuracion(Pais);

                // Fecha completa inicio
                DateTime fechaHoraInicio = Fecha.Add(Hora.TimeOfDay);

                // Fecha final del viaje
                DateTime fechaHoraFin = fechaHoraInicio.Add(duracion);

                // Estado correcto
                string Estado = DateTime.Now > fechaHoraFin ? "Vencida" : "Vigente";

                // Tiempo en texto
                string Tiempo = duracion.TotalHours + " horas";

                //Agregar al datagridView
                dataGridViewDatos.Rows.Add
                (
                    id,
                    Nombre,
                    Pais,
                    Destino,
                    FechaForma,
                    HoraForma,
                    Precio,
                    Itbis,
                    Tiempo,
                    Estado

                );
                dataGridViewDatos.CurrentCell = null;
                dataGridViewDatos.ClearSelection();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDatos.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar este tour?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
 
                    int indice = dataGridViewDatos.CurrentRow.Index;
                    dataGridViewDatos.Rows.RemoveAt(indice);
                    dataGridViewDatos.CurrentCell = null;
                    dataGridViewDatos.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para borrar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numericUpDownPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as NumericUpDown).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        
    }
}
