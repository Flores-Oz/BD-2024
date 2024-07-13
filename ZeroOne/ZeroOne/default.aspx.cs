using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZeroOne
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BD.LinqBDDataContext DB = new BD.LinqBDDataContext(BD.ClaseGeneral.cadena);
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            var login = (from user in DB.Usuarios
                         where user.Usuario1 == TextBoxUser.Text && user.Password == TextBoxPass.Text
                         select user).FirstOrDefault();

            if (login != null)
            {
                Session["Username"] = login.Usuario1;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                
                
            }
        }
    }
}