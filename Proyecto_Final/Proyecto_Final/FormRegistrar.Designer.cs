namespace Proyecto_Final
{
    partial class FormRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
            this.labelRegistrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMensajeContra2 = new System.Windows.Forms.Label();
            this.buttonSingin = new System.Windows.Forms.Button();
            this.labelContraseña2 = new System.Windows.Forms.Label();
            this.textBoxContra2 = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxContra1 = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonMostrarContra = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegistrar
            // 
            this.labelRegistrar.AutoSize = true;
            this.labelRegistrar.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelRegistrar.Location = new System.Drawing.Point(129, 48);
            this.labelRegistrar.Name = "labelRegistrar";
            this.labelRegistrar.Size = new System.Drawing.Size(93, 26);
            this.labelRegistrar.TabIndex = 2;
            this.labelRegistrar.Text = "Registrar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonAtras);
            this.panel1.Controls.Add(this.labelMensajeContra2);
            this.panel1.Controls.Add(this.buttonMostrarContra);
            this.panel1.Controls.Add(this.buttonSingin);
            this.panel1.Controls.Add(this.labelContraseña2);
            this.panel1.Controls.Add(this.textBoxContra2);
            this.panel1.Controls.Add(this.labelContraseña);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxContra1);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.labelRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 448);
            this.panel1.TabIndex = 3;
            // 
            // labelMensajeContra2
            // 
            this.labelMensajeContra2.AutoSize = true;
            this.labelMensajeContra2.ForeColor = System.Drawing.Color.Red;
            this.labelMensajeContra2.Location = new System.Drawing.Point(87, 323);
            this.labelMensajeContra2.Name = "labelMensajeContra2";
            this.labelMensajeContra2.Size = new System.Drawing.Size(0, 13);
            this.labelMensajeContra2.TabIndex = 20;
            // 
            // buttonSingin
            // 
            this.buttonSingin.BackColor = System.Drawing.Color.White;
            this.buttonSingin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingin.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingin.Location = new System.Drawing.Point(120, 360);
            this.buttonSingin.Name = "buttonSingin";
            this.buttonSingin.Size = new System.Drawing.Size(110, 45);
            this.buttonSingin.TabIndex = 18;
            this.buttonSingin.Text = "Registrar";
            this.buttonSingin.UseVisualStyleBackColor = false;
            this.buttonSingin.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // labelContraseña2
            // 
            this.labelContraseña2.AutoSize = true;
            this.labelContraseña2.Location = new System.Drawing.Point(121, 284);
            this.labelContraseña2.Name = "labelContraseña2";
            this.labelContraseña2.Size = new System.Drawing.Size(108, 13);
            this.labelContraseña2.TabIndex = 17;
            this.labelContraseña2.Text = "Confirmar Contraseña";
            // 
            // textBoxContra2
            // 
            this.textBoxContra2.Location = new System.Drawing.Point(81, 300);
            this.textBoxContra2.Name = "textBoxContra2";
            this.textBoxContra2.PasswordChar = '*';
            this.textBoxContra2.Size = new System.Drawing.Size(188, 20);
            this.textBoxContra2.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxContra2, "Ingresar segunda contraseña");
            this.textBoxContra2.TextChanged += new System.EventHandler(this.textBoxContra2_TextChanged);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(145, 217);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 15;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(154, 129);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 14;
            this.labelUsuario.Text = "Usuario";
            // 
            // textBoxContra1
            // 
            this.textBoxContra1.Location = new System.Drawing.Point(81, 233);
            this.textBoxContra1.Name = "textBoxContra1";
            this.textBoxContra1.PasswordChar = '*';
            this.textBoxContra1.Size = new System.Drawing.Size(188, 20);
            this.textBoxContra1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxContra1, "Ingresar contraseña");
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(81, 145);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(188, 20);
            this.textBoxUsuario.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxUsuario, "Ingresar usuario");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Transparent;
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.White;
            this.buttonAtras.BackgroundImage = global::Proyecto_Final.Properties.Resources.close_icon_47;
            this.buttonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtras.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F);
            this.buttonAtras.ForeColor = System.Drawing.Color.White;
            this.buttonAtras.Location = new System.Drawing.Point(310, 0);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(40, 35);
            this.buttonAtras.TabIndex = 21;
            this.buttonAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonAtras, "Cerrar");
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // buttonMostrarContra
            // 
            this.buttonMostrarContra.BackgroundImage = global::Proyecto_Final.Properties.Resources.esconder;
            this.buttonMostrarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarContra.ForeColor = System.Drawing.Color.White;
            this.buttonMostrarContra.Location = new System.Drawing.Point(284, 233);
            this.buttonMostrarContra.Name = "buttonMostrarContra";
            this.buttonMostrarContra.Size = new System.Drawing.Size(27, 24);
            this.buttonMostrarContra.TabIndex = 19;
            this.toolTip1.SetToolTip(this.buttonMostrarContra, "Mostrar contraseña");
            this.buttonMostrarContra.UseVisualStyleBackColor = true;
            this.buttonMostrarContra.Click += new System.EventHandler(this.buttonMostrarContra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(157, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 448);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrar";
            this.Text = "FormRegistrar";
            this.Load += new System.EventHandler(this.FormRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxContra1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelContraseña2;
        private System.Windows.Forms.TextBox textBoxContra2;
        private System.Windows.Forms.Button buttonSingin;
        private System.Windows.Forms.Button buttonMostrarContra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelMensajeContra2;
        private System.Windows.Forms.Button buttonAtras;
    }
}