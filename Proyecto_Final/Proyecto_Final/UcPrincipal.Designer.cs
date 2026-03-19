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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 485F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(37, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridViewDatos
            // 
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
            this.dataGridViewDatos.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.Size = new System.Drawing.Size(804, 532);
            this.dataGridViewDatos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.searcher_magnifyng_glass_search_locate_find_icon_123813;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::Proyecto_Final.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(281, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(35, 31);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // Clnid
            // 
            this.Clnid.HeaderText = "ID";
            this.Clnid.Name = "Clnid";
            // 
            // ClnNombreTour
            // 
            this.ClnNombreTour.HeaderText = "Nombre";
            this.ClnNombreTour.Name = "ClnNombreTour";
            // 
            // ClnPais
            // 
            this.ClnPais.HeaderText = "País";
            this.ClnPais.Name = "ClnPais";
            // 
            // ClnDestino
            // 
            this.ClnDestino.HeaderText = "Destino";
            this.ClnDestino.Name = "ClnDestino";
            // 
            // ClnFecha
            // 
            this.ClnFecha.HeaderText = "Fecha";
            this.ClnFecha.Name = "ClnFecha";
            // 
            // ClnHora
            // 
            this.ClnHora.HeaderText = "Hora";
            this.ClnHora.Name = "ClnHora";
            // 
            // ClnPrecio
            // 
            this.ClnPrecio.HeaderText = "Precio";
            this.ClnPrecio.Name = "ClnPrecio";
            // 
            // ClnITBIS
            // 
            this.ClnITBIS.HeaderText = "ITBIS";
            this.ClnITBIS.Name = "ClnITBIS";
            // 
            // ClnDuracion
            // 
            this.ClnDuracion.HeaderText = "Duración";
            this.ClnDuracion.Name = "ClnDuracion";
            // 
            // ClnEstado
            // 
            this.ClnEstado.HeaderText = "Estado";
            this.ClnEstado.Name = "ClnEstado";
            // 
            // UcPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewDatos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UcPrincipal";
            this.Size = new System.Drawing.Size(804, 569);
            this.Load += new System.EventHandler(this.UcPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
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
