using System;
using System.Collections.Generic;
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
        //Cargas
        public void CargarClientes()
        {
            GridViewClientes.DataSource = client.LlenarClientes();
            GridViewClientes.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarClientes();
            }
        }

    }
}