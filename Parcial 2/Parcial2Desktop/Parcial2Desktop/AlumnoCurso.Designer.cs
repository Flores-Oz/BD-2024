namespace Parcial2Desktop
{
    partial class AlumnoCurso
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
            this.vistaProfesoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo_asignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_asignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresultado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_curso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_curso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfesor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProfesoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaProfesoreBindingSource
            // 
            this.vistaProfesoreBindingSource.DataSource = typeof(Parcial2Desktop.DATA.VistaProfesore);
            // 
            // alumnoCursoBindingSource
            // 
            this.alumnoCursoBindingSource.DataSource = typeof(Parcial2Desktop.DATA.AlumnoCurso);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.alumnoCursoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 77);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1000, 361);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo_asignacion,
            this.colfecha_asignacion,
            this.colresultado,
            this.colcodigo_curso,
            this.colnombre_curso,
            this.colProfesor});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo_asignacion
            // 
            this.colcodigo_asignacion.FieldName = "codigo_asignacion";
            this.colcodigo_asignacion.MinWidth = 25;
            this.colcodigo_asignacion.Name = "colcodigo_asignacion";
            this.colcodigo_asignacion.Visible = true;
            this.colcodigo_asignacion.VisibleIndex = 0;
            this.colcodigo_asignacion.Width = 94;
            // 
            // colfecha_asignacion
            // 
            this.colfecha_asignacion.FieldName = "fecha_asignacion";
            this.colfecha_asignacion.MinWidth = 25;
            this.colfecha_asignacion.Name = "colfecha_asignacion";
            this.colfecha_asignacion.Visible = true;
            this.colfecha_asignacion.VisibleIndex = 1;
            this.colfecha_asignacion.Width = 94;
            // 
            // colresultado
            // 
            this.colresultado.FieldName = "resultado";
            this.colresultado.MinWidth = 25;
            this.colresultado.Name = "colresultado";
            this.colresultado.Visible = true;
            this.colresultado.VisibleIndex = 2;
            this.colresultado.Width = 94;
            // 
            // colcodigo_curso
            // 
            this.colcodigo_curso.FieldName = "codigo_curso";
            this.colcodigo_curso.MinWidth = 25;
            this.colcodigo_curso.Name = "colcodigo_curso";
            this.colcodigo_curso.Visible = true;
            this.colcodigo_curso.VisibleIndex = 3;
            this.colcodigo_curso.Width = 94;
            // 
            // colnombre_curso
            // 
            this.colnombre_curso.FieldName = "nombre_curso";
            this.colnombre_curso.MinWidth = 25;
            this.colnombre_curso.Name = "colnombre_curso";
            this.colnombre_curso.Visible = true;
            this.colnombre_curso.VisibleIndex = 4;
            this.colnombre_curso.Width = 94;
            // 
            // colProfesor
            // 
            this.colProfesor.FieldName = "Profesor";
            this.colProfesor.MinWidth = 25;
            this.colProfesor.Name = "colProfesor";
            this.colProfesor.Visible = true;
            this.colProfesor.VisibleIndex = 5;
            this.colProfesor.Width = 94;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(328, 29);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(357, 42);
            this.textEdit1.TabIndex = 8;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // AlumnoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "AlumnoCurso";
            this.Text = "AlumnoCurso";
            this.Load += new System.EventHandler(this.AlumnoCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistaProfesoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vistaProfesoreBindingSource;
        private System.Windows.Forms.BindingSource alumnoCursoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_asignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_asignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colresultado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_curso;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_curso;
        private DevExpress.XtraGrid.Columns.GridColumn colProfesor;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}