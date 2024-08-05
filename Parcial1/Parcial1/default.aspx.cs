using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1
{
    public partial class _default : System.Web.UI.Page
    {
        DB.DataClasses1DataContext milinq = new DB.DataClasses1DataContext(Conexion.CADENA);

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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarClientes();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}