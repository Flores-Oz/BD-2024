using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarneAntes
{
    public partial class Form1 : Form
    {
        DATA.DataClasseDataContext DB = new DATA.DataClasseDataContext(Conexion.conexion);
        int idCiclo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var listadoCarreras = from car in DB.carrera
                                  select new {
                                      Codigo = car.id_carrera,
                                      Carrera = car.nombre_carrera
                                  };
            comboBoxCarrera.DataSource = listadoCarreras;
            comboBoxCarrera.ValueMember = "Codigo";
            comboBoxCarrera.DisplayMember = "Carrera";

            var cicloActivo = from ci in DB.ciclo
                              where ci.estado_ciclo == true
                              select new {
                                 Codigo = ci.id_ciclo,
                                 Ciclo = ci.nombre_ciclo
                              };
            idCiclo = cicloActivo.ToList()[0].Codigo;
            labelCiclo.Text = cicloActivo.ToList()[0].Ciclo.ToString();
        }
        string idPensum = "";
        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string codCar = comboBoxCarrera.SelectedValue.ToString();
                var listadoGrados = from pen in DB.pensum
                                    where pen.id_carrera == codCar
                                    select new {
                                        Codigo = pen.id_grado,
                                        Grado = pen.grado.Nom_grado
                                    };
                comboBoxGrado.DataSource = listadoGrados;
                comboBoxGrado.ValueMember = "Codigo";
                comboBoxGrado.DisplayMember = "Grado";
                //Encontrar el siguiente de carne
                string preCarne = labelCiclo.Text + codCar;
                var ultimoCarne = from alu in DB.alumnos
                                  where alu.Carne.StartsWith(preCarne)
                                  select alu.Carne;
                if (ultimoCarne.Max() == null)
                {
                    labelCarne.Text = preCarne + "001";
                }
                else
                {
                    string aux = ultimoCarne.Max().ToString();
                    labelCarne.Text = (Convert.ToInt32(aux)+1).ToString();
                }
            }catch (Exception) { }
        }
    }
}
