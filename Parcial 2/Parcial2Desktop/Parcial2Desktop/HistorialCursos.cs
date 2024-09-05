using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Desktop
{
    public partial class HistorialCursos : Form
    {
        DATA.DataClasses1DataContext LINQ = new DATA.DataClasses1DataContext(Conexion.CADENA);

        public HistorialCursos()
        {
            InitializeComponent();
        }

        private void HistorialCursos_Load(object sender, EventArgs e)
        {
            var Alumnos = from cur in LINQ.Bitacora_Asignacions
                          select cur;
            gridControl1.DataSource = Alumnos.ToList();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            string filterText = textEdit1.Text;

            // Perform a query or filter based on the entered text
            var filteredData = from prof in LINQ.Bitacora_Asignacions
                               join a in LINQ.Alumnos on prof.codigo_alumno equals a.codigo_alumno
                               where a.codigo_alumno == filterText // Adjust filter criteria as needed
                               select prof;

            // Update the GridControl data source
            gridControl1.DataSource = filteredData.ToList();
        }
    }
}
