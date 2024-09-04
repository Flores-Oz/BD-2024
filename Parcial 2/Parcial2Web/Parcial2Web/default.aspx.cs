using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Web
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string usuario = TextBoxUser.Text.Trim();
            string contraseña = TextBoxPass.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "showMessageProfAsign", "showMessageProfAsign();", true);
                return;
            }

            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                // Verificar en la tabla Alumno
                var alumno = context.Alumno.FirstOrDefault(a => a.usuario_alumno == usuario && a.contrasenia == contraseña);

                if (alumno != null)
                {
                    // Credenciales válidas para Alumno
                    Session["Usuario"] = alumno.usuario_alumno;
                    Session["Carne"] = alumno.codigo_alumno.ToString();
                    Response.Redirect("Alumno/Inicio.aspx");
                }
                else
                {
                    // Verificar en la tabla Profesor
                    var profesor = context.Profesor.FirstOrDefault(p => p.usuario_profesor == usuario && p.contrasenia == contraseña);

                    if (profesor != null)
                    {
                        // Credenciales válidas para Profesor
                        Session["Usuario"] = profesor.usuario_profesor;
                        Session["DPI"] = profesor.dpi_profesor.ToString();
                        Response.Redirect("Profesor/Inicio.aspx");
                    }
                    else if (usuario == "ADMIN" && contraseña == "ADMIN123")
                    {
                        // Credenciales válidas para Administrador con valores fijos
                        Session["Usuario"] = "ADMIN";
                        Response.Redirect("Admin/Inicio.aspx");
                    }
                    else
                    {
                        // Credenciales inválidas
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageCursoG", "showMessageCursoG();", true);
                    }
                }
            }

        }
    }
}