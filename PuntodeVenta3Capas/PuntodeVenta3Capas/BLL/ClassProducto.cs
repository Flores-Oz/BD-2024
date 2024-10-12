using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuntodeVenta3Capas.DAL;
using PuntodeVenta3Capas.DAL.DataSetGeneralTableAdapters;

namespace PuntodeVenta3Capas.BLL
{
    public class ClassProducto
    {
        //atributos instancia clase
        private v_ListadoProductosTableAdapter producto = new v_ListadoProductosTableAdapter();
        private ProductoTableAdapter productos = new ProductoTableAdapter();
        //encapsulamiento, propiedades
        private v_ListadoProductosTableAdapter PRODUCTO
        {
            get
            {
                if (producto == null)
                    producto = new v_ListadoProductosTableAdapter();
                return producto;
            }
        }
        private ProductoTableAdapter PRODUCTOB
        {
            get
            {
                if (productos == null)
                    productos = new ProductoTableAdapter();
                return productos;
            }
        }

        public DataTable ListarProductos()
        {
            return PRODUCTO.GetData();
        }
        public DataTable BuscarProdcuto(int cod)
        {
            return PRODUCTO.BuscarporCod(cod);
        }
        public DataTable ObtenerExistencia(int codigoProducto)
        {
            DataTable dt = new DataTable();

            using (var connection = new SqlConnection(Conexion.CADENA))
            {
                using (var command = new SqlCommand("SELECT existencia_producto FROM Producto WHERE codigo_producto = @codigo", connection))
                {
                    command.Parameters.AddWithValue("@codigo", codigoProducto);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable ActualizarExistencia(int cant, int cod)
        {
            if (cant < 0)
            {
                throw new ArgumentException("La cantidad no puede ser negativa.");
            }

            DataTable produc = ObtenerExistencia(cod);

            if (produc.Rows.Count == 0)
            {
                throw new KeyNotFoundException("Producto no encontrado.");
            }

            int existenciaActual = Convert.ToInt32(produc.Rows[0]["existencia_producto"]);
            int nuevaExistencia = existenciaActual - cant;

            if (nuevaExistencia < 0)
            {
                throw new InvalidOperationException("La cantidad a restar excede la existencia actual.");
            }

            int filasAfectadas = PRODUCTOB.ActualizarExistenciaProducto(nuevaExistencia, cod);

            if (filasAfectadas > 0)
            {
                return PRODUCTO.BuscarporCod(cod);
            }
            else
            {
                throw new Exception("No se pudo actualizar la existencia del producto.");
            }
        }
    }
}