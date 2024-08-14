namespace Corto01
{
    partial class Alumno
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
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.comboBoxAlumnos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(305, 12);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(483, 426);
            this.dataGridViewCursos.TabIndex = 0;
            // 
            // comboBoxAlumnos
            // 
            this.comboBoxAlumnos.FormattingEnabled = true;
            this.comboBoxAlumnos.Location = new System.Drawing.Point(59, 105);
            this.comboBoxAlumnos.Name = "comboBoxAlumnos";
            this.comboBoxAlumnos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlumnos.TabIndex = 1;
            this.comboBoxAlumnos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlumnos_SelectedIndexChanged);
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAlumnos);
            this.Controls.Add(this.dataGridViewCursos);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.ComboBox comboBoxAlumnos;
    }
}