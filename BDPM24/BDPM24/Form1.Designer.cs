namespace BDPM24
{
    partial class Form1
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.dataGridViewCarreras = new System.Windows.Forms.DataGridView();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.comboBoxGrado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(140, 12);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(199, 52);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // dataGridViewCarreras
            // 
            this.dataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(39, 79);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.Size = new System.Drawing.Size(395, 415);
            this.dataGridViewCarreras.TabIndex = 1;
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(500, 93);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(395, 401);
            this.dataGridViewCursos.TabIndex = 3;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(759, 12);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(127, 66);
            this.buttonMostrar.TabIndex = 2;
            this.buttonMostrar.Text = "Mostrar Cursos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Location = new System.Drawing.Point(555, 12);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(181, 26);
            this.comboBoxCarrera.TabIndex = 4;
            this.comboBoxCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarrera_SelectedIndexChanged);
            this.comboBoxCarrera.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCarrera_SelectionChangeCommitted);
            // 
            // comboBoxGrado
            // 
            this.comboBoxGrado.FormattingEnabled = true;
            this.comboBoxGrado.Location = new System.Drawing.Point(555, 52);
            this.comboBoxGrado.Name = "comboBoxGrado";
            this.comboBoxGrado.Size = new System.Drawing.Size(181, 26);
            this.comboBoxGrado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGrado);
            this.Controls.Add(this.comboBoxCarrera);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridViewCarreras);
            this.Controls.Add(this.buttonCargar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.DataGridView dataGridViewCarreras;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.ComboBox comboBoxGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

