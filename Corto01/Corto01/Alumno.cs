using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corto01
{
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
            CargarAlumnos();

        }
        BD.DataClasses1DataContext milinq = new BD.DataClasses1DataContext(Conexion.CADENA);
        private void CargarAlumnos()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.CADENA))
            {
                SqlCommand cmd = new SqlCommand("SELECT Carne, Nombre1 + ' ' + Apellido1 AS NombreCompleto FROM Alumno", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxAlumnos.DataSource = dt;
                comboBoxAlumnos.DisplayMember = "NombreCompleto";
                comboBoxAlumnos.ValueMember = "Carne";
            }
        }

        private void CargarCursos()
        {
            string carne = comboBoxAlumnos.SelectedValue.ToString();
            using (SqlConnection conn = new SqlConnection(Conexion.CADENA))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id_Curso, Final FROM Asigna_Curso WHERE Carne = @Carne", conn);
                cmd.Parameters.AddWithValue("@Carne", carne);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewCursos.DataSource = dt;
            }
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCursos();
        }
    }
}
