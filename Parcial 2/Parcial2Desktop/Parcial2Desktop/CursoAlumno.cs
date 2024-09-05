using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Desktop
{
    public partial class CursoAlumno : Form
    {
        DATA.DataClasses1DataContext LINQ = new DATA.DataClasses1DataContext(Conexion.CADENA);
        public CursoAlumno()
        {
            InitializeComponent();
        }

        private void CursoAlumno_Load(object sender, EventArgs e)
        {
            var Historial = from prof in LINQ.CursoAlumnos
                            select prof;
            gridControl1.DataSource = Historial.ToList();
            var Cursos = from cur in LINQ.Cursos
                         select new
                         {
                             Codigo = cur.codigo_curso,
                             Curso = cur.nombre_curso
                         };
            comboBox1.DataSource = Cursos;
            comboBox1.DisplayMember = "Curso";
            comboBox1.ValueMember = "Codigo";
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    string selectedDPI = comboBox1.SelectedValue.ToString();
                    var historial = from prof in LINQ.CursoAlumnos
                                    where prof.codigo_curso == selectedDPI
                                    select prof;
                    gridControl1.DataSource = historial.ToList();
                }
                else
                {
                    MessageBox.Show("Porfavor Seleccion un Item");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
