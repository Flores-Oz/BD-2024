namespace Parcial2Desktop
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historialAcademicoDelProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeCursosDelAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialAcademicoDelProfesorToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historialAcademicoDelProfesorToolStripMenuItem
            // 
            this.historialAcademicoDelProfesorToolStripMenuItem.Name = "historialAcademicoDelProfesorToolStripMenuItem";
            this.historialAcademicoDelProfesorToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.historialAcademicoDelProfesorToolStripMenuItem.Text = "Historial Academico del Profesor";
            this.historialAcademicoDelProfesorToolStripMenuItem.Click += new System.EventHandler(this.historialAcademicoDelProfesorToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeCursosDelAlumnoToolStripMenuItem,
            this.listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem,
            this.listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historialDeCursosDelAlumnoToolStripMenuItem
            // 
            this.historialDeCursosDelAlumnoToolStripMenuItem.Name = "historialDeCursosDelAlumnoToolStripMenuItem";
            this.historialDeCursosDelAlumnoToolStripMenuItem.Size = new System.Drawing.Size(369, 26);
            this.historialDeCursosDelAlumnoToolStripMenuItem.Text = "Historial de Cursos del Alumno";
            this.historialDeCursosDelAlumnoToolStripMenuItem.Click += new System.EventHandler(this.historialDeCursosDelAlumnoToolStripMenuItem_Click);
            // 
            // listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem
            // 
            this.listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem.Name = "listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem";
            this.listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem.Size = new System.Drawing.Size(369, 26);
            this.listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem.Text = "Listado de Alumnos Asignados a un Curso";
            this.listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem_Click);
            // 
            // listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem
            // 
            this.listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem.Name = "listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem";
            this.listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem.Size = new System.Drawing.Size(369, 26);
            this.listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem.Text = "Listado de Cursos Asignados a un Alumno";
            this.listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historialAcademicoDelProfesorToolStripMenuItem;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeCursosDelAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlumnosAsignadosAUnCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCursosAsignadosAUnAlumnoToolStripMenuItem;
    }
}

