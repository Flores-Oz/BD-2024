using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDPM24
{
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }
        BD.BDLinqDataContext milinq = new BD.BDLinqDataContext();
        private void frmCurso_Load(object sender, EventArgs e)
        {
            var listadoCarreras = from car in milinq.carrera
                                  select new { 
                                    Codigo=car.id_carrera,
                                    Carrera=car.nombre_carrera
                                  };
            comboBoxCarrera.DataSource = listadoCarreras;
            comboBoxCarrera.ValueMember = "Codigo";
            comboBoxCarrera.DisplayMember = "Carrera";
        }

        private void comboBoxCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codCar =comboBoxCarrera.SelectedValue.ToString();
            var listadoGrados = from pen in milinq.pensum
                                where pen.id_carrera == codCar
                                select new { 
                                    Codigo=pen.id_grado,
                                    Grado=pen.grado.Nom_grado
                                };
            comboBoxGrado.DataSource = listadoGrados;
            comboBoxGrado.ValueMember = "Codigo";
            comboBoxGrado.DisplayMember = "Grado";
        }
        public void listadoCursos(string codCar,int codGrado)
        {
           
            var listadoCursos = from dp in milinq.detalle_pensum
                                where dp.pensum.id_carrera == codCar && dp.pensum.id_grado == codGrado
                                select new
                                {
                                    Codigo = dp.ID_Curso,
                                    Curso = dp.curso.Nom_Curso
                                };
            dataGridViewCursos.DataSource = listadoCursos;
        }
        string idPensum = "";
        private void comboBoxGrado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codCar = comboBoxCarrera.SelectedValue.ToString();
            int codGrado =Convert.ToInt32(comboBoxGrado.SelectedValue);
            listadoCursos(codCar, codGrado);
            //Obtener el codigo maximo de la lista
            string precodigo = codGrado + codCar;//403
            var listadoIds = from cur in milinq.curso
                           where cur.ID_Curso.StartsWith(precodigo)
                           select cur.ID_Curso;
            string ultimoCodigo = listadoIds.Max();
            textBoxCodigo.Text =(Convert.ToInt64(ultimoCodigo)+1).ToString();

            //Encontrar el idpensum
            var auxpen = from pen in milinq.pensum
                         where pen.id_carrera == codCar && pen.id_grado == codGrado
                         select new {
                             ID = pen.ID_Pensum
                         };
            idPensum = auxpen.ToList()[0].ID;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            BD.curso nuevoCurso = new BD.curso { 
                ID_Curso=textBoxCodigo.Text,
                Nom_Curso=textBoxCurso.Text,
                estado_curso=checkBoxEstado.Checked,
            };
            milinq.curso.InsertOnSubmit(nuevoCurso);
            BD.detalle_pensum nuevoDP = new BD.detalle_pensum { 
                ID_Curso=textBoxCodigo.Text,
                ID_Pensum=idPensum
            };
            milinq.detalle_pensum.InsertOnSubmit(nuevoDP);
            milinq.SubmitChanges();
            MessageBox.Show("Guardado");
            listadoCursos(comboBoxCarrera.SelectedValue.ToString(),Convert.ToInt32(comboBoxGrado.SelectedValue));
        }
    }
}
