using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PuntodeVenta3Capas.DAL;
using PuntodeVenta3Capas.DAL.DataSetGeneralTableAdapters;

namespace PuntodeVenta3Capas.BLL
{
    public class ClassCliente
    {
        //atributos instancia clase
        private ClienteTableAdapter cliente = new ClienteTableAdapter();
        //encapsulamiento, propiedades
        private ClienteTableAdapter CLIENTE
        {
            get
            {
                if (cliente == null)
                    cliente = new ClienteTableAdapter();
                return cliente;
            }
        }
        //metodo
        public DataTable LlenarClientes()
        {
            return CLIENTE.GetData();
        }
        public DataTable BuscarCLiente(string NIT)
        {
            return CLIENTE.GetData();
        }
    }
}