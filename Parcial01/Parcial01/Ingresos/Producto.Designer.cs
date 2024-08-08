namespace Parcial01.Ingresos
{
    partial class Producto
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxExistencia = new System.Windows.Forms.TextBox();
            this.textBoxPVenta = new System.Windows.Forms.TextBox();
            this.textBoxPCosto = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(494, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(236, 22);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 397);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxMarca);
            this.groupBox1.Controls.Add(this.textBoxExistencia);
            this.groupBox1.Controls.Add(this.textBoxPVenta);
            this.groupBox1.Controls.Add(this.textBoxPCosto);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 253);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(142, 184);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(192, 30);
            this.comboBoxMarca.TabIndex = 9;
            // 
            // textBoxExistencia
            // 
            this.textBoxExistencia.Location = new System.Drawing.Point(142, 141);
            this.textBoxExistencia.Name = "textBoxExistencia";
            this.textBoxExistencia.Size = new System.Drawing.Size(192, 28);
            this.textBoxExistencia.TabIndex = 8;
            // 
            // textBoxPVenta
            // 
            this.textBoxPVenta.Location = new System.Drawing.Point(142, 101);
            this.textBoxPVenta.Name = "textBoxPVenta";
            this.textBoxPVenta.Size = new System.Drawing.Size(192, 28);
            this.textBoxPVenta.TabIndex = 7;
            // 
            // textBoxPCosto
            // 
            this.textBoxPCosto.Location = new System.Drawing.Point(142, 64);
            this.textBoxPCosto.Name = "textBoxPCosto";
            this.textBoxPCosto.Size = new System.Drawing.Size(192, 28);
            this.textBoxPCosto.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(142, 29);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(192, 28);
            this.textBoxNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 180);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxExistencia;
        private System.Windows.Forms.TextBox textBoxPVenta;
        private System.Windows.Forms.TextBox textBoxPCosto;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}