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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerBarralaterar = new System.Windows.Forms.Timer(this.components);
            this.tlpBarralateral = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonHome = new Guna.UI2.WinForms.Guna2Button();
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
            this.tlpBarraTitulo.Size = new System.Drawing.Size(1039, 35);
            this.tlpBarraTitulo.TabIndex = 7;
            this.tlpBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpBarraTitulo_MouseDown);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(998, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 33);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(957, 1);
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(917, 1);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(38, 33);
            this.guna2ControlBox3.TabIndex = 4;
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
            this.tlpBarralateral.Controls.Add(this.ButtonLogout, 0, 5);
            this.tlpBarralateral.Controls.Add(this.ButtonHome, 0, 0);
            this.tlpBarralateral.Controls.Add(this.guna2Button2, 0, 1);
            this.tlpBarralateral.Controls.Add(this.guna2Button3, 0, 2);
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
            this.tlpBarralateral.Size = new System.Drawing.Size(129, 741);
            this.tlpBarralateral.TabIndex = 9;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = global::Proyecto_Final.Properties.Resources.toppng_com_icono_de_avion_980x978;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button3.Location = new System.Drawing.Point(3, 101);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(123, 43);
            this.guna2Button3.TabIndex = 3;
            this.guna2Button3.Text = "Rutas";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::Proyecto_Final.Properties.Resources.instrucciones;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button2.Location = new System.Drawing.Point(3, 52);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(123, 43);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Instrucciones";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Animated = true;
            this.ButtonLogout.BorderRadius = 10;
            this.ButtonLogout.BorderThickness = 1;
            this.ButtonLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLogout.FillColor = System.Drawing.Color.SlateGray;
            this.ButtonLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLogout.ForeColor = System.Drawing.Color.Black;
            this.ButtonLogout.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.ButtonLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonLogout.Image = global::Proyecto_Final.Properties.Resources.out_log_icon_255959;
            this.ButtonLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonLogout.ImageSize = new System.Drawing.Size(32, 32);
            this.ButtonLogout.Location = new System.Drawing.Point(3, 695);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(123, 43);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "Cerrar sesión";
            this.ButtonLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Animated = true;
            this.ButtonHome.BorderRadius = 10;
            this.ButtonHome.BorderThickness = 1;
            this.ButtonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHome.FillColor = System.Drawing.Color.SlateGray;
            this.ButtonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonHome.ForeColor = System.Drawing.Color.Black;
            this.ButtonHome.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.ButtonHome.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonHome.Image = global::Proyecto_Final.Properties.Resources.casa__3_;
            this.ButtonHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHome.ImageSize = new System.Drawing.Size(34, 34);
            this.ButtonHome.Location = new System.Drawing.Point(3, 3);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(123, 43);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
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
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(129, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(910, 741);
            this.panelContenedor.TabIndex = 10;
            // 
            // FormMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 776);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.tlpBarralateral);
            this.Controls.Add(this.tlpBarraTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(606, 362);
            this.Name = "FormMenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NolimitsEvents";
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
        private System.Windows.Forms.Timer timerBarralaterar;
        private System.Windows.Forms.TableLayoutPanel tlpBarralateral;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button ButtonHome;
        private Guna.UI2.WinForms.Guna2Button ButtonLogout;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}

