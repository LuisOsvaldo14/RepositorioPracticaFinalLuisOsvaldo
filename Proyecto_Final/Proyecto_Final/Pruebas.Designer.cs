namespace Proyecto_Final
{
    partial class Pruebas
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
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1328, 222);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelMensajeNombre
            // 
            this.labelMensajeNombre.Location = new System.Drawing.Point(495, 0);
            this.labelMensajeNombre.Name = "labelMensajeNombre";
            this.labelMensajeNombre.Size = new System.Drawing.Size(268, 24);
            this.labelMensajeNombre.TabIndex = 20;
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
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxNombre.Location = new System.Drawing.Point(96, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(392, 20);
            this.textBoxNombre.TabIndex = 7;
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
            this.labelMensajePais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Pruebas";
            this.Size = new System.Drawing.Size(1328, 666);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelMensajeNombre;
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
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label labelMensajePais;
    }
}
