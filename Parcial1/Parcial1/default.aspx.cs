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

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}