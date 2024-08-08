using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial01.Busquedas
{
    public partial class HistorialCompra : Form
    {
        public HistorialCompra()
        {
            InitializeComponent();
        }
        BD.DataClasses1DataContext milinq = new BD.DataClasses1DataContext(Conexion.CADENA);


        private void HistorialCompra_Load(object sender, EventArgs e)
        {
            var Historial = from his in milinq.v_HistorialCompras
                            select his;
            dataGridView1.DataSource = Historial;
        }
    }
}
