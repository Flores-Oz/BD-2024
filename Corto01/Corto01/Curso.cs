using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
