namespace Proyecto_Final
{
    partial class UcTarjetas
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
            this.labelNombreTarjeta = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUltimaApertura = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreTarjeta
            // 
            this.labelNombreTarjeta.AutoSize = true;
            this.labelNombreTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNombreTarjeta.Location = new System.Drawing.Point(98, 0);
            this.labelNombreTarjeta.Name = "labelNombreTarjeta";
            this.labelNombreTarjeta.Size = new System.Drawing.Size(200, 51);
            this.labelNombreTarjeta.TabIndex = 1;
            this.labelNombreTarjeta.Text = "label1";
            this.labelNombreTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel4.Controls.Add(this.lblUltimaApertura, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.guna2Button3, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelNombreTarjeta, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ButtonEliminar, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(995, 51);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // lblUltimaApertura
            // 
            this.lblUltimaApertura.AutoSize = true;
            this.lblUltimaApertura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUltimaApertura.Location = new System.Drawing.Point(304, 0);
            this.lblUltimaApertura.Name = "lblUltimaApertura";
            this.lblUltimaApertura.Size = new System.Drawing.Size(200, 51);
            this.lblUltimaApertura.TabIndex = 6;
            this.lblUltimaApertura.Text = "label1";
            this.lblUltimaApertura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Navy;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Image = global::Proyecto_Final.Properties.Resources.editar__3_;
            this.guna2Button3.Image = global::Proyecto_Final.Properties.Resources.editar__1_;
            this.guna2Button3.Location = new System.Drawing.Point(834, 3);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(154, 45);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "EDITAR";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Animated = true;
            this.ButtonEliminar.BorderRadius = 15;
            this.ButtonEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEliminar.FillColor = System.Drawing.Color.Navy;
            this.ButtonEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminar.HoverState.FillColor = System.Drawing.Color.Red;
            this.ButtonEliminar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonEliminar.HoverState.Image = global::Proyecto_Final.Properties.Resources.eliminar__1_;
            this.ButtonEliminar.Image = global::Proyecto_Final.Properties.Resources.eliminar;
            this.ButtonEliminar.Location = new System.Drawing.Point(672, 3);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(154, 45);
            this.ButtonEliminar.TabIndex = 3;
            this.ButtonEliminar.Text = "ELIMINAR";
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.toppng_com_icono_de_avion_980x978;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UcTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "UcTarjetas";
            this.Size = new System.Drawing.Size(995, 51);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombreTarjeta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button ButtonEliminar;
        private System.Windows.Forms.Label lblUltimaApertura;
    }
}
