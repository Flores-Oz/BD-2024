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
    public partial class HistorialProfesor : Form
    {
        DATA.DataClasses1DataContext LINQ = new DATA.DataClasses1DataContext(Conexion.CADENA);
        public HistorialProfesor()
        {
            InitializeComponent();
        }

        private void HistorialProfesor_Load(object sender, EventArgs e)
        {
            var Historial = from prof in LINQ.VistaAsignaProfes
                            select prof;
            gridControl1.DataSource = Historial.ToList(); // Use ToList() to materialize the query result if necessary
            var profesores = from prof in LINQ.Profesors
                             select new {
                                 DPI = prof.dpi_profesor,
                                 Nombre = prof.nombres_profesor + " " + prof.apellidos_profesor
                             };
            comboBox1.DataSource = profesores;
            comboBox1.DisplayMember = "Nombre"; // Set the display member to show in the dropdown
            comboBox1.ValueMember = "DPI";
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                   string selectedDPI = comboBox1.SelectedValue.ToString();
                    var historial = from prof in LINQ.VistaAsignaProfes
                                    where prof.dpi_profesor == selectedDPI
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
