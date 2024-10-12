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
        private Cliente1TableAdapter cliente1 = new Cliente1TableAdapter();
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
        private Cliente1TableAdapter CLIENTE1
        {
            get
            {
                if (cliente1 == null)
                    cliente1 = new Cliente1TableAdapter();
                return cliente1;
            }
        }
        //metodo
        public DataTable LlenarClientes()
        {
            return CLIENTE.GetData();
        }
        public DataTable BuscarCliente(string NIT)
        {
            return CLIENTE1.GetDataByNIT(NIT);
        }

    }
}