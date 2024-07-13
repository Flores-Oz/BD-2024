using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*Forma 1
            /*
            linq.carrera nuevaCarrera = new BD.carrera();
            nuevaCarrera.id_carrera = textBoxCodigo.Text;
            nuevaCarrera.nombre_carrera = textBoxCarrera;
            nuevaCarrera.estado_carrera = checkBoxEstado.Checked;

            linq.carrera.InsertOnSubmit(nuevaCarrera);*/
            //Forma 2
            /*
            BD.carrera nc = new BD.carrera { 
              id_carrera = textBoxCodigo.Text,
              nombre_carrera = textBoxCarrera.Text,
              estado_carrera = checkBoxEstado.Checked
            };
            */
            //Forma 3
            linq.carreras.InsertOnSubmit(new DATA.carrera
            {
                id_carrera = textBoxCodigo.Text,
                nombre_carrera = textBoxCarrera.Text,
                estado_carrera = checkBoxEstado.Checked
            });
            linq.SubmitChanges();
            MessageBox.Show("Guardado");
        }
        DATA.BDDataContext linq = new DATA.BDDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCarrearas();
        }
        public void CargarCarrearas()
        {
            var listadoCarreras = from car in linq.carreras
                                  select new
                                  {
                                      codigo = car.id_carrera,
                                      carrera = car.nombre_carrera,
                                      estado = car.estado_carrera
                                  };
            dataGridView1.DataSource = listadoCarreras;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var buscarCarrera = from car in linq.carreras
                                where car.id_carrera == textBoxCodigo.Text
                                select car;
            foreach(var edita in buscarCarrera)
            {
                edita.nombre_carrera = textBoxCarrera.Text;
                    edita.estado_carrera = checkBoxEstado.Checked;
            }
            linq.SubmitChanges();
            MessageBox.Show("Editado Correctamente");
            CargarCarrearas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var buscarCarrera = from car in linq.carreras
                                where car.id_carrera == textBoxCodigo.Text
                                select car;
            foreach (var aux in buscarCarrera)
            {
                linq.carreras.DeleteOnSubmit(aux);
            }
            linq.SubmitChanges();
            MessageBox.Show("Eliminado Correctamente");
            CargarCarrearas();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
