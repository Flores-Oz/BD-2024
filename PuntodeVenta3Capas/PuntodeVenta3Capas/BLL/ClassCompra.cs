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
    public class ClassCompra
    {
        //atributos instancia clase
        private Enca_CompraTableAdapter encabeCompra = new Enca_CompraTableAdapter();
        private Detalle_CompraTableAdapter detalleCompra = new Detalle_CompraTableAdapter();
        //encapsulamiento, propiedades
        private Enca_CompraTableAdapter ENCACOMPRA
        {
            get
            {
                if (encabeCompra == null)
                    encabeCompra = new Enca_CompraTableAdapter();
                return encabeCompra;
            }
        }
        private Detalle_CompraTableAdapter DETALCOMPRA
        {
            get
            {
                if (detalleCompra == null)
                    detalleCompra = new Detalle_CompraTableAdapter();
                return detalleCompra;
            }
        }
        public int AgregarEncaCompra(DateTime fechaCompra, decimal totalCompra, int totalProducto,
            string dpi)
        {
            try
            {
                encabeCompra.AgregarEncaCompra(fechaCompra,totalCompra,totalProducto,dpi);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int AgregarDetalCompra(int cantidad, decimal precioCosto, decimal precioVenta, decimal subtotal,
            int codigoCompra, int codigoProduc)
        {
            try
            {
                detalleCompra.IngresarDetalleCompra(cantidad, precioCosto, precioVenta, subtotal, codigoCompra, codigoProduc);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int ObtenerUltimoCodigo()
        {
            int ultimoCodigo = 0;

            string query = "SELECT TOP 1 codigo_compra FROM Enca_Compra ORDER BY fecha_compra DESC";

            using (SqlConnection conn = new SqlConnection(Conexion.CADENA))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    ultimoCodigo = Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("No se encontraron registros en la tabla Enca_Compra.");
                }
            }

            return ultimoCodigo;
        }

    }
}