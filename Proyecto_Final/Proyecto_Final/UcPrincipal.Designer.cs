namespace Proyecto_Final
{
    partial class UcPrincipal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.Clnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNombreTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpAgregar = new System.Windows.Forms.TableLayoutPanel();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelMensajePais = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMensajePrecio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpEditar = new System.Windows.Forms.TableLayoutPanel();
            this.labelMensajeNombre2 = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.labelPaisDestino2 = new System.Windows.Forms.Label();
            this.labelFecha2 = new System.Windows.Forms.Label();
            this.labelHora2 = new System.Windows.Forms.Label();
            this.labelPrecio2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.numericUpDownPrecio2 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPais2 = new System.Windows.Forms.ComboBox();
            this.dtpHora2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.labelMensajePais2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMensajePrecio2 = new System.Windows.Forms.Label();
            this.richTextBoxMensaje = new System.Windows.Forms.RichTextBox();
            this.labelEditando = new System.Windows.Forms.Label();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerAnimacion2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.labelMensajeNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.tlpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
            this.panel1.SuspendLayout();
            this.tlpEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 642F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLupa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBuscar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEliminar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEditar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonExportar, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(515, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 40);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(37, 12);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(472, 21);
            this.comboBoxBuscar.TabIndex = 4;
            this.comboBoxBuscar.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBuscar_SelectionChangeCommitted);
            this.comboBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxBuscar_KeyDown);
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            this.dataGridViewDatos.AllowUserToDeleteRows = false;
            this.dataGridViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clnid,
            this.ClnNombreTour,
            this.ClnPais,
            this.ClnDestino,
            this.ClnFecha,
            this.ClnHora,
            this.ClnPrecio,
            this.ClnITBIS,
            this.ClnDuracion,
            this.ClnEstado});
            this.dataGridViewDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDatos.Location = new System.Drawing.Point(0, 600);
            this.dataGridViewDatos.MultiSelect = false;
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.ReadOnly = true;
            this.dataGridViewDatos.RowHeadersWidth = 72;
            this.dataGridViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatos.Size = new System.Drawing.Size(1173, 127);
            this.dataGridViewDatos.TabIndex = 1;
            this.dataGridViewDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatos_CellClick);
            // 
            // Clnid
            // 
            this.Clnid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clnid.HeaderText = "ID";
            this.Clnid.MinimumWidth = 9;
            this.Clnid.Name = "Clnid";
            this.Clnid.ReadOnly = true;
            // 
            // ClnNombreTour
            // 
            this.ClnNombreTour.HeaderText = "Nombre";
            this.ClnNombreTour.MinimumWidth = 9;
            this.ClnNombreTour.Name = "ClnNombreTour";
            this.ClnNombreTour.ReadOnly = true;
            // 
            // ClnPais
            // 
            this.ClnPais.HeaderText = "País";
            this.ClnPais.MinimumWidth = 9;
            this.ClnPais.Name = "ClnPais";
            this.ClnPais.ReadOnly = true;
            // 
            // ClnDestino
            // 
            this.ClnDestino.HeaderText = "Destino";
            this.ClnDestino.MinimumWidth = 9;
            this.ClnDestino.Name = "ClnDestino";
            this.ClnDestino.ReadOnly = true;
            // 
            // ClnFecha
            // 
            this.ClnFecha.HeaderText = "Fecha";
            this.ClnFecha.MinimumWidth = 9;
            this.ClnFecha.Name = "ClnFecha";
            this.ClnFecha.ReadOnly = true;
            // 
            // ClnHora
            // 
            this.ClnHora.HeaderText = "Hora";
            this.ClnHora.MinimumWidth = 9;
            this.ClnHora.Name = "ClnHora";
            this.ClnHora.ReadOnly = true;
            // 
            // ClnPrecio
            // 
            this.ClnPrecio.HeaderText = "Precio";
            this.ClnPrecio.MinimumWidth = 9;
            this.ClnPrecio.Name = "ClnPrecio";
            this.ClnPrecio.ReadOnly = true;
            // 
            // ClnITBIS
            // 
            this.ClnITBIS.HeaderText = "ITBIS";
            this.ClnITBIS.MinimumWidth = 9;
            this.ClnITBIS.Name = "ClnITBIS";
            this.ClnITBIS.ReadOnly = true;
            // 
            // ClnDuracion
            // 
            this.ClnDuracion.HeaderText = "Duración";
            this.ClnDuracion.MinimumWidth = 9;
            this.ClnDuracion.Name = "ClnDuracion";
            this.ClnDuracion.ReadOnly = true;
            // 
            // ClnEstado
            // 
            this.ClnEstado.HeaderText = "Estado";
            this.ClnEstado.MinimumWidth = 9;
            this.ClnEstado.Name = "ClnEstado";
            this.ClnEstado.ReadOnly = true;
            // 
            // tlpAgregar
            // 
            this.tlpAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.tlpAgregar.ColumnCount = 4;
            this.tlpAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgregar.Controls.Add(this.labelNombre, 1, 1);
            this.tlpAgregar.Controls.Add(this.textBoxNombre, 2, 1);
            this.tlpAgregar.Controls.Add(this.label8, 2, 0);
            this.tlpAgregar.Controls.Add(this.buttonAgregar, 2, 9);
            this.tlpAgregar.Controls.Add(this.numericUpDownPrecio, 2, 7);
            this.tlpAgregar.Controls.Add(this.labelPrecio, 1, 7);
            this.tlpAgregar.Controls.Add(this.labelMensajePrecio, 2, 8);
            this.tlpAgregar.Controls.Add(this.dtpHora, 2, 6);
            this.tlpAgregar.Controls.Add(this.labelHora, 1, 6);
            this.tlpAgregar.Controls.Add(this.dtpFecha, 2, 5);
            this.tlpAgregar.Controls.Add(this.labelFecha, 1, 5);
            this.tlpAgregar.Controls.Add(this.comboBoxPais, 2, 3);
            this.tlpAgregar.Controls.Add(this.labelPais, 1, 3);
            this.tlpAgregar.Controls.Add(this.labelMensajePais, 2, 4);
            this.tlpAgregar.Controls.Add(this.labelMensajeNombre, 2, 2);
            this.tlpAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAgregar.Location = new System.Drawing.Point(0, 300);
            this.tlpAgregar.MaximumSize = new System.Drawing.Size(0, 300);
            this.tlpAgregar.Name = "tlpAgregar";
            this.tlpAgregar.RowCount = 6;
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tlpAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregar.Size = new System.Drawing.Size(1173, 300);
            this.tlpAgregar.TabIndex = 2;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(342, 81);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(83, 13);
            this.labelPais.TabIndex = 1;
            this.labelPais.Text = "País de Destino";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(342, 132);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(75, 13);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha del tour";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(342, 165);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(68, 13);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "Hora del tour";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(342, 207);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(437, 262);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 32);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // numericUpDownPrecio
            // 
            this.numericUpDownPrecio.DecimalPlaces = 2;
            this.numericUpDownPrecio.Location = new System.Drawing.Point(437, 210);
            this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownPrecio.Name = "numericUpDownPrecio";
            this.numericUpDownPrecio.Size = new System.Drawing.Size(392, 20);
            this.numericUpDownPrecio.TabIndex = 11;
            this.numericUpDownPrecio.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.numericUpDownPrecio, "Introduce el precio.");
            this.numericUpDownPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownPrecio_KeyPress);
            this.numericUpDownPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownPrecio_KeyUp);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(437, 84);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(392, 21);
            this.comboBoxPais.TabIndex = 15;
            this.comboBoxPais.TextChanged += new System.EventHandler(this.comboBoxPais_TextChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm ";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(437, 168);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(392, 20);
            this.dtpHora.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(437, 135);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(392, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // labelMensajePais
            // 
            this.labelMensajePais.Location = new System.Drawing.Point(437, 110);
            this.labelMensajePais.Name = "labelMensajePais";
            this.labelMensajePais.Size = new System.Drawing.Size(268, 22);
            this.labelMensajePais.TabIndex = 19;
            this.labelMensajePais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(437, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 33);
            this.label8.TabIndex = 21;
            this.label8.Text = "Agregar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMensajePrecio
            // 
            this.labelMensajePrecio.Location = new System.Drawing.Point(437, 232);
            this.labelMensajePrecio.Name = "labelMensajePrecio";
            this.labelMensajePrecio.Size = new System.Drawing.Size(394, 17);
            this.labelMensajePrecio.TabIndex = 22;
            this.labelMensajePrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridViewDatos);
            this.panel1.Controls.Add(this.tlpAgregar);
            this.panel1.Controls.Add(this.tlpEditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 727);
            this.panel1.TabIndex = 3;
            // 
            // tlpEditar
            // 
            this.tlpEditar.BackColor = System.Drawing.SystemColors.Control;
            this.tlpEditar.ColumnCount = 4;
            this.tlpEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEditar.Controls.Add(this.labelNombre2, 1, 2);
            this.tlpEditar.Controls.Add(this.labelPaisDestino2, 1, 4);
            this.tlpEditar.Controls.Add(this.labelFecha2, 1, 6);
            this.tlpEditar.Controls.Add(this.labelHora2, 1, 7);
            this.tlpEditar.Controls.Add(this.labelPrecio2, 1, 8);
            this.tlpEditar.Controls.Add(this.button2, 1, 10);
            this.tlpEditar.Controls.Add(this.button3, 2, 10);
            this.tlpEditar.Controls.Add(this.textBoxNombre2, 2, 2);
            this.tlpEditar.Controls.Add(this.numericUpDownPrecio2, 2, 8);
            this.tlpEditar.Controls.Add(this.comboBoxPais2, 2, 4);
            this.tlpEditar.Controls.Add(this.dtpHora2, 2, 7);
            this.tlpEditar.Controls.Add(this.dtpFecha2, 2, 6);
            this.tlpEditar.Controls.Add(this.label9, 2, 0);
            this.tlpEditar.Controls.Add(this.richTextBoxMensaje, 2, 1);
            this.tlpEditar.Controls.Add(this.labelEditando, 1, 1);
            this.tlpEditar.Controls.Add(this.labelMensajeNombre2, 2, 3);
            this.tlpEditar.Controls.Add(this.labelMensajePais2, 2, 5);
            this.tlpEditar.Controls.Add(this.labelMensajePrecio2, 2, 9);
            this.tlpEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEditar.Location = new System.Drawing.Point(0, 0);
            this.tlpEditar.MaximumSize = new System.Drawing.Size(0, 300);
            this.tlpEditar.Name = "tlpEditar";
            this.tlpEditar.RowCount = 11;
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpEditar.Size = new System.Drawing.Size(1173, 300);
            this.tlpEditar.TabIndex = 5;
            // 
            // labelMensajeNombre2
            // 
            this.labelMensajeNombre2.Location = new System.Drawing.Point(434, 85);
            this.labelMensajeNombre2.Name = "labelMensajeNombre2";
            this.labelMensajeNombre2.Size = new System.Drawing.Size(394, 16);
            this.labelMensajeNombre2.TabIndex = 20;
            this.labelMensajeNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombre2
            // 
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNombre2.Location = new System.Drawing.Point(344, 61);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(82, 24);
            this.labelNombre2.TabIndex = 0;
            this.labelNombre2.Text = "Nombre del tour";
            // 
            // labelPaisDestino2
            // 
            this.labelPaisDestino2.AutoSize = true;
            this.labelPaisDestino2.Location = new System.Drawing.Point(344, 101);
            this.labelPaisDestino2.Name = "labelPaisDestino2";
            this.labelPaisDestino2.Size = new System.Drawing.Size(83, 13);
            this.labelPaisDestino2.TabIndex = 1;
            this.labelPaisDestino2.Text = "País de Destino";
            // 
            // labelFecha2
            // 
            this.labelFecha2.AutoSize = true;
            this.labelFecha2.Location = new System.Drawing.Point(344, 145);
            this.labelFecha2.Name = "labelFecha2";
            this.labelFecha2.Size = new System.Drawing.Size(75, 13);
            this.labelFecha2.TabIndex = 2;
            this.labelFecha2.Text = "Fecha del tour";
            // 
            // labelHora2
            // 
            this.labelHora2.AutoSize = true;
            this.labelHora2.Location = new System.Drawing.Point(344, 181);
            this.labelHora2.Name = "labelHora2";
            this.labelHora2.Size = new System.Drawing.Size(68, 13);
            this.labelHora2.TabIndex = 3;
            this.labelHora2.Text = "Hora del tour";
            // 
            // labelPrecio2
            // 
            this.labelPrecio2.AutoSize = true;
            this.labelPrecio2.Location = new System.Drawing.Point(344, 219);
            this.labelPrecio2.Name = "labelPrecio2";
            this.labelPrecio2.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio2.TabIndex = 4;
            this.labelPrecio2.Text = "Precio";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(344, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(434, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxNombre2.Location = new System.Drawing.Point(434, 64);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(392, 20);
            this.textBoxNombre2.TabIndex = 7;
            this.textBoxNombre2.TextChanged += new System.EventHandler(this.textBoxNombre2_TextChanged);
            // 
            // numericUpDownPrecio2
            // 
            this.numericUpDownPrecio2.DecimalPlaces = 2;
            this.numericUpDownPrecio2.Location = new System.Drawing.Point(434, 222);
            this.numericUpDownPrecio2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPrecio2.Name = "numericUpDownPrecio2";
            this.numericUpDownPrecio2.Size = new System.Drawing.Size(392, 20);
            this.numericUpDownPrecio2.TabIndex = 11;
            this.numericUpDownPrecio2.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.numericUpDownPrecio2, "Introduce el precio.");
            this.numericUpDownPrecio2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrecio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownPrecio2_KeyPress);
            this.numericUpDownPrecio2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownPrecio2_KeyUp);
            // 
            // comboBoxPais2
            // 
            this.comboBoxPais2.FormattingEnabled = true;
            this.comboBoxPais2.Location = new System.Drawing.Point(434, 104);
            this.comboBoxPais2.Name = "comboBoxPais2";
            this.comboBoxPais2.Size = new System.Drawing.Size(392, 21);
            this.comboBoxPais2.TabIndex = 15;
            this.comboBoxPais2.TextChanged += new System.EventHandler(this.comboBoxPais2_TextChanged);
            // 
            // dtpHora2
            // 
            this.dtpHora2.CustomFormat = "HH:mm ";
            this.dtpHora2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora2.Location = new System.Drawing.Point(434, 184);
            this.dtpHora2.Name = "dtpHora2";
            this.dtpHora2.ShowUpDown = true;
            this.dtpHora2.Size = new System.Drawing.Size(392, 20);
            this.dtpHora2.TabIndex = 16;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(434, 148);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(392, 20);
            this.dtpFecha2.TabIndex = 17;
            // 
            // labelMensajePais2
            // 
            this.labelMensajePais2.Location = new System.Drawing.Point(434, 127);
            this.labelMensajePais2.Name = "labelMensajePais2";
            this.labelMensajePais2.Size = new System.Drawing.Size(392, 18);
            this.labelMensajePais2.TabIndex = 19;
            this.labelMensajePais2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(434, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Editar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMensajePrecio2
            // 
            this.labelMensajePrecio2.Location = new System.Drawing.Point(434, 247);
            this.labelMensajePrecio2.Name = "labelMensajePrecio2";
            this.labelMensajePrecio2.Size = new System.Drawing.Size(394, 18);
            this.labelMensajePrecio2.TabIndex = 23;
            this.labelMensajePrecio2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxMensaje
            // 
            this.richTextBoxMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMensaje.Location = new System.Drawing.Point(434, 36);
            this.richTextBoxMensaje.Name = "richTextBoxMensaje";
            this.richTextBoxMensaje.ReadOnly = true;
            this.richTextBoxMensaje.Size = new System.Drawing.Size(394, 22);
            this.richTextBoxMensaje.TabIndex = 23;
            this.richTextBoxMensaje.Text = "";
            // 
            // labelEditando
            // 
            this.labelEditando.AutoSize = true;
            this.labelEditando.Location = new System.Drawing.Point(344, 33);
            this.labelEditando.Name = "labelEditando";
            this.labelEditando.Size = new System.Drawing.Size(52, 13);
            this.labelEditando.TabIndex = 24;
            this.labelEditando.Text = "Editando:";
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Interval = 15;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 0;
            // 
            // timerAnimacion2
            // 
            this.timerAnimacion2.Interval = 10;
            this.timerAnimacion2.Tick += new System.EventHandler(this.timerAnimacion2_Tick);
            // 
            // pictureBoxLupa
            // 
            this.pictureBoxLupa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLupa.Image = global::Proyecto_Final.Properties.Resources.searcher_magnifyng_glass_search_locate_find_icon_123813;
            this.pictureBoxLupa.Location = new System.Drawing.Point(3, 10);
            this.pictureBoxLupa.Name = "pictureBoxLupa";
            this.pictureBoxLupa.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLupa.TabIndex = 0;
            this.pictureBoxLupa.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::Proyecto_Final.Properties.Resources.agregar;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(39, 30);
            this.buttonAdd.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonAdd, "Agregar");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::Proyecto_Final.Properties.Resources.basura;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Location = new System.Drawing.Point(93, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(36, 30);
            this.buttonEliminar.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonEliminar, "Eliminar");
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = global::Proyecto_Final.Properties.Resources.editar;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(48, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(39, 30);
            this.buttonEditar.TabIndex = 4;
            this.toolTip.SetToolTip(this.buttonEditar, "Editar");
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackgroundImage = global::Proyecto_Final.Properties.Resources.exportacion_de_archivos;
            this.buttonExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Location = new System.Drawing.Point(138, 3);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(39, 30);
            this.buttonExportar.TabIndex = 5;
            this.toolTip.SetToolTip(this.buttonExportar, "Exportar");
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // labelMensajeNombre
            // 
            this.labelMensajeNombre.Location = new System.Drawing.Point(437, 59);
            this.labelMensajeNombre.Name = "labelMensajeNombre";
            this.labelMensajeNombre.Size = new System.Drawing.Size(268, 22);
            this.labelMensajeNombre.TabIndex = 20;
            this.labelMensajeNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxNombre.Location = new System.Drawing.Point(437, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(392, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNombre.Location = new System.Drawing.Point(342, 35);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(82, 24);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre del tour";
            // 
            // UcPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UcPrincipal";
            this.Size = new System.Drawing.Size(1173, 770);
            this.Load += new System.EventHandler(this.UcPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.tlpAgregar.ResumeLayout(false);
            this.tlpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tlpEditar.ResumeLayout(false);
            this.tlpEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.TableLayoutPanel tlpAgregar;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label labelMensajePais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNombreTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnITBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEstado;
        private System.Windows.Forms.TableLayoutPanel tlpEditar;
        private System.Windows.Forms.Label labelMensajeNombre2;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelPaisDestino2;
        private System.Windows.Forms.Label labelFecha2;
        private System.Windows.Forms.Label labelHora2;
        private System.Windows.Forms.Label labelPrecio2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecio2;
        private System.Windows.Forms.ComboBox comboBoxPais2;
        private System.Windows.Forms.DateTimePicker dtpHora2;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label labelMensajePais2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerAnimacion2;
        private System.Windows.Forms.Label labelMensajePrecio;
        private System.Windows.Forms.Label labelMensajePrecio2;
        private System.Windows.Forms.Label labelEditando;
        private System.Windows.Forms.RichTextBox richTextBoxMensaje;
        private System.Windows.Forms.PictureBox pictureBoxLupa;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelMensajeNombre;
    }
}
