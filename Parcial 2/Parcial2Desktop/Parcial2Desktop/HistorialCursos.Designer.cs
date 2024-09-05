namespace Parcial2Desktop
{
    partial class HistorialCursos
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.bitacoraAsignacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_bitacora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_asignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_asignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresultado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_delegado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_alumno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_prof_curso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraAsignacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(328, 21);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(357, 42);
            this.textEdit1.TabIndex = 10;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // bitacoraAsignacionBindingSource
            // 
            this.bitacoraAsignacionBindingSource.DataSource = typeof(Parcial2Desktop.DATA.Bitacora_Asignacion);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bitacoraAsignacionBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1000, 369);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_bitacora,
            this.colcodigo_asignacion,
            this.colfecha_asignacion,
            this.colzona,
            this.colfinal,
            this.coltotal,
            this.colresultado,
            this.colestado_delegado,
            this.colcodigo_alumno,
            this.colcodigo_prof_curso});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_bitacora
            // 
            this.colid_bitacora.FieldName = "id_bitacora";
            this.colid_bitacora.MinWidth = 25;
            this.colid_bitacora.Name = "colid_bitacora";
            this.colid_bitacora.Visible = true;
            this.colid_bitacora.VisibleIndex = 0;
            this.colid_bitacora.Width = 94;
            // 
            // colcodigo_asignacion
            // 
            this.colcodigo_asignacion.FieldName = "codigo_asignacion";
            this.colcodigo_asignacion.MinWidth = 25;
            this.colcodigo_asignacion.Name = "colcodigo_asignacion";
            this.colcodigo_asignacion.Visible = true;
            this.colcodigo_asignacion.VisibleIndex = 1;
            this.colcodigo_asignacion.Width = 94;
            // 
            // colfecha_asignacion
            // 
            this.colfecha_asignacion.FieldName = "fecha_asignacion";
            this.colfecha_asignacion.MinWidth = 25;
            this.colfecha_asignacion.Name = "colfecha_asignacion";
            this.colfecha_asignacion.Visible = true;
            this.colfecha_asignacion.VisibleIndex = 2;
            this.colfecha_asignacion.Width = 94;
            // 
            // colzona
            // 
            this.colzona.FieldName = "zona";
            this.colzona.MinWidth = 25;
            this.colzona.Name = "colzona";
            this.colzona.Visible = true;
            this.colzona.VisibleIndex = 3;
            this.colzona.Width = 94;
            // 
            // colfinal
            // 
            this.colfinal.FieldName = "final";
            this.colfinal.MinWidth = 25;
            this.colfinal.Name = "colfinal";
            this.colfinal.Visible = true;
            this.colfinal.VisibleIndex = 4;
            this.colfinal.Width = 94;
            // 
            // coltotal
            // 
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 25;
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 5;
            this.coltotal.Width = 94;
            // 
            // colresultado
            // 
            this.colresultado.FieldName = "resultado";
            this.colresultado.MinWidth = 25;
            this.colresultado.Name = "colresultado";
            this.colresultado.Visible = true;
            this.colresultado.VisibleIndex = 6;
            this.colresultado.Width = 94;
            // 
            // colestado_delegado
            // 
            this.colestado_delegado.FieldName = "estado_delegado";
            this.colestado_delegado.MinWidth = 25;
            this.colestado_delegado.Name = "colestado_delegado";
            this.colestado_delegado.Visible = true;
            this.colestado_delegado.VisibleIndex = 7;
            this.colestado_delegado.Width = 94;
            // 
            // colcodigo_alumno
            // 
            this.colcodigo_alumno.FieldName = "codigo_alumno";
            this.colcodigo_alumno.MinWidth = 25;
            this.colcodigo_alumno.Name = "colcodigo_alumno";
            this.colcodigo_alumno.Visible = true;
            this.colcodigo_alumno.VisibleIndex = 8;
            this.colcodigo_alumno.Width = 94;
            // 
            // colcodigo_prof_curso
            // 
            this.colcodigo_prof_curso.FieldName = "codigo_prof_curso";
            this.colcodigo_prof_curso.MinWidth = 25;
            this.colcodigo_prof_curso.Name = "colcodigo_prof_curso";
            this.colcodigo_prof_curso.Visible = true;
            this.colcodigo_prof_curso.VisibleIndex = 9;
            this.colcodigo_prof_curso.Width = 94;
            // 
            // HistorialCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEdit1);
            this.Name = "HistorialCursos";
            this.Text = "HistorialCursos";
            this.Load += new System.EventHandler(this.HistorialCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraAsignacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.BindingSource bitacoraAsignacionBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bitacora;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_asignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_asignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colzona;
        private DevExpress.XtraGrid.Columns.GridColumn colfinal;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colresultado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_delegado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_alumno;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_prof_curso;
    }
}