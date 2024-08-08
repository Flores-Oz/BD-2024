using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial01.Busquedas
{
    public partial class BProveedor : Form
    {
        public BProveedor()
        {
            InitializeComponent();
        }

        BD.DataClasses1DataContext milinq = new BD.DataClasses1DataContext(Conexion.CADENA);
        public void CargarProveedores()
        {
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var proveedores = from pro in milinq.Proveedors
                                  select pro;

                dataGridView1.DataSource = proveedores.ToList();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text;
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var prov = from prove in milinq.Proveedors
                           where prove.nit_proveedor.ToLower().Contains(filtro.ToLower()) ||
                                 prove.nombre_proveedor.ToLower().Contains(filtro.ToLower())
                           select prove;

                dataGridView1.DataSource = prov.ToList();
            }
        }

        private void BProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}
