using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Corto01
{
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            int idSem = Convert.ToInt16(comboBoxSemestre.SelectedValue);
            var cursos = from cur in milinq.Curso
                         where cur.Id_Semestre == idSem
                         select new
                         {
                             codigo = cur.Id_Curso,
                             curso = cur.Nombre_Curso
                         };
            comboBoxCurso.DataSource= cursos;
            comboBoxCurso.DisplayMember = "curso";
            comboBoxCurso.ValueMember = "codigo";
            }catch(Exception ex) { }
        }
        BD.DataClasses1DataContext milinq = new BD.DataClasses1DataContext(Conexion.CADENA);
        private void Curso_Load(object sender, EventArgs e)
        {
            var semest = from sm in milinq.Semestre
                         select sm;
            comboBoxSemestre.DataSource = semest;
            comboBoxSemestre.DisplayMember = "Nombre_Semestre";
            comboBoxSemestre.ValueMember = "Id_Semestre";

            // Assuming comboBox1 is your ComboBox
            comboBoxArgumento.Items.Add("Aprobado");
            comboBoxArgumento.Items.Add("Reprobado");
            comboBoxArgumento.Items.Add("Sin Derecho a Examen");
            comboBoxArgumento.Items.Add("No se Presento");
        }

        private void comboBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt16(comboBoxCurso.SelectedValue);
                var signal = from sm in milinq.Asigna_Curso
                           where Convert.ToInt16(sm.Id_Curso) == cod
                           select new { 
                               ID_Alum = sm.id_alum_curso,
                               Carne = sm.Carne,
                               id_Curso = sm.Id_Curso,
                               Zona = sm.Zona,
                               Final = sm.Final,
                               Total = sm.Final,
                               Literal = sm.Literal,
                               Argumento = sm.Argumento,
                               Fecha_Asignacion = sm.fecha_asignacion,
                               Fecha_Ingreso_Nota = sm.fecha_ingreso_nota
                };
                dataGridView1.DataSource = signal.ToList();
            }
            catch (Exception ex) { }
        }

        private void textBoxZona_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?:[0-5]?[0-9]|60)$";
            if (Regex.IsMatch(textBoxZona.Text, pattern))
            {
                int Z = Convert.ToInt16(textBoxZona.Text);
                if(Z == 0)
                {
                    textBoxLiteral.Text = "NSP";
                }else if(Z <= 30){
                    textBoxLiteral.Text = "SDE";
                }
            }
            else
            {
                // La entrada no es válida
                MessageBox.Show("Por favor, introduce un número entre 0 y 60.");
                textBoxZona.Clear(); // Limpia el TextBox si la entrada no es válida
            }
        }

        private void textBoxFinal_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?:[0-3]?[0-9]|40)$";
            if (Regex.IsMatch(textBoxFinal.Text, pattern))
            {
                textBoxTotal.Text = (Convert.ToInt16(textBoxFinal.Text) + Convert.ToInt16(textBoxZona.Text)).ToString();
            }
            else
            {
                // La entrada no es válida
                MessageBox.Show("Por favor, introduce un número entre 0 y 40.");
                textBoxFinal.Clear(); // Limpia el TextBox si la entrada no es válida
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxidAlumCurso.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCarne.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCurso.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var buscar = from asig in milinq.Asigna_Curso
                         where asig.id_alum_curso == Convert.ToInt16(textBoxidAlumCurso.Text)
                         select asig;
            foreach (var edita in buscar)
            {
                edita.Zona = Convert.ToInt16(textBoxZona.Text);
                edita.Final = Convert.ToInt16(textBoxFinal.Text);
                edita.Total = Convert.ToInt16(textBoxTotal.Text);
                edita.Literal = textBoxLiteral.Text;
                edita.Argumento = comboBoxArgumento.SelectedItem.ToString();
            }
            milinq.SubmitChanges();
            MessageBox.Show("Editado Correctamente");

        }
    }
}
