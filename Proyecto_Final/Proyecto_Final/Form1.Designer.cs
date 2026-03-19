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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuprincipal));
            this.labelBarra = new System.Windows.Forms.Label();
            this.timerSalir = new System.Windows.Forms.Timer(this.components);
            this.tlpBarraTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelHome = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timerBarralaterar = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tlpBarralateral = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tlpBarraTitulo.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tlpBarralateral.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.labelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBarra_MouseDown);
            this.labelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBarra_MouseMove);
            this.labelBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelBarra_MouseUp);
            // 
            // timerSalir
            // 
            this.timerSalir.Interval = 10;
            this.timerSalir.Tick += new System.EventHandler(this.timerSalir_Tick);
            // 
            // tlpBarraTitulo
            // 
            this.tlpBarraTitulo.BackColor = System.Drawing.Color.Orange;
            this.tlpBarraTitulo.ColumnCount = 5;
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBarraTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpBarraTitulo.Controls.Add(this.labelBarra, 0, 0);
            this.tlpBarraTitulo.Controls.Add(this.buttonClose, 4, 0);
            this.tlpBarraTitulo.Controls.Add(this.buttonMaximizar, 3, 0);
            this.tlpBarraTitulo.Controls.Add(this.buttonMinimized, 2, 0);
            this.tlpBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraTitulo.Name = "tlpBarraTitulo";
            this.tlpBarraTitulo.RowCount = 1;
            this.tlpBarraTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarraTitulo.Size = new System.Drawing.Size(1009, 35);
            this.tlpBarraTitulo.TabIndex = 7;
            this.tlpBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpBarraTitulo_MouseDown);
            this.tlpBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlpBarraTitulo_MouseMove);
            this.tlpBarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlpBarraTitulo_MouseUp);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Orange;
            this.buttonClose.Location = new System.Drawing.Point(971, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 29);
            this.buttonClose.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonClose, "Cerrar");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximizar.BackgroundImage = global::Proyecto_Final.Properties.Resources.minimizar_signo__1_;
            this.buttonMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizar.ForeColor = System.Drawing.Color.Orange;
            this.buttonMaximizar.Location = new System.Drawing.Point(931, 3);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(34, 29);
            this.buttonMaximizar.TabIndex = 6;
            this.buttonMaximizar.UseVisualStyleBackColor = false;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimized.BackgroundImage")));
            this.buttonMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimized.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.ForeColor = System.Drawing.Color.Orange;
            this.buttonMinimized.Location = new System.Drawing.Point(891, 3);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(34, 29);
            this.buttonMinimized.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonMinimized, "Minimizar");
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.button1);
            this.panelHome.ForeColor = System.Drawing.Color.Transparent;
            this.panelHome.Location = new System.Drawing.Point(3, 52);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(199, 43);
            this.panelHome.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Proyecto_Final.Properties.Resources._3643769_building_home_house_main_menu_start_113416__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-28, -35);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 111);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerBarralaterar
            // 
            this.timerBarralaterar.Interval = 10;
            this.timerBarralaterar.Tick += new System.EventHandler(this.timerBarralaterar_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.ForeColor = System.Drawing.Color.Transparent;
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(197, 43);
            this.panelMenu.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Proyecto_Final.Properties.Resources.Menu_icon_icon_icons_com_71858;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-28, -35);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 111);
            this.button2.TabIndex = 10;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tlpBarralateral
            // 
            this.tlpBarralateral.BackColor = System.Drawing.Color.Yellow;
            this.tlpBarralateral.ColumnCount = 1;
            this.tlpBarralateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarralateral.Controls.Add(this.panelLogout, 0, 2);
            this.tlpBarralateral.Controls.Add(this.panelMenu, 0, 0);
            this.tlpBarralateral.Controls.Add(this.panelHome, 0, 1);
            this.tlpBarralateral.Controls.Add(this.panel1, 0, 4);
            this.tlpBarralateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpBarralateral.Location = new System.Drawing.Point(0, 35);
            this.tlpBarralateral.MaximumSize = new System.Drawing.Size(205, 0);
            this.tlpBarralateral.MinimumSize = new System.Drawing.Size(50, 0);
            this.tlpBarralateral.Name = "tlpBarralateral";
            this.tlpBarralateral.RowCount = 5;
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarralateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpBarralateral.Size = new System.Drawing.Size(205, 569);
            this.tlpBarralateral.TabIndex = 9;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.buttonAbout);
            this.panelLogout.ForeColor = System.Drawing.Color.Transparent;
            this.panelLogout.Location = new System.Drawing.Point(3, 101);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(199, 43);
            this.panelLogout.TabIndex = 14;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Yellow;
            this.buttonAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.Black;
            this.buttonAbout.Image = global::Proyecto_Final.Properties.Resources._4213426_about_description_help_info_information_notification_115427;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(-28, -35);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAbout.Size = new System.Drawing.Size(250, 111);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(3, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 36);
            this.panel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Proyecto_Final.Properties.Resources.out_log_icon_255959;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-28, -35);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 111);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cerrar sesión";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(205, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(804, 569);
            this.panelContenedor.TabIndex = 10;
            // 
            // FormMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 604);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.tlpBarralateral);
            this.Controls.Add(this.tlpBarraTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormMenuprincipal_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMenuprincipal_Resize);
            this.tlpBarraTitulo.ResumeLayout(false);
            this.tlpBarraTitulo.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.tlpBarralateral.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timerSalir;
        private System.Windows.Forms.Button buttonMaximizar;
        private System.Windows.Forms.TableLayoutPanel tlpBarraTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Timer timerBarralaterar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tlpBarralateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

