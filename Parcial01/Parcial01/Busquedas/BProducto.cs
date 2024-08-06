using Parcial01.Modulos;
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
    public partial class BProducto : Form
    {
        public BProducto()
        {
            InitializeComponent();
        }
        BD.DataClasses1DataContext milinq = new BD.DataClasses1DataContext(Conexion.CADENA);

        public void CargarProductos()
        {
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var productos = from producto in milinq.v_ListadoProductos
                               select producto;

                dataGridViewProductos.DataSource = productos.ToList();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text;
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var productos = from producto in milinq.v_ListadoProductos
                                where producto.codigo_producto.ToString().ToLower().Contains(filtro.ToLower()) ||
                                     producto.nombre_producto.ToLower().Contains(filtro.ToLower()) ||
                                     producto.nombre_marca.ToLower().Contains(filtro.ToLower())
                                select producto;

                dataGridViewProductos.DataSource = productos.ToList();
            }
        }

        private void BProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Venta.Pro = dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}
