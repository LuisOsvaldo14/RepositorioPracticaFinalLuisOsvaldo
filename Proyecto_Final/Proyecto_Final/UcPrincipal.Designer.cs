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
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMensajeNombre = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelMensajePais = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpAgregar = new System.Windows.Forms.FlowLayoutPanel();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
            this.panel1.SuspendLayout();
            this.flpAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLupa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 46);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(37, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 20);
            this.textBox1.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBox1, "Buscar");
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.Controls.Add(this.buttonExportar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEliminar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEditar, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(497, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 40);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackgroundImage = global::Proyecto_Final.Properties.Resources.exportacion_de_archivos;
            this.buttonExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Location = new System.Drawing.Point(93, 3);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(39, 30);
            this.buttonExportar.TabIndex = 5;
            this.toolTip.SetToolTip(this.buttonExportar, "Exportar");
            this.buttonExportar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::Proyecto_Final.Properties.Resources.basura;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Location = new System.Drawing.Point(48, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(36, 30);
            this.buttonEliminar.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonEliminar, "Eliminar");
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
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
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = global::Proyecto_Final.Properties.Resources.editar;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(138, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(39, 30);
            this.buttonEditar.TabIndex = 4;
            this.toolTip.SetToolTip(this.buttonEditar, "Editar");
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            this.dataGridViewDatos.AllowUserToDeleteRows = false;
            this.dataGridViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatos.BackgroundColor = System.Drawing.Color.White;
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
            this.dataGridViewDatos.Location = new System.Drawing.Point(0, 214);
            this.dataGridViewDatos.MultiSelect = false;
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.ReadOnly = true;
            this.dataGridViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatos.Size = new System.Drawing.Size(804, 309);
            this.dataGridViewDatos.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelMensajeNombre, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPais, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelFecha, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelHora, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelPrecio, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonAgregar, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownPrecio, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPais, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpHora, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpFecha, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelMensajePais, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 222);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelMensajeNombre
            // 
            this.labelMensajeNombre.Location = new System.Drawing.Point(495, 0);
            this.labelMensajeNombre.Name = "labelMensajeNombre";
            this.labelMensajeNombre.Size = new System.Drawing.Size(268, 24);
            this.labelMensajeNombre.TabIndex = 20;
            this.labelMensajeNombre.Text = "label2";
            this.labelMensajeNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNombre.Location = new System.Drawing.Point(3, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(82, 34);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre del tour";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(3, 34);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(83, 13);
            this.labelPais.TabIndex = 1;
            this.labelPais.Text = "País de Destino";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(3, 68);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(75, 13);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha del tour";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(3, 102);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(68, 13);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "Hora del tour";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(3, 136);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(96, 173);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 27);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxNombre.Location = new System.Drawing.Point(96, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(392, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // numericUpDownPrecio
            // 
            this.numericUpDownPrecio.DecimalPlaces = 2;
            this.numericUpDownPrecio.Location = new System.Drawing.Point(96, 139);
            this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPrecio.Minimum = new decimal(new int[] {
            1,
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
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(96, 37);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(392, 21);
            this.comboBoxPais.TabIndex = 15;
            this.comboBoxPais.TextChanged += new System.EventHandler(this.comboBoxPais_TextChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm ";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(96, 105);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(392, 20);
            this.dtpHora.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(96, 71);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(392, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // labelMensajePais
            // 
            this.labelMensajePais.Location = new System.Drawing.Point(495, 34);
            this.labelMensajePais.Name = "labelMensajePais";
            this.labelMensajePais.Size = new System.Drawing.Size(268, 24);
            this.labelMensajePais.TabIndex = 19;
            this.labelMensajePais.Text = "label2";
            this.labelMensajePais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridViewDatos);
            this.panel1.Controls.Add(this.flpAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 523);
            this.panel1.TabIndex = 3;
            // 
            // flpAgregar
            // 
            this.flpAgregar.Controls.Add(this.tableLayoutPanel2);
            this.flpAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpAgregar.Location = new System.Drawing.Point(0, 0);
            this.flpAgregar.MaximumSize = new System.Drawing.Size(0, 214);
            this.flpAgregar.Name = "flpAgregar";
            this.flpAgregar.Size = new System.Drawing.Size(804, 214);
            this.flpAgregar.TabIndex = 4;
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Interval = 10;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 0;
            // 
            // Clnid
            // 
            this.Clnid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clnid.HeaderText = "ID";
            this.Clnid.Name = "Clnid";
            this.Clnid.ReadOnly = true;
            // 
            // ClnNombreTour
            // 
            this.ClnNombreTour.HeaderText = "Nombre";
            this.ClnNombreTour.Name = "ClnNombreTour";
            this.ClnNombreTour.ReadOnly = true;
            // 
            // ClnPais
            // 
            this.ClnPais.HeaderText = "País";
            this.ClnPais.Name = "ClnPais";
            this.ClnPais.ReadOnly = true;
            // 
            // ClnDestino
            // 
            this.ClnDestino.HeaderText = "Destino";
            this.ClnDestino.Name = "ClnDestino";
            this.ClnDestino.ReadOnly = true;
            // 
            // ClnFecha
            // 
            this.ClnFecha.HeaderText = "Fecha";
            this.ClnFecha.Name = "ClnFecha";
            this.ClnFecha.ReadOnly = true;
            // 
            // ClnHora
            // 
            this.ClnHora.HeaderText = "Hora";
            this.ClnHora.Name = "ClnHora";
            this.ClnHora.ReadOnly = true;
            // 
            // ClnPrecio
            // 
            this.ClnPrecio.HeaderText = "Precio";
            this.ClnPrecio.Name = "ClnPrecio";
            this.ClnPrecio.ReadOnly = true;
            // 
            // ClnITBIS
            // 
            this.ClnITBIS.HeaderText = "ITBIS";
            this.ClnITBIS.Name = "ClnITBIS";
            this.ClnITBIS.ReadOnly = true;
            // 
            // ClnDuracion
            // 
            this.ClnDuracion.HeaderText = "Duración";
            this.ClnDuracion.Name = "ClnDuracion";
            this.ClnDuracion.ReadOnly = true;
            // 
            // ClnEstado
            // 
            this.ClnEstado.HeaderText = "Estado";
            this.ClnEstado.Name = "ClnEstado";
            this.ClnEstado.ReadOnly = true;
            // 
            // UcPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UcPrincipal";
            this.Size = new System.Drawing.Size(804, 569);
            this.Load += new System.EventHandler(this.UcPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flpAgregar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxLupa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpAgregar;
        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label labelMensajePais;
        private System.Windows.Forms.Label labelMensajeNombre;
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
    }
}
