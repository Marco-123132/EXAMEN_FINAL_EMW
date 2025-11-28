namespace WindowsFormsApp1
{
    partial class PrincipalForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolsEquipos = new System.Windows.Forms.ToolStripButton();
            this.toolsMantenimientos = new System.Windows.Forms.ToolStripButton();
            this.toolsTecnicos = new System.Windows.Forms.ToolStripButton();
            this.toolsProvedores = new System.Windows.Forms.ToolStripButton();
            this.toolsUbicaciones = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsEquipos,
            this.toolsMantenimientos,
            this.toolsTecnicos,
            this.toolsProvedores,
            this.toolsUbicaciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolsEquipos
            // 
            this.toolsEquipos.Image = ((System.Drawing.Image)(resources.GetObject("toolsEquipos.Image")));
            this.toolsEquipos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsEquipos.Name = "toolsEquipos";
            this.toolsEquipos.Size = new System.Drawing.Size(69, 22);
            this.toolsEquipos.Text = "Equipos";
            this.toolsEquipos.Click += new System.EventHandler(this.toolsEquipos_Click);
            // 
            // toolsMantenimientos
            // 
            this.toolsMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("toolsMantenimientos.Image")));
            this.toolsMantenimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsMantenimientos.Name = "toolsMantenimientos";
            this.toolsMantenimientos.Size = new System.Drawing.Size(109, 22);
            this.toolsMantenimientos.Text = "Mantenimiento";
            this.toolsMantenimientos.Click += new System.EventHandler(this.toolsMantenimientos_Click);
            // 
            // toolsTecnicos
            // 
            this.toolsTecnicos.Image = ((System.Drawing.Image)(resources.GetObject("toolsTecnicos.Image")));
            this.toolsTecnicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsTecnicos.Name = "toolsTecnicos";
            this.toolsTecnicos.Size = new System.Drawing.Size(72, 22);
            this.toolsTecnicos.Text = "Tecnicos";
            this.toolsTecnicos.Click += new System.EventHandler(this.toolsTecnicos_Click);
            // 
            // toolsProvedores
            // 
            this.toolsProvedores.Image = ((System.Drawing.Image)(resources.GetObject("toolsProvedores.Image")));
            this.toolsProvedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsProvedores.Name = "toolsProvedores";
            this.toolsProvedores.Size = new System.Drawing.Size(92, 22);
            this.toolsProvedores.Text = "Proveedores";
            this.toolsProvedores.Click += new System.EventHandler(this.toolsProvedores_Click);
            // 
            // toolsUbicaciones
            // 
            this.toolsUbicaciones.Image = ((System.Drawing.Image)(resources.GetObject("toolsUbicaciones.Image")));
            this.toolsUbicaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsUbicaciones.Name = "toolsUbicaciones";
            this.toolsUbicaciones.Size = new System.Drawing.Size(91, 22);
            this.toolsUbicaciones.Text = "Ubicaciones";
            this.toolsUbicaciones.Click += new System.EventHandler(this.toolsUbicaciones_Click);
            // 
            // PrincipalForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm1";
            this.Text = "INVENTARIO DE EQUIPOS INFORMATICOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolsEquipos;
        private System.Windows.Forms.ToolStripButton toolsMantenimientos;
        private System.Windows.Forms.ToolStripButton toolsTecnicos;
        private System.Windows.Forms.ToolStripButton toolsProvedores;
        private System.Windows.Forms.ToolStripButton toolsUbicaciones;
    }
}

