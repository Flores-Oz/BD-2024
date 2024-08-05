namespace BDPM24
{
    partial class frmInscripción
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMuni = new System.Windows.Forms.ComboBox();
            this.comboBoxDepa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCarne = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCiclo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGrado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMuni);
            this.groupBox1.Controls.Add(this.comboBoxDepa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxGenero);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxA2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxA1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxN2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelCarne);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelCiclo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxGrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxCarrera);
            this.groupBox1.Controls.Add(this.textBoxN1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Alumno";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxMuni
            // 
            this.comboBoxMuni.FormattingEnabled = true;
            this.comboBoxMuni.Location = new System.Drawing.Point(164, 389);
            this.comboBoxMuni.Name = "comboBoxMuni";
            this.comboBoxMuni.Size = new System.Drawing.Size(194, 26);
            this.comboBoxMuni.TabIndex = 25;
            // 
            // comboBoxDepa
            // 
            this.comboBoxDepa.FormattingEnabled = true;
            this.comboBoxDepa.Location = new System.Drawing.Point(164, 357);
            this.comboBoxDepa.Name = "comboBoxDepa";
            this.comboBoxDepa.Size = new System.Drawing.Size(194, 26);
            this.comboBoxDepa.TabIndex = 24;
            this.comboBoxDepa.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepa_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Municipio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Departamento:";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBoxGenero.Location = new System.Drawing.Point(164, 325);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(146, 26);
            this.comboBoxGenero.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Genero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha Nac:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(164, 293);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(146, 26);
            this.dtpFechaNac.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Segundo Apellido:";
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(164, 261);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(194, 26);
            this.textBoxA2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Primer Apellido:";
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(164, 229);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(194, 26);
            this.textBoxA1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Segundo Nombre:";
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(164, 197);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(194, 26);
            this.textBoxN2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Primer Nombre:";
            // 
            // labelCarne
            // 
            this.labelCarne.AutoSize = true;
            this.labelCarne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarne.ForeColor = System.Drawing.Color.Blue;
            this.labelCarne.Location = new System.Drawing.Point(157, 137);
            this.labelCarne.Name = "labelCarne";
            this.labelCarne.Size = new System.Drawing.Size(21, 22);
            this.labelCarne.TabIndex = 9;
            this.labelCarne.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carne:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelCiclo
            // 
            this.labelCiclo.AutoSize = true;
            this.labelCiclo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiclo.ForeColor = System.Drawing.Color.Blue;
            this.labelCiclo.Location = new System.Drawing.Point(161, 43);
            this.labelCiclo.Name = "labelCiclo";
            this.labelCiclo.Size = new System.Drawing.Size(18, 19);
            this.labelCiclo.TabIndex = 7;
            this.labelCiclo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciclo:";
            // 
            // comboBoxGrado
            // 
            this.comboBoxGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrado.FormattingEnabled = true;
            this.comboBoxGrado.Location = new System.Drawing.Point(164, 103);
            this.comboBoxGrado.Name = "comboBoxGrado";
            this.comboBoxGrado.Size = new System.Drawing.Size(177, 26);
            this.comboBoxGrado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grado:";
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Location = new System.Drawing.Point(164, 71);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(318, 26);
            this.comboBoxCarrera.TabIndex = 3;
            this.comboBoxCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarrera_SelectedIndexChanged);
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(164, 165);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(194, 26);
            this.textBoxN1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(176, 448);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(136, 65);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // frmInscripción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 648);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInscripción";
            this.Text = "Nuevo Alumno";
            this.Load += new System.EventHandler(this.frmInscripción_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCarne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.ComboBox comboBoxMuni;
        private System.Windows.Forms.ComboBox comboBoxDepa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGuardar;
    }
}