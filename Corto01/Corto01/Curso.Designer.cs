namespace Corto01
{
    partial class Curso
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
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxidAlumCurso = new System.Windows.Forms.TextBox();
            this.textBoxCarne = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxZona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLiteral = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.comboBoxArgumento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(118, 39);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSemestre.TabIndex = 0;
            this.comboBoxSemestre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(118, 73);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCurso.TabIndex = 2;
            this.comboBoxCurso.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurso_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 426);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "id_Alum_Curso";
            // 
            // textBoxidAlumCurso
            // 
            this.textBoxidAlumCurso.Enabled = false;
            this.textBoxidAlumCurso.Location = new System.Drawing.Point(139, 119);
            this.textBoxidAlumCurso.Name = "textBoxidAlumCurso";
            this.textBoxidAlumCurso.Size = new System.Drawing.Size(142, 22);
            this.textBoxidAlumCurso.TabIndex = 6;
            // 
            // textBoxCarne
            // 
            this.textBoxCarne.Enabled = false;
            this.textBoxCarne.Location = new System.Drawing.Point(139, 147);
            this.textBoxCarne.Name = "textBoxCarne";
            this.textBoxCarne.Size = new System.Drawing.Size(142, 22);
            this.textBoxCarne.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carne";
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Enabled = false;
            this.textBoxCurso.Location = new System.Drawing.Point(139, 174);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(142, 22);
            this.textBoxCurso.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Curso";
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(139, 228);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(142, 22);
            this.textBoxFinal.TabIndex = 14;
            this.textBoxFinal.TextChanged += new System.EventHandler(this.textBoxFinal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Final";
            // 
            // textBoxZona
            // 
            this.textBoxZona.Location = new System.Drawing.Point(139, 201);
            this.textBoxZona.Name = "textBoxZona";
            this.textBoxZona.Size = new System.Drawing.Size(142, 22);
            this.textBoxZona.TabIndex = 12;
            this.textBoxZona.TextChanged += new System.EventHandler(this.textBoxZona_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zona";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(139, 257);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(142, 22);
            this.textBoxTotal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Argumento";
            // 
            // textBoxLiteral
            // 
            this.textBoxLiteral.Location = new System.Drawing.Point(139, 288);
            this.textBoxLiteral.Name = "textBoxLiteral";
            this.textBoxLiteral.Size = new System.Drawing.Size(142, 22);
            this.textBoxLiteral.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Literal";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(76, 364);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(163, 62);
            this.buttonActualizar.TabIndex = 21;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // comboBoxArgumento
            // 
            this.comboBoxArgumento.FormattingEnabled = true;
            this.comboBoxArgumento.Location = new System.Drawing.Point(139, 317);
            this.comboBoxArgumento.Name = "comboBoxArgumento";
            this.comboBoxArgumento.Size = new System.Drawing.Size(142, 24);
            this.comboBoxArgumento.TabIndex = 22;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.comboBoxArgumento);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxLiteral);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxZona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCarne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxidAlumCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSemestre);
            this.Name = "Curso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxidAlumCurso;
        private System.Windows.Forms.TextBox textBoxCarne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxZona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLiteral;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.ComboBox comboBoxArgumento;
    }
}