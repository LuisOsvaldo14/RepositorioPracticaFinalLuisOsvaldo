namespace Proyecto_Final
{
    partial class FormSingin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSingin));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.labelBarra = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMostrarContra = new System.Windows.Forms.Button();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.linkLabelContraolvidada = new System.Windows.Forms.LinkLabel();
            this.linkLabelRegistrar = new System.Windows.Forms.LinkLabel();
            this.buttonSingin = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxContraIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuarioicon = new System.Windows.Forms.PictureBox();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timerAnimacionAbrir = new System.Windows.Forms.Timer(this.components);
            this.timerSalir = new System.Windows.Forms.Timer(this.components);
            this.labelMensajeContra = new System.Windows.Forms.Label();
            this.labelMensajeUsuario = new System.Windows.Forms.Label();
            this.panelBarraTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContraIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarioicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.Yellow;
            this.panelBarraTitulo.Controls.Add(this.buttonMinimized);
            this.panelBarraTitulo.Controls.Add(this.labelBarra);
            this.panelBarraTitulo.Controls.Add(this.buttonClose);
            this.panelBarraTitulo.Controls.Add(this.button1);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1010, 35);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            this.panelBarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseUp);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimized.BackgroundImage")));
            this.buttonMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimized.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMinimized.Location = new System.Drawing.Point(930, 0);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(40, 35);
            this.buttonMinimized.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonMinimized, "Minimizar");
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // labelBarra
            // 
            this.labelBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBarra.AutoSize = true;
            this.labelBarra.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarra.Location = new System.Drawing.Point(3, 9);
            this.labelBarra.Name = "labelBarra";
            this.labelBarra.Size = new System.Drawing.Size(101, 18);
            this.labelBarra.TabIndex = 2;
            this.labelBarra.Text = "No Limits";
            this.labelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBarra_MouseDown);
            this.labelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBarra_MouseMove);
            this.labelBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelBarra_MouseUp);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClose.Location = new System.Drawing.Point(970, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 35);
            this.buttonClose.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonClose, "Cerrar");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(466, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelMensajeUsuario);
            this.panel2.Controls.Add(this.labelMensajeContra);
            this.panel2.Controls.Add(this.buttonMostrarContra);
            this.panel2.Controls.Add(this.labelContraseña);
            this.panel2.Controls.Add(this.labelUsuario);
            this.panel2.Controls.Add(this.linkLabelContraolvidada);
            this.panel2.Controls.Add(this.linkLabelRegistrar);
            this.panel2.Controls.Add(this.buttonSingin);
            this.panel2.Controls.Add(this.labelWelcome);
            this.panel2.Controls.Add(this.pictureBoxContraIcon);
            this.panel2.Controls.Add(this.pictureBoxUsuarioicon);
            this.panel2.Controls.Add(this.textBoxContra);
            this.panel2.Controls.Add(this.textBoxUsuario);
            this.panel2.Location = new System.Drawing.Point(288, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 362);
            this.panel2.TabIndex = 1;
            // 
            // buttonMostrarContra
            // 
            this.buttonMostrarContra.BackgroundImage = global::Proyecto_Final.Properties.Resources.esconder;
            this.buttonMostrarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarContra.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMostrarContra.Location = new System.Drawing.Point(322, 176);
            this.buttonMostrarContra.Name = "buttonMostrarContra";
            this.buttonMostrarContra.Size = new System.Drawing.Size(27, 24);
            this.buttonMostrarContra.TabIndex = 20;
            this.buttonMostrarContra.Tag = "Mostrar contraseña";
            this.toolTip1.SetToolTip(this.buttonMostrarContra, "Mostrar contraseña");
            this.buttonMostrarContra.UseVisualStyleBackColor = true;
            this.buttonMostrarContra.Click += new System.EventHandler(this.buttonMostrarContra_Click);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(192, 164);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 9;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(201, 99);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 8;
            this.labelUsuario.Text = "Usuario";
            // 
            // linkLabelContraolvidada
            // 
            this.linkLabelContraolvidada.AutoSize = true;
            this.linkLabelContraolvidada.Location = new System.Drawing.Point(157, 216);
            this.linkLabelContraolvidada.Name = "linkLabelContraolvidada";
            this.linkLabelContraolvidada.Size = new System.Drawing.Size(131, 13);
            this.linkLabelContraolvidada.TabIndex = 7;
            this.linkLabelContraolvidada.TabStop = true;
            this.linkLabelContraolvidada.Text = "¿Olvidaste tu contraseña?";
            // 
            // linkLabelRegistrar
            // 
            this.linkLabelRegistrar.AutoSize = true;
            this.linkLabelRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrar.Location = new System.Drawing.Point(194, 295);
            this.linkLabelRegistrar.Name = "linkLabelRegistrar";
            this.linkLabelRegistrar.Size = new System.Drawing.Size(57, 15);
            this.linkLabelRegistrar.TabIndex = 6;
            this.linkLabelRegistrar.TabStop = true;
            this.linkLabelRegistrar.Text = "Registrar";
            this.linkLabelRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrar_LinkClicked);
            // 
            // buttonSingin
            // 
            this.buttonSingin.BackColor = System.Drawing.Color.White;
            this.buttonSingin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingin.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingin.Location = new System.Drawing.Point(167, 247);
            this.buttonSingin.Name = "buttonSingin";
            this.buttonSingin.Size = new System.Drawing.Size(110, 45);
            this.buttonSingin.TabIndex = 5;
            this.buttonSingin.Text = "Ingresar";
            this.buttonSingin.UseVisualStyleBackColor = false;
            this.buttonSingin.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(167, 48);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(111, 26);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Bienvenido";
            // 
            // pictureBoxContraIcon
            // 
            this.pictureBoxContraIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxContraIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxContraIcon.Image")));
            this.pictureBoxContraIcon.Location = new System.Drawing.Point(85, 166);
            this.pictureBoxContraIcon.Name = "pictureBoxContraIcon";
            this.pictureBoxContraIcon.Size = new System.Drawing.Size(37, 34);
            this.pictureBoxContraIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxContraIcon.TabIndex = 3;
            this.pictureBoxContraIcon.TabStop = false;
            // 
            // pictureBoxUsuarioicon
            // 
            this.pictureBoxUsuarioicon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsuarioicon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuarioicon.Image")));
            this.pictureBoxUsuarioicon.Location = new System.Drawing.Point(85, 101);
            this.pictureBoxUsuarioicon.Name = "pictureBoxUsuarioicon";
            this.pictureBoxUsuarioicon.Size = new System.Drawing.Size(37, 34);
            this.pictureBoxUsuarioicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuarioicon.TabIndex = 2;
            this.pictureBoxUsuarioicon.TabStop = false;
            // 
            // textBoxContra
            // 
            this.textBoxContra.Location = new System.Drawing.Point(128, 180);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.PasswordChar = '*';
            this.textBoxContra.Size = new System.Drawing.Size(188, 20);
            this.textBoxContra.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxContra, "Ingresar contraseña");
            this.textBoxContra.TextChanged += new System.EventHandler(this.textBoxContra_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(128, 115);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(188, 20);
            this.textBoxUsuario.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxUsuario, "Ingresar usuario");
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1010, 605);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // timerAnimacionAbrir
            // 
            this.timerAnimacionAbrir.Interval = 10;
            this.timerAnimacionAbrir.Tick += new System.EventHandler(this.timerAnimacionAbrir_Tick);
            // 
            // timerSalir
            // 
            this.timerSalir.Interval = 10;
            this.timerSalir.Tick += new System.EventHandler(this.timerSalir_Tick);
            // 
            // labelMensajeContra
            // 
            this.labelMensajeContra.Location = new System.Drawing.Point(-3, 203);
            this.labelMensajeContra.Name = "labelMensajeContra";
            this.labelMensajeContra.Size = new System.Drawing.Size(435, 13);
            this.labelMensajeContra.TabIndex = 21;
            this.labelMensajeContra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMensajeUsuario
            // 
            this.labelMensajeUsuario.Location = new System.Drawing.Point(0, 138);
            this.labelMensajeUsuario.Name = "labelMensajeUsuario";
            this.labelMensajeUsuario.Size = new System.Drawing.Size(435, 13);
            this.labelMensajeUsuario.TabIndex = 22;
            this.labelMensajeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSingin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 605);
            this.Name = "FormSingin";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSingin";
            this.Activated += new System.EventHandler(this.FormSingin_Activated);
            this.Load += new System.EventHandler(this.FormSingin_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContraIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarioicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxUsuarioicon;
        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBoxContraIcon;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonSingin;
        private System.Windows.Forms.LinkLabel linkLabelContraolvidada;
        private System.Windows.Forms.LinkLabel linkLabelRegistrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Button buttonMostrarContra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerAnimacionAbrir;
        private System.Windows.Forms.Timer timerSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMensajeContra;
        private System.Windows.Forms.Label labelMensajeUsuario;
    }
}