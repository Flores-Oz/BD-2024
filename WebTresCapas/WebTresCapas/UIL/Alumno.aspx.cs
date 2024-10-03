using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTresCapas.BLL;

namespace WebTresCapas.UIL
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ClassAlumno logicAlumn = new ClassAlumno();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int resp = logicAlumn.nuevoAlumno(
                '123'
                );
            if(resp == 1 )
            {
                Response.Write("Existoso");
            }
            else
            {
                Response.Write("Error");
            }
        }
    }
}