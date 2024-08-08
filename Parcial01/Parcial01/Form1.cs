using Parcial01.Busquedas;
using Parcial01.Ingresos;
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

namespace Parcial01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
              IsMdiContainer = true;
               this.FormClosed += new FormClosedEventHandler(Inicio_FormClosed);
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra a = new Compra();
            a.MdiParent = this;
            a.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCliente a = new BCliente();
            a.MdiParent = this;
            a.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BProducto a = new BProducto();
            a.MdiParent = this;
            a.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores a = new Proveedores();
            a.MdiParent = this;
            a.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BProveedor a = new BProveedor();
            a.MdiParent = this;
            a.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Producto a = new Producto();
            a.MdiParent = this;
            a.Show();
        }

        private void historialCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialCompra a = new HistorialCompra();
            a.MdiParent = this;
            a.Show();
        }
    }
}
