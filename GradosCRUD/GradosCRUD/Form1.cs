using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradosCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DATA.DataClasses1DataContext DB = new DATA.DataClasses1DataContext(Conexion.conexion);

        public void MostrarGrados()
        {
            var listarGrados = from gr in DB.grados
                               select new
                               {
                                   Codgio = gr.ID_grado,
                                   Grado = gr.Nom_grado,
                                   Estado = gr.estado_grado
                               };
            dataGridView1.DataSource = listarGrados;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            MostrarGrados();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBoxIDGrado.Text = dataGridView1.CurrentRow.Cells[0].ToString();
                textBoxGrado.Text = dataGridView1.CurrentRow.Cells[1].ToString();
                checkBoxEstadoGrado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value);
            }
            catch (Exception) { }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DB.grados.InsertOnSubmit(new DATA.grado
            {
                Nom_grado = textBoxGrado.Text,
                estado_grado = checkBoxEstadoGrado.Checked
            });
            DB.SubmitChanges();
            MessageBox.Show("Guardado");
            MostrarGrados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var buscarGrado = from gra in DB.grados
                              where gra.ID_grado == Convert.ToInt32(textBoxIDGrado.Text)
                                select gra;
            foreach (var edita in buscarGrado)
            {
                edita.Nom_grado = textBoxGrado.Text;
                edita.estado_grado = checkBoxEstadoGrado.Checked;
            }
            DB.SubmitChanges();
            MessageBox.Show("Editado Correctamente");
            MostrarGrados();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var buscarGrado = from gra in DB.grados
                              where gra.ID_grado == Convert.ToInt32(textBoxIDGrado.Text)
                              select gra;
            foreach (var edita in buscarGrado)
            {
                DB.grados.DeleteOnSubmit(edita);
            }
            DB.SubmitChanges();
            MessageBox.Show("Eliminado Correctamente");
            MostrarGrados();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
     

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBoxIDGrado.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxGrado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            checkBoxEstadoGrado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value);
        }
    }
}
