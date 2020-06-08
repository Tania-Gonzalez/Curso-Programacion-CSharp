namespace Paneles2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.bntInicio = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.pnlFormContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.pnlFormContenedor.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Location = new System.Drawing.Point(24, 199);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(145, 56);
            this.btnInicioSesion.TabIndex = 1;
            this.btnInicioSesion.Text = "Inicio de Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // bntInicio
            // 
            this.bntInicio.Location = new System.Drawing.Point(24, 87);
            this.bntInicio.Name = "bntInicio";
            this.bntInicio.Size = new System.Drawing.Size(145, 56);
            this.bntInicio.TabIndex = 0;
            this.bntInicio.Text = "Inicio";
            this.bntInicio.UseVisualStyleBackColor = true;
            this.bntInicio.Click += new System.EventHandler(this.bntInicio_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagen.Image")));
            this.pbxImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxImagen.InitialImage")));
            this.pbxImagen.Location = new System.Drawing.Point(77, 76);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(459, 304);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // pnlFormContenedor
            // 
            this.pnlFormContenedor.Controls.Add(this.pbxImagen);
            this.pnlFormContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlFormContenedor.Name = "pnlFormContenedor";
            this.pnlFormContenedor.Size = new System.Drawing.Size(600, 450);
            this.pnlFormContenedor.TabIndex = 3;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnInicioSesion);
            this.pnlMenu.Controls.Add(this.bntInicio);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 450);
            this.pnlMenu.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFormContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.pnlFormContenedor.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Button bntInicio;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Panel pnlFormContenedor;
        private System.Windows.Forms.Panel pnlMenu;
    }
}

