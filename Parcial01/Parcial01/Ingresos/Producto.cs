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

namespace Parcial01.Ingresos
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        BD.DataClasses1DataContext milinq = new BD.DataClasses1DataContext(Conexion.CADENA);

        private void Producto_Load(object sender, EventArgs e)
        {
            var marcas = from mar in milinq.Marcas
                         select new
                         {
                             Codigo = mar.codigo_marca,
                             Marca = mar.nombre_marca
                         };
            comboBoxMarca.DataSource = marcas;
            comboBoxMarca.ValueMember = "Codigo";
            comboBoxMarca.DisplayMember = "Marca";
            CargarProductos();
        }

        public void Limpiar()
        {
            textBoxExistencia.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxPCosto.Text = string.Empty;
            textBoxPVenta.Text = string.Empty;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxExistencia.Text) &&
   !string.IsNullOrEmpty(textBoxNombre.Text) &&
   !string.IsNullOrEmpty(textBoxPCosto.Text) &&
   !string.IsNullOrEmpty(textBoxPVenta.Text))
            {
                BD.Producto newProdu = new BD.Producto
                {
                    nombre_producto = textBoxNombre.Text,
                    precio_costo = Convert.ToInt32(textBoxPCosto.Text),
                    precio_venta = Convert.ToInt32(textBoxPVenta.Text),
                    existencia_producto = Convert.ToInt32(textBoxExistencia.Text),
                    codigo_marca = Convert.ToInt32(comboBoxMarca.SelectedValue)
                };
                milinq.Productos.InsertOnSubmit(newProdu);
                milinq.SubmitChanges();
                MessageBox.Show("Producto Creado");
                Limpiar();
                CargarProductos();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        public void CargarProductos()
        {
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var productos = from producto in milinq.v_ListaProductos
                                select producto;

                dataGridView1.DataSource = productos.ToList();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox5.Text;
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var productos = from producto in milinq.v_ListadoProductos
                                where producto.codigo_producto.ToString().ToLower().Contains(filtro.ToLower()) ||
                                     producto.nombre_producto.ToLower().Contains(filtro.ToLower()) ||
                                     producto.nombre_marca.ToLower().Contains(filtro.ToLower())
                                select producto;

                dataGridView1.DataSource = productos.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
