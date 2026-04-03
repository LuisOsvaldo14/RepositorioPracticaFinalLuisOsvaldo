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
using System.IO;
using System.Globalization;


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
        private string rutaArchivoActual;
        public void CargarDatosDesdeCSV(string ruta)
        {
            this.rutaArchivoActual = ruta;
            string NombreArchibo = Path.GetFileNameWithoutExtension(ruta);
            labelNombrearchivo.Text = "Edición de: " + NombreArchibo;

            dataGridViewDatos.Rows.Clear();
            if (!File.Exists(ruta)) return;
            

            try
            {
                string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);
                for (int i = 1; i < lineas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                    string[] celdas = lineas[i].Split(',');
                    if (celdas.Length >= dataGridViewDatos.ColumnCount)
                    {
                        var id = celdas[0];
                        var nombre = celdas[1];
                        var pais = celdas[2];
                        var destino = celdas[3];

                        DateTime fecha;
                        DateTime hora;
                        // Intentar formatos esperados (ISO y dd/MM/yyyy/hh:mm)
                        if (!DateTime.TryParseExact(celdas[4], new[] { "o", "s", "yyyy-MM-dd", "dd/MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                            DateTime.TryParse(celdas[4], CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);

                        if (!DateTime.TryParseExact(celdas[5], new[] { "o", "s", "HH:mm:ss", "HH:mm" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out hora))
                            DateTime.TryParse(celdas[5], CultureInfo.InvariantCulture, DateTimeStyles.None, out hora);

                        decimal precio = 0m;
                        decimal itbis = 0m;
                        decimal.TryParse(celdas[6], NumberStyles.Any, CultureInfo.InvariantCulture, out precio);
                        decimal.TryParse(celdas[7], NumberStyles.Any, CultureInfo.InvariantCulture, out itbis);

                        var duracion = celdas.Length > 8 ? celdas[8] : "";
                        var estado = celdas.Length > 9 ? celdas[9] : "";

                        dataGridViewDatos.Rows.Add(id, nombre, pais, destino, fecha, hora, precio, itbis, duracion, estado);
                    }
                    dataGridViewDatos.CurrentCell = null;
                    dataGridViewDatos.ClearSelection();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private async Task GuardarCambiosEnCSV()
        {
            if (string.IsNullOrEmpty(rutaArchivoActual)) return;
            try
            {
                FotoGuardando.Visible = true;
                labelGuardar.ForeColor = Color.Red;
                labelGuardar.Text = "Guardando datos...";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("ID,Nombre,País,Destino,Fecha,Hora,Precio,ITBIS,Duración,Estado");
                foreach (DataGridViewRow fila in dataGridViewDatos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string fechaStr = "";
                    string horaStr = "";
                    if (fila.Cells[4].Value is DateTime dtFecha) fechaStr = dtFecha.ToString("o", CultureInfo.InvariantCulture);
                    else fechaStr = (fila.Cells[4].Value?.ToString() ?? "");

                    if (fila.Cells[5].Value is DateTime dtHora) horaStr = dtHora.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
                    else horaStr = (fila.Cells[5].Value?.ToString() ?? "");

                    string precioStr = "";
                    string itbisStr = "";
                    if (fila.Cells[6].Value != null) precioStr = Convert.ToDecimal(fila.Cells[6].Value).ToString(CultureInfo.InvariantCulture);
                    if (fila.Cells[7].Value != null) itbisStr = Convert.ToDecimal(fila.Cells[7].Value).ToString(CultureInfo.InvariantCulture);

                    // asegurar escapado si hay comas
                    string Line(string v) => v?.Replace("\"", "\"\"").Contains(",") == true ? $"\"{v}\"" : v;

                    string linea = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                        Line(fila.Cells[0].Value?.ToString() ?? ""),
                        Line(fila.Cells[1].Value?.ToString() ?? ""),
                        Line(fila.Cells[2].Value?.ToString() ?? ""),
                        Line(fila.Cells[3].Value?.ToString() ?? ""),
                        Line(fechaStr),
                        Line(horaStr),
                        Line(precioStr),
                        Line(itbisStr),
                        Line(fila.Cells[8].Value?.ToString() ?? ""),
                        Line(fila.Cells[9].Value?.ToString() ?? ""));

                    sb.AppendLine(linea);
                }
                File.WriteAllText(rutaArchivoActual, sb.ToString(), Encoding.UTF8);
                await Task.Delay(2000);
                labelGuardar.ForeColor = Color.Lime;
                labelGuardar.Text = "Guardado";
                FotoGuardando.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sincronizar con el archivo CSV: " + ex.Message, "Error de Guardado");
            }
        }
        private void ActualizarSugerenciasBusqueda()
        {
            comboBoxBuscar.Items.Clear();
            foreach (DataGridViewRow fila in dataGridViewDatos.Rows)
            {
                string id = fila.Cells["Clnid"].Value?.ToString() ?? "";
                string nombre = fila.Cells["ClnNombreTour"].Value?.ToString() ?? "";
                comboBoxBuscar.Items.Add($"{id} - {nombre}");
            }
        }
        private TimeSpan ObtenerDuracion(string pais)
        {
         
            {
                switch (pais)
                {
                    //Caribe (1–3 horas)
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

                    case "República Dominicana":
                        return TimeSpan.FromHours(0);

                    //Centroamérica (2–4 horas)
                    case "Panamá":
                    case "Costa Rica":
                    case "Nicaragua":
                    case "Honduras":
                    case "El Salvador":
                    case "Guatemala":
                    case "Belice":
                        return TimeSpan.FromHours(3);

                    //Norteamérica (4–6 horas)
                    case "Estados Unidos":
                    case "Canadá":
                    case "México":
                        return TimeSpan.FromHours(5);

                    //Sudamérica (5–9 horas)
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

                    //Europa (8–11 horas)
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

                        //África (10–14 horas)
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

                        //Medio Oriente (12–16 horas)
                        if (new[] {
                "Arabia Saudita","Emiratos Árabes Unidos","Catar","Kuwait",
                "Omán","Israel","Jordania","Líbano","Irak","Irán","Siria","Yemen"
            }.Contains(pais))
                            return TimeSpan.FromHours(14);

                        //Asia (16–25 horas)
                        if (new[] {
                "China","Japón","Corea del Sur","Corea del Norte","India",
                "Pakistán","Bangladés","Nepal","Sri Lanka","Tailandia",
                "Vietnam","Indonesia","Malasia","Singapur","Filipinas",
                "Mongolia","Kazajistán","Uzbekistán","Turkmenistán",
                "Tayikistán","Kirguistán","Laos","Camboya","Birmania","Bután"
            }.Contains(pais))
                            return TimeSpan.FromHours(20);

                        //Oceanía (20–30 horas)
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
        private void EjecutarBusqueda()
        {
            if (!string.IsNullOrWhiteSpace(comboBoxBuscar.Text))
            {
                string texto = comboBoxBuscar.Text;
                
                string idBuscado = texto.Contains("-") ? texto.Split('-')[0].Trim() : texto.Trim();

                foreach (DataGridViewRow fila in dataGridViewDatos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    
                    if (fila.Cells["Clnid"].Value?.ToString() == idBuscado)
                    {
                        dataGridViewDatos.CurrentCell = fila.Cells[0];
                        comboBoxBuscar.Focus();
                        textBoxNombre2.Text = fila.Cells["ClnNombreTour"].Value.ToString();
                        comboBoxPais2.Text = fila.Cells["ClnPais"].Value.ToString();
                        dtpFecha2.Value = (DateTime)fila.Cells["ClnFecha"].Value;
                        dtpHora2.Value  = (DateTime)fila.Cells["ClnHora"].Value;
                        numericUpDownPrecio2.Text = fila.Cells["ClnPrecio"].Value.ToString();
                        idSeleccionada = fila.Cells["Clnid"].Value.ToString();
                        richTextBoxMensaje.Clear();
                        richTextBoxMensaje.SelectionColor = Color.Black;
                        richTextBoxMensaje.AppendText("ID: ");
                        richTextBoxMensaje.SelectionColor = Color.Green;
                        richTextBoxMensaje.AppendText(idSeleccionada + " ");
                        richTextBoxMensaje.SelectionColor = Color.Black;
                        richTextBoxMensaje.AppendText("| Tour: ");
                        richTextBoxMensaje.SelectionColor = Color.Green;
                        richTextBoxMensaje.AppendText(fila.Cells["ClnNombreTour"].Value.ToString());
                        return;
                    }
                }
                MessageBox.Show("No se encontró ningún tour con el ID: " + idBuscado, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UcPrincipal_Load(object sender, EventArgs e)
        {
            comboBoxBuscar.Items.Clear();
            foreach (DataGridViewRow fila in dataGridViewDatos.Rows)
            {
                string id = fila.Cells["Clnid"].Value?.ToString() ?? "";
                string nombre = fila.Cells["ClnNombreTour"].Value?.ToString() ?? "";
                comboBoxBuscar.Items.Add($"{id} - {nombre}");
            }
            tlpAgregar.Height = tlpAgregar.MaximumSize.Height;
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
            comboBoxPais2.Items.AddRange(paises);
            comboBoxPais2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPais2.AutoCompleteSource = AutoCompleteSource.ListItems;
            // al añadir
            dataGridViewDatos.Columns["ClnFecha"].ValueType = typeof(DateTime);
            dataGridViewDatos.Columns["ClnHora"].ValueType = typeof(DateTime);
            dataGridViewDatos.Columns["ClnFecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewDatos.Columns["ClnHora"].DefaultCellStyle.Format  = "HH:mm";
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
            if (dataGridViewDatos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para editar.",
                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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
                if (valorEscrito <= 0 || valorEscrito > 10000000)
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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(numericUpDownPrecio.Text, out decimal valorEscrito))
            {
                if (valorEscrito <= 0 || valorEscrito > 10000000)
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
                    Fecha /*DateTime*/,
                    Hora /*DateTime*/,
                    Precio,
                    Itbis,
                    Tiempo,
                    Estado

                );
                ActualizarSugerenciasBusqueda();
                dataGridViewDatos.CurrentCell = null;
                dataGridViewDatos.ClearSelection();
                GuardarCambiosEnCSV();
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
                    GuardarCambiosEnCSV();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para borrar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //
        //Logica Para editar basicamente la misma que la de agregar
        //
        bool txtNombre2;
        bool Combopais2;
        bool PrecioInput2;
        

        private void textBoxNombre2_TextChanged(object sender, EventArgs e)
        {
            string VerficarNombre2 = textBoxNombre2.Text;
            if (string.IsNullOrWhiteSpace(VerficarNombre2))
            {
                labelMensajeNombre2.ForeColor = Color.Red;
                labelMensajeNombre2.Text = "Introduce no solo espacios";
                txtNombre2 = false;
            }
            else if (VerficarNombre2.Length < 4 || VerficarNombre2.Length > 15)
            {
                labelMensajeNombre2.ForeColor = Color.Red;
                labelMensajeNombre2.Text = "El nombre del tour debe tener entre 4 y 15 caracteres.";
                txtNombre2 = false;
            }
            else if (!Regex.IsMatch(VerficarNombre2, @"^[a-zA-Z0-9ñÑáéíóúÁÉÍÓÚüÜ_]+$"))
            {
                labelMensajeNombre2.ForeColor = Color.Red;
                labelMensajeNombre2.Text = "Solo se permiten letras,números o" + " '_' " + "(sin espacios ni símbolos)";
                txtNombre2 = false;
            }
            else
            {
                labelMensajeNombre2.Text = "";
                txtNombre2 = true;
            }
        }

        private void comboBoxPais2_TextChanged(object sender, EventArgs e)
        {
            string VerificarPais2 = comboBoxPais2.Text;
            if (string.IsNullOrWhiteSpace(VerificarPais2))
            {
                labelMensajePais2.ForeColor = Color.Red;
                labelMensajePais2.Text = "Introduce no solo espacios.";
                Combopais2 = false;
            }
            else if (!paises.Contains(VerificarPais2))
            {
                labelMensajePais2.ForeColor = Color.Red;
                labelMensajePais2.Text = "El pais que introdujiste no esta en nuestro sistema.";
                Combopais2 = false;
            }
            else
            {
                labelMensajePais2.Text = "";
                Combopais2 = true;
            }
        }

        private void numericUpDownPrecio2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void numericUpDownPrecio2_KeyUp(object sender, KeyEventArgs e)
        {
            if (decimal.TryParse(numericUpDownPrecio2.Text, out decimal valorEscrito2))
            {
                if (valorEscrito2 <= 0 || valorEscrito2 > 10000000)
                {
                    PrecioInput2 = false;
                    labelMensajePrecio2.Text = "Introduce un número entre 1 y 10,000,000";
                    labelMensajePrecio2.ForeColor = Color.Red;
                    labelMensajePrecio2.Visible = true;
                }
                else
                {
                    PrecioInput2 = true;
                    labelMensajePrecio2.Visible = false;
                }
            }
        }
        string idSeleccionada;

        private void dataGridViewDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewDatos.Rows[e.RowIndex];
                textBoxNombre2.Text = fila.Cells["ClnNombreTour"].Value.ToString();
                comboBoxPais2.Text = fila.Cells["ClnPais"].Value.ToString();
                dtpFecha2.Value = (DateTime)fila.Cells["ClnFecha"].Value;
                dtpHora2.Value = (DateTime)fila.Cells["ClnHora"].Value;
                numericUpDownPrecio2.Text = fila.Cells["ClnPrecio"].Value.ToString();
                idSeleccionada = fila.Cells["Clnid"].Value.ToString();
                richTextBoxMensaje.Clear();
                richTextBoxMensaje.SelectionColor = Color.Black;
                richTextBoxMensaje.AppendText("ID: ");
                richTextBoxMensaje.SelectionColor = Color.Green;
                richTextBoxMensaje.AppendText(idSeleccionada + " ");
                richTextBoxMensaje.SelectionColor = Color.Black;
                richTextBoxMensaje.AppendText("| Tour: ");
                richTextBoxMensaje.SelectionColor = Color.Green;
                richTextBoxMensaje.AppendText(fila.Cells["ClnNombreTour"].Value.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(numericUpDownPrecio2.Text, out decimal valorEscrito2))
            {
                if (valorEscrito2 <= 0 || valorEscrito2 > 10000000)
                {
                    PrecioInput2 = false;
                    labelMensajePrecio2.Text = "Introduce un número entre 1 y 10,000,000";
                    labelMensajePrecio2.ForeColor = Color.Red;
                    labelMensajePrecio2.Visible = true;
                }
                else
                {
                    PrecioInput2 = true;
                    labelMensajePrecio2.Visible = false;
                }
            }
            string VerficarNombre2 = textBoxNombre2.Text;
            if (string.IsNullOrWhiteSpace(VerficarNombre2))
            {
                labelMensajeNombre2.ForeColor = Color.Red;
                labelMensajeNombre2.Text = "Introduce no solo espacios";
                txtNombre2 = false;
            }
            else if (VerficarNombre2.Length < 4 || VerficarNombre2.Length > 15)
            {
                labelMensajeNombre2.ForeColor = Color.Red;
                labelMensajeNombre2.Text = "El nombre del tour debe tener entre 4 y 15 caracteres.";
                txtNombre2 = false;
            }
            else if (!Regex.IsMatch(VerficarNombre2, @"^[a-zA-Z0-9ñÑáéíóúÁÉÍÓÚüÜ_]+$"))
            {
                labelMensajeNombre2.ForeColor = Color.Red;
                labelMensajeNombre2.Text = "Solo se permiten letras,números o" + " '_' " + "(sin espacios ni símbolos)";
                txtNombre2 = false;
            }
            else
            {
                labelMensajeNombre2.Text = "";
                txtNombre2 = true;
            }
            string VerificarPais2 = comboBoxPais2.Text;
            if (string.IsNullOrWhiteSpace(VerificarPais2))
            {
                labelMensajePais2.ForeColor = Color.Red;
                labelMensajePais2.Text = "Introduce no solo espacios.";
                Combopais2 = false;
            }

            if (txtNombre2 == true && Combopais2 == true && PrecioInput2 == true)
            {
                if (dataGridViewDatos.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un tour de la tabla para editar.");
                    return;
                }
                // Obtenemos la fila actual (la que cargamos previamente en los TextBox)
                DataGridViewRow fila = dataGridViewDatos.CurrentRow;
                // Precio e ITBIS
                decimal Precio = numericUpDownPrecio2.Value;
                decimal Itbis = Precio * 0.18m;
                string Nombre = textBoxNombre2.Text;
                string Pais = comboBoxPais2.Text;
                // Calcular Fecha y Hora
                DateTime Fecha = dtpFecha2.Value.Date;
                DateTime Hora = dtpHora2.Value;
                string FechaForma = Fecha.ToString("dd/MM/yyyy");
                string HoraForma = Hora.ToString("HH:mm");
                // Lógica de Destino y Duración
                string Destino = "Aeropuerto de " + Pais;
                TimeSpan duracion = ObtenerDuracion(Pais);
                // Lógica de Estado (Vencida/Vigente)
                DateTime fechaHoraInicio = Fecha.Add(Hora.TimeOfDay);
                DateTime fechaHoraFin = fechaHoraInicio.Add(duracion);
                string Estado = DateTime.Now > fechaHoraFin ? "Vencida" : "Vigente";

                string Tiempo = duracion.TotalHours + " horas";
                fila.Cells["ClnNombreTour"].Value = Nombre;
                fila.Cells["ClnPais"].Value = Pais;
                fila.Cells["ClnDestino"].Value = Destino;
                fila.Cells["ClnFecha"].Value = Fecha;
                fila.Cells["ClnHora"].Value = Hora; 
                fila.Cells["ClnPrecio"].Value = Precio;
                fila.Cells["ClnITBIS"].Value = Itbis;
                fila.Cells["ClnDuracion"].Value = Tiempo;
                fila.Cells["ClnEstado"].Value = Estado;
                ActualizarSugerenciasBusqueda();
                dataGridViewDatos.CurrentCell = null;
                dataGridViewDatos.ClearSelection();
                MessageBox.Show("¡Tour actualizado con éxito!");
                GuardarCambiosEnCSV();

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
        }

        private void comboBoxBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EjecutarBusqueda();
        }

        private void comboBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EjecutarBusqueda();
                e.SuppressKeyPress = true;
            }

        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivo CSV (*.csv)|*.csv";
            guardarArchivo.Title = "Seleccione dónde guardar su lista de tours";
            guardarArchivo.FileName = "MisTours_" + DateTime.Now.ToString("dd-MM-yyyy");
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter archivo = new System.IO.StreamWriter(guardarArchivo.FileName, false, System.Text.Encoding.UTF8))
                    {
                        string encabezados = "";
                        foreach (DataGridViewColumn col in dataGridViewDatos.Columns)
                        {
                            encabezados += col.HeaderText + ",";
                        }
                        archivo.WriteLine(encabezados.TrimEnd(','));
                        foreach (DataGridViewRow fila in dataGridViewDatos.Rows)
                        {
                            string linea = "";
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                string valor = celda.FormattedValue?.ToString() ?? "";
                                valor = valor.Replace("\"", "\"\"");
                                if (valor.Contains(",") || valor.Contains("\"") || valor.Contains("\n"))
                                    valor = "\"" + valor + "\"";
                                linea += valor + ",";
                            }
                            archivo.WriteLine(linea.TrimEnd(','));
                            
                        }
                    }

                    MessageBox.Show("¡Archivo '" + System.IO.Path.GetFileName(guardarArchivo.FileName) + "' creado con éxito!",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el archivo: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
    
}
