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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BD.BDLinqDataContext miLinq = new BD.BDLinqDataContext();
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            //select * from carrera
            /*var listadoCarreras = from car in miLinq.carrera
                                  where car.estado_carrera==true
                                  select new {
                                      CODIGO=car.id_carrera,
                                      CARRERA=car.nombre_carrera,
                                      ESTADO=car.estado_carrera
                                  };
            dataGridViewCarreras.DataSource = listadoCarreras;*/
            dataGridViewCarreras.DataSource=miLinq.ListadoCursosporCarrera("01", true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cargaCarreras = from car in miLinq.carrera
                                select new { 
                                    Codigo=car.id_carrera,
                                    Carrera=car.nombre_carrera
                                };
            comboBoxCarrera.DataSource = cargaCarreras;
            comboBoxCarrera.DisplayMember = "Carrera";
            comboBoxCarrera.ValueMember = "Codigo";
        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codCar = comboBoxCarrera.SelectedValue.ToString();
            var cargaGrados = from gra in miLinq.grado
                              join pen in miLinq.pensum on gra.ID_grado equals pen.id_grado
                              where pen.id_carrera== codCar
                              select new { 
                                    Codigo=gra.ID_grado,
                                    Grado=gra.Nom_grado,                                    
                              };
            comboBoxGrado.DataSource= cargaGrados;
            comboBoxGrado.DisplayMember = "Grado";
            comboBoxGrado.ValueMember = "Codigo";
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            //Forma 1
            var cargaCursos = from cur in miLinq.curso
                              join dp in miLinq.detalle_pensum on cur.ID_Curso equals dp.ID_Curso
                              join pen in miLinq.pensum on dp.ID_Pensum equals pen.ID_Pensum
                              where pen.id_carrera == comboBoxCarrera.SelectedValue.ToString()
                              && pen.id_grado == Convert.ToInt32(comboBoxGrado.SelectedValue)
                              select new { 
                                Codigo=cur.ID_Curso,
                                Curso=cur.Nom_Curso
                              };
            //Forma 2
            var cargaCursos2 = from dp in miLinq.detalle_pensum
                               where dp.pensum.id_carrera == comboBoxCarrera.SelectedValue.ToString()
                               && dp.pensum.id_grado == Convert.ToInt32(comboBoxGrado.SelectedValue)
                               select new { 
                                    Codigo=dp.curso.ID_Curso,
                                    Curso=dp.curso.Nom_Curso
                               };
            dataGridViewCursos.DataSource = cargaCursos2;
        }
    }
}
