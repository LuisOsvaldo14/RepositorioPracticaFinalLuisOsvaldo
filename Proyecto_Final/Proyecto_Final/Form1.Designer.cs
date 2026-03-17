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
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
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
            this.labelBarra.Click += new System.EventHandler(this.labelBarra_Click);
            // 
            // timerSalir
            // 
            this.timerSalir.Interval = 10;
            this.timerSalir.Tick += new System.EventHandler(this.timerSalir_Tick);
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximizar.BackgroundImage = global::Proyecto_Final.Properties.Resources.minimizar_signo__1_;
            this.buttonMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizar.ForeColor = System.Drawing.Color.Yellow;
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
            this.buttonMinimized.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMinimized.Location = new System.Drawing.Point(891, 3);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(34, 29);
            this.buttonMinimized.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonMinimized, "Minimizar");
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClose.Location = new System.Drawing.Point(971, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 29);
            this.buttonClose.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonClose, "Cerrar");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Yellow;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Controls.Add(this.labelBarra, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClose, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMaximizar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinimized, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 35);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FormMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 604);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormMenuprincipal_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMenuprincipal_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timerSalir;
        private System.Windows.Forms.Button buttonMaximizar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

