namespace UI.Desktop
{
    partial class formMain
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
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMComisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.aBMUsuarioToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // aBMUsuarioToolStripMenuItem
            // 
            this.aBMUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMUsuarioToolStripMenuItem1,
            this.aBMPlanesToolStripMenuItem,
            this.aBMMateriasToolStripMenuItem,
            this.aBMEspecialidadesToolStripMenuItem,
            this.aBMComisionesToolStripMenuItem,
            this.aBMCursosToolStripMenuItem});
            this.aBMUsuarioToolStripMenuItem.Name = "aBMUsuarioToolStripMenuItem";
            this.aBMUsuarioToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMUsuarioToolStripMenuItem.Text = "ABM";
            // 
            // aBMUsuarioToolStripMenuItem1
            // 
            this.aBMUsuarioToolStripMenuItem1.Name = "aBMUsuarioToolStripMenuItem1";
            this.aBMUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aBMUsuarioToolStripMenuItem1.Text = "ABM Usuario";
            this.aBMUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.ABMUsuarioToolStripMenuItem1_Click);
            // 
            // aBMPlanesToolStripMenuItem
            // 
            this.aBMPlanesToolStripMenuItem.Name = "aBMPlanesToolStripMenuItem";
            this.aBMPlanesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMPlanesToolStripMenuItem.Text = "ABM Planes";
            this.aBMPlanesToolStripMenuItem.Click += new System.EventHandler(this.aBMPlanesToolStripMenuItem_Click);
            // 
            // aBMMateriasToolStripMenuItem
            // 
            this.aBMMateriasToolStripMenuItem.Name = "aBMMateriasToolStripMenuItem";
            this.aBMMateriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMMateriasToolStripMenuItem.Text = "ABM Materias";
            this.aBMMateriasToolStripMenuItem.Click += new System.EventHandler(this.aBMMateriasToolStripMenuItem_Click);
            // 
            // aBMEspecialidadesToolStripMenuItem
            // 
            this.aBMEspecialidadesToolStripMenuItem.Name = "aBMEspecialidadesToolStripMenuItem";
            this.aBMEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMEspecialidadesToolStripMenuItem.Text = "ABM Especialidades";
            this.aBMEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.aBMEspecialidadesToolStripMenuItem_Click);
            // 
            // aBMComisionesToolStripMenuItem
            // 
            this.aBMComisionesToolStripMenuItem.Name = "aBMComisionesToolStripMenuItem";
            this.aBMComisionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMComisionesToolStripMenuItem.Text = "ABM Comisiones";
            this.aBMComisionesToolStripMenuItem.Click += new System.EventHandler(this.aBMComisionesToolStripMenuItem_Click);
            // 
            // aBMCursosToolStripMenuItem
            // 
            this.aBMCursosToolStripMenuItem.Name = "aBMCursosToolStripMenuItem";
            this.aBMCursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMCursosToolStripMenuItem.Text = "ABM Cursos";
            this.aBMCursosToolStripMenuItem.Click += new System.EventHandler(this.aBMCursosToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "formMain";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem aBMUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMPlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMComisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCursosToolStripMenuItem;
    }
}