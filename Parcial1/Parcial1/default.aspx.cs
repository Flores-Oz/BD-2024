using Parcial1.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1
{
    public partial class _default : System.Web.UI.Page
    {
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

        DB.DataClasses1DataContext milinq = new DB.DataClasses1DataContext(Conexion.CADENA);
        String NITo;

        public void CargarClientes()
        {
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var clientes = from cliente in milinq.v_ListadodeClientes
                               select cliente;

                GridViewClientes.DataSource = clientes.ToList();
                GridViewClientes.DataBind();
            }
        }
        public void CargarProductos()
        {
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var productos = from producto in milinq.v_ListadoProductos
                                select producto;

                GridViewProductos.DataSource = productos.ToList();
                GridViewProductos.DataBind();
            }
        }
        public void CargarTexto()
        {
            TextBoxNIT.Text = NITo;
            string nit = TextBoxNIT.Text.Trim();
            if (string.IsNullOrEmpty(nit))
            {
                // Limpiar los campos si el NIT está vacío
                TextBoxNombre.Text = string.Empty;
                TextBoxApellido.Text = string.Empty;
                TextBoxDireccion.Text = string.Empty;
                TextBoxTelefono.Text = string.Empty;
                return;
            }

            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var cliente = milinq.Clientes
                    .Where(c => c.nit_cliente.ToLower() == nit.ToLower())
                    .FirstOrDefault();

                if (cliente != null)
                {
                    // Llenar los TextBox con la información del cliente encontrado
                    TextBoxNombre.Text = cliente.nombre_cliente;
                    TextBoxApellido.Text = cliente.apellido_cliente;
                    TextBoxDireccion.Text = cliente.direccion_cliente;
                    TextBoxTelefono.Text = cliente.telefono_cliente;
                }
                else
                {
                    // Limpiar los campos y mostrar mensaje si el cliente no se encuentra
                    TextBoxNombre.Text = string.Empty;
                    TextBoxApellido.Text = string.Empty;
                    TextBoxDireccion.Text = string.Empty;
                    TextBoxTelefono.Text = string.Empty;

                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarClientes();
                CargarProductos();
                GridView1.DataSource = productosSeleccionados;
                GridView1.DataBind();
            }
         
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Multiply")
            {
                // Obtener el índice de la fila desde el CommandArgument
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                // Obtener los valores usando DataBinder.Eval
                object valor1Obj = DataBinder.Eval(row.DataItem, "PrecioCosto");
                object valor2Obj = DataBinder.Eval(row.DataItem, "Cantidad");

                // Validar y convertir los valores
                if (valor1Obj != null && valor2Obj != null)
                {
                    string valor1Str = valor1Obj.ToString();
                    string valor2Str = valor2Obj.ToString();

                    // Limpia el formato si es necesario (como reemplazar comas por puntos)
                    valor1Str = valor1Str.Replace(",", ".");
                    valor2Str = valor2Str.Replace(",", ".");

                    // Convertir a decimal de manera segura
                    if (decimal.TryParse(valor1Str, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor1) &&
                        decimal.TryParse(valor2Str, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor2))
                    {
                        decimal resultado = valor1 * valor2;

                        // Mostrar el resultado en un Label
                        Label lblResultado = row.FindControl("LabelResultado") as Label;
                        if (lblResultado != null)
                        {
                            lblResultado.Text = resultado.ToString("C");
                        }
                    }
                    else
                    {
                        // Manejar el error de formato
                        Label lblResultado = row.FindControl("LabelResultado") as Label;
                        if (lblResultado != null)
                        {
                            lblResultado.Text = "Error de formato en los datos.";
                        }
                    }
                }
                else
                {
                    // Manejar datos nulos
                    Label lblResultado = row.FindControl("LabelResultado") as Label;
                    if (lblResultado != null)
                    {
                        lblResultado.Text = "Datos no válidos.";
                    }
                }
            }
        }

        protected void GridViewClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewClientes.PageIndex = e.NewPageIndex;
            CargarClientes();
        }

        protected void GridViewClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
        public void CargarClientes(string filtro = "")
        {
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var clientes = from cliente in milinq.v_ListadodeClientes
                               where cliente.NIT.ToLower().Contains(filtro.ToLower()) ||
                                     cliente.Nombres.ToLower().Contains(filtro.ToLower())
                               select cliente;

                GridViewClientes.DataSource = clientes.ToList();
                GridViewClientes.DataBind();
            }
        }

        public void CargarProduc(string filtro = "")
        {
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var productos = from producto in milinq.v_ListadoProductos
                                where producto.codigo_producto.ToString().ToLower().Contains(filtro.ToLower()) ||
                                     producto.nombre_producto.ToLower().Contains(filtro.ToLower()) ||
                                     producto.nombre_marca.ToLower().Contains(filtro.ToLower())
                                select producto;

                GridViewProductos.DataSource = productos.ToList();
                GridViewProductos.DataBind();
            }
        }

        protected void TextBoxBN_TextChanged(object sender, EventArgs e)
        {
            CargarClientes(TextBoxBN.Text.Trim());
        }

        protected void GridViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridViewClientes.SelectedIndex;
            NITo = GridViewClientes.SelectedDataKey.Value.ToString();
            CargarTexto();
        }

        protected void TextBoxNIT_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxBP_TextChanged(object sender, EventArgs e)
        {
            CargarProduc(TextBoxBP.Text.Trim());
        }

        protected void GridViewProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewProductos.PageIndex = e.NewPageIndex;
            CargarProductos();
        }

        protected void GridViewProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridViewProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Seleccionar")
            {
                string codigoProducto = e.CommandArgument.ToString();

                using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    var productoSeleccionado = milinq.v_ListadoProductos
                        .Where(p => p.codigo_producto.ToString() == codigoProducto)
                        .FirstOrDefault();

                    if (productoSeleccionado != null)
                    {
                        // Verificar si el producto ya está en la lista
                        if (!productosSeleccionados.Any(p => p.CodigoProducto == productoSeleccionado.codigo_producto.ToString()))
                        {
                            // Crear un nuevo producto seleccionado y agregarlo a la lista
                            ProductoSeleccionado nuevoProducto = new ProductoSeleccionado
                            {
                                CodigoProducto = productoSeleccionado.codigo_producto.ToString(),
                                NombreProducto = productoSeleccionado.nombre_producto,
                                PrecioCosto = productoSeleccionado.precio_costo,
                                NombreMarca = productoSeleccionado.nombre_marca,
                                Cantidad = 1, // Valor inicial
                                Total = productoSeleccionado.precio_costo // Precio por cantidad inicial
                            };

                            productosSeleccionados.Add(nuevoProducto);

                            // Actualizar el segundo GridView
                            GridView1.DataSource = productosSeleccionados;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TextBox txtCantidad = (TextBox)e.Row.FindControl("TextBoxCantidad");
                Label lblTotal = (Label)e.Row.FindControl("LabelTotal");

                if (txtCantidad != null && lblTotal != null)
                {
                    txtCantidad.Text = "1";
                    decimal precioCosto = Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "PrecioCosto"));
                    txtCantidad.TextChanged += (s, args) =>
                    {
                        TextBox txt = (TextBox)s;
                        decimal cantidad = Convert.ToDecimal(txt.Text);
                        decimal total = precioCosto * cantidad;
                        lblTotal.Text = total.ToString("C");
                    };
                }
            }
        }

        protected void TextBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Obtener el botón que activó el evento
            Button button = sender as Button;
            if (button == null)
            {
                // El sender no es un botón, salir del método
                return;
            }

            // Obtener la fila del GridView que contiene el botón
            GridViewRow row = button.NamingContainer as GridViewRow;
            if (row == null)
            {
                // No se pudo convertir a GridViewRow, salida del método
                return;
            }

            // Obtener los valores usando DataBinder.Eval
            object valor1Obj = DataBinder.Eval(row.DataItem, "PrecioCosto");
            object valor2Obj = DataBinder.Eval(row.DataItem, "Cantidad");

            // Convertir los valores a decimal y manejar posibles valores nulos
            if (valor1Obj != null && valor2Obj != null &&
                decimal.TryParse(valor1Obj.ToString(), out decimal valor1) &&
                decimal.TryParse(valor2Obj.ToString(), out decimal valor2))
            {
                // Multiplicar los valores
                decimal resultado = valor1 * valor2;

                // Hacer algo con el resultado, por ejemplo, mostrarlo en un Label
                Label lblResultado = (Label)row.FindControl("LabelResultado");
                if (lblResultado != null)
                {
                    lblResultado.Text = resultado.ToString("C");
                }
            }
            else
            {
                // Manejar el caso en el que los valores no son válidos
                Label lblResultado = (Label)row.FindControl("LabelResultado");
                if (lblResultado != null)
                {
                    lblResultado.Text = "Error";
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}