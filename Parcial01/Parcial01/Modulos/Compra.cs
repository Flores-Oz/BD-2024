﻿using Parcial01.Busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial01.Modulos
{
    public partial class Compra : Form
    {
        public static string Nito;
        public static string Pro;
        public class ProductoSeleccionado
        {
            public string CodigoProducto { get; set; }
            public string NombreProducto { get; set; }
            public decimal PrecioCosto { get; set; }
            public string NombreMarca { get; set; }
            public int Cantidad { get; set; }
            public decimal Total { get; set; }
        }
        private static List<ProductoSeleccionado> productosSeleccionados = new List<ProductoSeleccionado>();
        public Compra()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public void Limpiar()
        {
            textBoxNIT.Text = string.Empty;
            textBoxNombres.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxDireccion.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            labelSubTotal.Text = "0";
            labeTotal.Text = "0";
            labeLTotalProductos.Text = "0";
            textBoxDescuento.Text = "0";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            CalcularSubTotal();
            CalcularTotalProductos();
            if (double.TryParse(textBoxDescuento.Text, out double descuento) && Double.TryParse(labelSubTotal.Text, out double subTotal))
            {
                double total;
                if (descuento == 0)
                {
                    total = subTotal; 
                }
                else
                {
                    total = subTotal - (subTotal * (descuento / 100)); 
                }
                labeTotal.Text = total.ToString("F2");
            }
            using (var transa = new TransactionScope())
            {
                try
                {
                    using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
                    {
                        // Insertar en Enca_Compra
                        BD.Enca_Compra nuevaEncaCompra = new BD.Enca_Compra
                        {
                            //codigo_compra = Convert.ToInt32(textBoxCodCompra.Text),
                            fecha_compra = Convert.ToDateTime(dateCompra.Text),
                            total_compra = Convert.ToDecimal(labeTotal.Text),
                            total_producto = Convert.ToInt32(labeLTotalProductos.Text),
                            dpi_cliente = textBoxNIT.Text
                        };

                        milinq.Enca_Compras.InsertOnSubmit(nuevaEncaCompra);
                        milinq.SubmitChanges();

                        // Insertar en Detalle_Compra y actualizar Producto
                        foreach (var prod in productosSeleccionados)
                        {
                            // Insertar detalle de compra
                            BD.Detalle_Compra nuevoDetalleCompra = new BD.Detalle_Compra
                            {
                                codigo_compra = nuevaEncaCompra.codigo_compra,
                                codigo_producto = Convert.ToInt32(prod.CodigoProducto),
                                cantidad = prod.Cantidad,
                                precio_costo = prod.PrecioCosto,
                                subtotal = prod.Cantidad * prod.PrecioCosto
                            };

                            milinq.Detalle_Compras.InsertOnSubmit(nuevoDetalleCompra);

                            // Actualizar stock del producto
                            var producto = milinq.Productos.SingleOrDefault(p => p.codigo_producto == Convert.ToInt32(prod.CodigoProducto));
                            if (producto != null)
                            {
                                producto.existencia_producto -= prod.Cantidad;
                            }
                        }
                        milinq.SubmitChanges();
                        transa.Complete();
                        MessageBox.Show("Compra registrada exitosamente.");
                        productosSeleccionados.Clear();
                        dataGridViewLista.DataSource = null;
                        dataGridViewLista.Rows.Clear();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al registrar la compra: " + ex.Message);
                }
            }

        }
        private bool isUpdatingText = false; 

        public void CargarTexto()
        {
            if (isUpdatingText)
                return;

            isUpdatingText = true;

            string nit = textBoxNIT.Text.Trim();
            if (string.IsNullOrEmpty(nit))
            {
                textBoxNombres.Text = string.Empty;
                textBoxApellido.Text = string.Empty;
                textBoxDireccion.Text = string.Empty;
                textBoxTelefono.Text = string.Empty;
            }
            else
            {
                using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
                {
                    var cliente = milinq.Clientes
                        .Where(c => c.nit_cliente.ToLower() == nit.ToLower())
                        .FirstOrDefault();

                    if (cliente != null)
                    {
                        textBoxNombres.Text = cliente.nombre_cliente;
                        textBoxApellido.Text = cliente.apellido_cliente;
                        textBoxDireccion.Text = cliente.direccion_cliente;
                        textBoxTelefono.Text = cliente.telefono_cliente;
                    }
                }
            }

            isUpdatingText = false;
        }
        private void textBoxNIT_TextChanged(object sender, EventArgs e)
        {
            if (!isUpdatingText)
            {
                CargarTexto();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BCliente a = new BCliente();
            a.ShowDialog();
            textBoxNIT.Text = Nito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BProducto a = new BProducto();
            a.ShowDialog();
            using (var milinq = new BD.DataClasses1DataContext(Conexion.CADENA))
            {
                var productoSeleccionado = milinq.v_ListadoProductos
                    .FirstOrDefault(p => p.codigo_producto.ToString() == Pro);

                if (productoSeleccionado != null)
                {
                    // Verificar si el producto ya está en la lista de productos seleccionados
                    bool productoYaSeleccionado = productosSeleccionados
                        .Any(p => p.CodigoProducto == productoSeleccionado.codigo_producto.ToString());

                    if (!productoYaSeleccionado)
                    {
                        // Crear un nuevo objeto ProductoSeleccionado y agregarlo a la lista
                        ProductoSeleccionado nuevoProducto = new ProductoSeleccionado
                        {
                            CodigoProducto = productoSeleccionado.codigo_producto.ToString(),
                            NombreProducto = productoSeleccionado.nombre_producto,
                            PrecioCosto = productoSeleccionado.precio_costo,
                            NombreMarca = productoSeleccionado.nombre_marca,
                            Cantidad = 1, // Valor inicial
                            Total = productoSeleccionado.precio_costo
                        };

                        productosSeleccionados.Add(nuevoProducto);
                        dataGridViewLista.DataSource = null;
                        dataGridViewLista.DataSource = productosSeleccionados;
                    }
                }
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTexto();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewLista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewLista.Columns["Cantidad"].Index)
            {
                var row = dataGridViewLista.Rows[e.RowIndex];
                if (int.TryParse(row.Cells["Cantidad"].Value.ToString(), out int cantidad))
                {
                    var producto = productosSeleccionados[e.RowIndex];
                    producto.Cantidad = cantidad;
                    producto.Total = cantidad * producto.PrecioCosto;
                    dataGridViewLista.Refresh();
                }
            }
            if (e.ColumnIndex == dataGridViewLista.Columns["Total"].Index)
            {
                CalcularSubTotal();
            }
            if (e.ColumnIndex == dataGridViewLista.Columns["Cantidad"].Index)
            {
                CalcularTotalProductos();
            }
        }
        private void InitializeDataGridView()
        {
            // Verifica que la columna exista antes de modificarla
            if (dataGridViewLista.Columns.Contains("Cantidad"))
            {
                dataGridViewLista.Columns["Cantidad"].ReadOnly = false;
            }
            else
            {
               
            }
        }

        private void dataGridViewLista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewLista.Columns["Cantidad"].Index)
            {
                dataGridViewLista_CellValueChanged(sender, e);
            }
        }
        public void CalcularSubTotal()
        {
            decimal totalGeneral = 0m;
            foreach (DataGridViewRow row in dataGridViewLista.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (decimal.TryParse(row.Cells["Total"].Value?.ToString(), out decimal valorTotal))
                    {
                        totalGeneral += valorTotal;
                    }
                }
            }
            labelSubTotal.Text = totalGeneral.ToString();
        }
        public void CalcularTotalProductos()
        {
            decimal totalGeneral = 0m;
            foreach (DataGridViewRow row in dataGridViewLista.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (decimal.TryParse(row.Cells["Cantidad"].Value?.ToString(), out decimal valorTotal))
                    {
                        totalGeneral += valorTotal;
                    }
                }
            }
            labeLTotalProductos.Text = totalGeneral.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridViewLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CalcularSubTotal();
            CalcularTotalProductos();
        }
    }
}
