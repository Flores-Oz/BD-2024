using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Web.MasterWebs
{
    public partial class SiteProfesor : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Session["Usuario"].ToString();
            Label1.Text = Session["DPI"].ToString();
        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../default.aspx");
        }
    }
}