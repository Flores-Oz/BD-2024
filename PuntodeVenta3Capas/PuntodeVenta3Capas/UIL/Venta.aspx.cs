
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuntodeVenta3Capas.BLL;

namespace PuntodeVenta3Capas.UIL
{
    public partial class Venta : System.Web.UI.Page
    { 
        //Clases
        ClassCliente client = new ClassCliente();
        ClassProducto product = new ClassProducto();
        ClassCompra compra = new ClassCompra();
        //Cargas
        public void CargarClientes()
        {
            GridViewClientes.DataSource = client.LlenarClientes();
            GridViewClientes.DataBind();
        }
        public void CargarProductos()
        {
            GridViewProducto.DataSource = product.ListarProductos();
            GridViewProducto.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarClientes();
                CargarProductos();
            }
        }

        protected void TextBoxBuscarNit_TextChanged(object sender, EventArgs e)
        {
            string dpi = TextBoxBuscarNit.Text;
            GridViewClientes.DataSource = client.BuscarCliente(dpi);
            GridViewClientes.DataBind();
        }

        protected void GridViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridViewClientes.SelectedIndex;

            string DPI = GridViewClientes.DataKeys[selectedIndex].Value.ToString();
            txtNIT.Text = DPI; 
        }

        protected void TxtBuscarPro_TextChanged(object sender, EventArgs e)
        {
            int cod = Convert.ToInt16(TxtBuscarPro.Text);
            GridViewProducto.DataSource = product.BuscarProdcuto(cod);
            GridViewProducto.DataBind();
        }

        protected void GridViewProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridViewProducto.SelectedIndex;

            string codigoProducto = GridViewProducto.DataKeys[selectedIndex].Values["codigo_producto"].ToString();
            string nombreProducto = GridViewProducto.DataKeys[selectedIndex].Values["nombre_producto"].ToString();
            string precioCosto = GridViewProducto.DataKeys[selectedIndex].Values["precio_costo"].ToString();

            TextBoxCodP.Text = codigoProducto;
            txtNombreProducto.Text = nombreProducto;
            txtPrecioVenta.Text = precioCosto;
        }

        private DataTable dtListaProductos
        {
            get
            {
                if (ViewState["dtListaProductos"] == null)
                {
                    // Crear la tabla si aún no está creada
                    DataTable dt = new DataTable();
                    dt.Columns.Add("codigo_producto", typeof(int));
                    dt.Columns.Add("nombre_producto", typeof(string));
                    dt.Columns.Add("precio_costo", typeof(decimal));
                    dt.Columns.Add("cantidad", typeof(int));  // Columna para la cantidad
                    dt.Columns.Add("subtotal", typeof(decimal)); // Columna para el subtotal

                    ViewState["dtListaProductos"] = dt;
                }
                return (DataTable)ViewState["dtListaProductos"];
            }
            set
            {
                ViewState["dtListaProductos"] = value;
            }
        }

        protected void BttnAgregar_Click(object sender, EventArgs e)
        {
            int selectedIndex = GridViewProducto.SelectedIndex;
            if (selectedIndex != -1)
            {
                string codigoProducto = GridViewProducto.DataKeys[selectedIndex].Values["codigo_producto"].ToString();
                string nombreProducto = GridViewProducto.DataKeys[selectedIndex].Values["nombre_producto"].ToString();
                decimal precioCosto = Convert.ToDecimal(GridViewProducto.DataKeys[selectedIndex].Values["precio_costo"]);
                decimal cantidad = Convert.ToDecimal(txtCantidad.Text);
                //Cantidad Actualizar
                int cant = Convert.ToInt32(cantidad);
                int prod = Convert.ToInt32(codigoProducto);
                product.ActualizarExistencia(cant, prod);
                decimal subtotal = precioCosto * cantidad;

                // Agregar el producto a la tabla temporal
                DataTable dt = dtListaProductos;
                DataRow nuevaFila = dt.NewRow();
                nuevaFila["codigo_producto"] = codigoProducto;
                nuevaFila["nombre_producto"] = nombreProducto;
                nuevaFila["precio_costo"] = precioCosto;
                nuevaFila["cantidad"] = cantidad;
                nuevaFila["subtotal"] = subtotal;  
                dt.Rows.Add(nuevaFila);

                dtListaProductos = dt;

                GridViewListaProductos.DataSource = dtListaProductos;
                GridViewListaProductos.DataBind();
                CargarProductos();
            }
        }

        protected void GridViewListaProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;

            DataTable dt = dtListaProductos;
            dt.Rows[index].Delete();
            dtListaProductos = dt;

            GridViewListaProductos.DataSource = dtListaProductos;
            GridViewListaProductos.DataBind();
        }

        protected void ButtonComprar_Click(object sender, EventArgs e)
        {
            int totalCantidad = 0;
            decimal totalSubtotal = 0m;
            foreach (DataRow row in dtListaProductos.Rows)
            {
                totalCantidad += Convert.ToInt32(row["cantidad"]);
                totalSubtotal += Convert.ToDecimal(row["subtotal"]);
            }
            LabelCantTotal.Text = totalCantidad.ToString();
            LabelTotal.Text = totalSubtotal.ToString();
            //Comenzar Proceso
            DateTime fechaCompra = DateTime.Now; // Fecha actual
            string dpi = txtNIT.Text; 
            int codigoCompra = compra.AgregarEncaCompra(fechaCompra, totalSubtotal, totalCantidad, dpi);

            foreach (DataRow row in dtListaProductos.Rows)
            {
                int cantidad = Convert.ToInt32(row["cantidad"]);
                decimal precioCosto = Convert.ToDecimal(row["precio_costo"]);
                decimal precioVenta = 0; 
                decimal subtotal = Convert.ToDecimal(row["subtotal"]);
                int codigoProducto = Convert.ToInt32(row["codigo_producto"]);
                int codigoCompra2 = compra.ObtenerUltimoCodigo();
                compra.AgregarDetalCompra(cantidad, precioCosto, precioVenta, subtotal, codigoCompra2, codigoProducto);
            }
            dtListaProductos.Clear();
            GridViewListaProductos.DataSource = dtListaProductos;
            GridViewListaProductos.DataBind();
            //Mensaje
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showSuccessMessage();", true);
        }

        public void Limpiar()
        {
            LabelCantTotal.Text = "";
            LabelTotal.Text = "";
            txtCantidad.Text = "";
            txtNIT.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioVenta.Text = "";
        }
    }
}