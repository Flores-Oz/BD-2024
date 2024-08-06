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
    public partial class BCliente : Form
    {
       
        public BCliente()
        {
            InitializeComponent();
        }

        BD.DataClasses1DataContext milinq = new BD.DataClasses1DataContext(Conexion.CADENA);

        public void CargarClientes()
        {
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var clientes = from cliente in milinq.v_ListadodeClientes
                               select cliente;

                dataGridViewClientes.DataSource = clientes.ToList();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text;
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var clientes = from cliente in milinq.v_ListadodeClientes
                               where cliente.NIT.ToLower().Contains(filtro.ToLower()) ||
                                     cliente.Nombres.ToLower().Contains(filtro.ToLower())
                               select cliente;

                dataGridViewClientes.DataSource = clientes.ToList();
            }
        }

        private void dataGridViewClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void BCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Venta.Nito = dataGridViewClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}
