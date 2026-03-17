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
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.labelBarra = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerSalir = new System.Windows.Forms.Timer(this.components);
            this.panelBarraTitulo.SuspendLayout();
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(1009, 35);
            this.panelBarraTitulo.TabIndex = 1;
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
            this.buttonMinimized.Location = new System.Drawing.Point(929, 0);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(40, 35);
            this.buttonMinimized.TabIndex = 3;
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
            this.labelBarra.Click += new System.EventHandler(this.labelBarra_Click);
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
            this.buttonClose.Location = new System.Drawing.Point(969, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 35);
            this.buttonClose.TabIndex = 1;
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
            // 
            // timerSalir
            // 
            this.timerSalir.Interval = 10;
            this.timerSalir.Tick += new System.EventHandler(this.timerSalir_Tick);
            // 
            // FormMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 604);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerSalir;
    }
}

