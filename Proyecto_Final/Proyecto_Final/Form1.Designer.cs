namespace Proyecto_Final
{
    partial class FormMenuprincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelBarra = new System.Windows.Forms.Label();
            this.timerSalir = new System.Windows.Forms.Timer(this.components);
            this.tlpBarraTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timerBarralaterar = new System.Windows.Forms.Timer(this.components);
            this.tlpBarralateral = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tlpBarraTitulo.SuspendLayout();
            this.tlpBarralateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBarra
            // 
            this.labelBarra.AutoSize = true;
            this.labelBarra.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBarra.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarra.Location = new System.Drawing.Point(3, 0);
            this.labelBarra.Name = "labelBarra";
            this.labelBarra.Size = new System.Drawing.Size(101, 35);
            this.labelBarra.TabIndex = 2;
            this.labelBarra.Text = "No Limits";
            this.labelBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSalir
            // 
            this.timerSalir.Interval = 10;
            this.timerSalir.Tick += new System.EventHandler(this.timerSalir_Tick);
            // 
            // tlpBarraTitulo
            // 
            this.tlpBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.tlpBarraTitulo.ColumnCount = 5;
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpBarraTitulo.Controls.Add(this.guna2ControlBox1, 4, 0);
            this.tlpBarraTitulo.Controls.Add(this.labelBarra, 0, 0);
            this.tlpBarraTitulo.Controls.Add(this.guna2ControlBox2, 3, 0);
            this.tlpBarraTitulo.Controls.Add(this.guna2ControlBox3, 2, 0);
            this.tlpBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraTitulo.Name = "tlpBarraTitulo";
            this.tlpBarraTitulo.RowCount = 1;
            this.tlpBarraTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarraTitulo.Size = new System.Drawing.Size(837, 35);
            this.tlpBarraTitulo.TabIndex = 7;
            this.tlpBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpBarraTitulo_MouseDown);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(796, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 33);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(755, 1);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(38, 33);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(715, 1);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(38, 33);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Proyecto_Final.Properties.Resources._3643769_building_home_house_main_menu_start_113416__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // timerBarralaterar
            // 
            this.timerBarralaterar.Interval = 10;
            // 
            // tlpBarralateral
            // 
            this.tlpBarralateral.BackColor = System.Drawing.Color.SlateGray;
            this.tlpBarralateral.ColumnCount = 1;
            this.tlpBarralateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarralateral.Controls.Add(this.button3, 0, 5);
            this.tlpBarralateral.Controls.Add(this.button1, 0, 0);
            this.tlpBarralateral.Controls.Add(this.buttonAbout, 0, 1);
            this.tlpBarralateral.Controls.Add(this.buttonConfiguracion, 0, 2);
            this.tlpBarralateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpBarralateral.Location = new System.Drawing.Point(0, 35);
            this.tlpBarralateral.MaximumSize = new System.Drawing.Size(205, 0);
            this.tlpBarralateral.MinimumSize = new System.Drawing.Size(50, 0);
            this.tlpBarralateral.Name = "tlpBarralateral";
            this.tlpBarralateral.RowCount = 6;
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.Size = new System.Drawing.Size(129, 496);
            this.tlpBarralateral.TabIndex = 9;

            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Proyecto_Final.Properties.Resources.out_log_icon_255959;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cerrar sesión";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.Black;
            this.buttonAbout.Image = global::Proyecto_Final.Properties.Resources._4213426_about_description_help_info_information_notification_115427;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(3, 52);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(123, 43);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            this.buttonAbout.MouseEnter += new System.EventHandler(this.buttonAbout_MouseEnter);
            this.buttonAbout.MouseLeave += new System.EventHandler(this.buttonAbout_MouseLeave);
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.SlateGray;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.buttonConfiguracion.Image = global::Proyecto_Final.Properties.Resources.configuracion;
            this.buttonConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfiguracion.Location = new System.Drawing.Point(3, 101);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(123, 43);
            this.buttonConfiguracion.TabIndex = 10;
            this.buttonConfiguracion.Text = "Configuración";
            this.buttonConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.MouseEnter += new System.EventHandler(this.buttonConfiguracion_MouseEnter);
            this.buttonConfiguracion.MouseLeave += new System.EventHandler(this.buttonConfiguracion_MouseLeave);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(129, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(708, 496);
            this.panelContenedor.TabIndex = 10;
            // 
            // FormMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 531);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.tlpBarralateral);
            this.Controls.Add(this.tlpBarraTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(606, 362);
            this.Name = "FormMenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormMenuprincipal_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpBarraTitulo.ResumeLayout(false);
            this.tlpBarraTitulo.PerformLayout();
            this.tlpBarralateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.Timer timerSalir;
        private System.Windows.Forms.TableLayoutPanel tlpBarraTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerBarralaterar;
        private System.Windows.Forms.TableLayoutPanel tlpBarralateral;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonConfiguracion;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

