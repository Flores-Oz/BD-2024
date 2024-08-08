using Parcial01.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial01.Ingresos
{
    public partial class Proveedores : Form
    {
        string nut;
        public Proveedores()
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
        public void Limpiar()
        {
            textBoxNit.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxDireccion.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNit.Text) &&
        !string.IsNullOrEmpty(textBoxNombre.Text) &&
        !string.IsNullOrEmpty(textBoxDireccion.Text) &&
        !string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                BD.Proveedor newProvee = new BD.Proveedor
                {
                    nit_proveedor = textBoxNit.Text,
                    nombre_proveedor = textBoxNombre.Text,
                    direccion_proveedor = textBoxDireccion.Text,
                    telefono_proveedor = textBoxTelefono.Text
                };
                milinq.Proveedors.InsertOnSubmit(newProvee);
                milinq.SubmitChanges();
                MessageBox.Show("Proveedor Creado");
                Limpiar();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxNit.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxDireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxTelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox5.Text;
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var prov = from prove in milinq.Proveedors
                           where prove.nit_proveedor.ToLower().Contains(filtro.ToLower()) ||
                                 prove.nombre_proveedor.ToLower().Contains(filtro.ToLower())
                           select prove;

                dataGridView1.DataSource = prov.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNit.Text) &&
        !string.IsNullOrEmpty(textBoxNombre.Text) &&
        !string.IsNullOrEmpty(textBoxDireccion.Text) &&
        !string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                string nit = textBoxNit.Text;
                textBoxNit.Enabled = false;

                using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
                {
                    var proveedorExistente = milinq.Proveedors.SingleOrDefault(p => p.nit_proveedor == nit);

                    if (proveedorExistente != null)
                    {
                        proveedorExistente.nombre_proveedor = textBoxNombre.Text;
                        proveedorExistente.direccion_proveedor = textBoxDireccion.Text;
                        proveedorExistente.telefono_proveedor = textBoxTelefono.Text;
                        milinq.SubmitChanges();

                        MessageBox.Show("Proveedor Actualizado");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado");
                    }
                }
                Limpiar();
                textBoxNit.Enabled = true;
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}
