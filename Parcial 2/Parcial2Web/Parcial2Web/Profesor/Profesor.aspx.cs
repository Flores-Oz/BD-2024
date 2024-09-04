using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Web.Profesor
{
    public partial class Profesor : System.Web.UI.Page
    {
        DB.DataClasses1DataContext LINQ = new DB.DataClasses1DataContext(Conexion.CADENA);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProfesorCurso();
                CargarAsigna();
            }
        }
        
        public void CargarProfesorCurso()
        {
            string cod = Session["DPI"].ToString();
            var profes = from prof in LINQ.VistaAsignaProfe
                         where prof.dpi_profesor == cod
                         select prof;
            GridViewCursosDisponibles.DataSource = profes;
            GridViewCursosDisponibles.DataBind();
        }

        public void CargarAsigna()
        {
            string cod = Session["DPI"].ToString();
            var profes = from asignacion in LINQ.Asignacion
                         join profesorCurso in LINQ.Profesor_Curso
                         on asignacion.codigo_prof_curso equals profesorCurso.codigo_prof_curso
                         where profesorCurso.dpi_profesor == cod
                         select new
                         {
                             asignacion.codigo_asignacion,
                             asignacion.fecha_asignacion,
                             asignacion.zona,
                             asignacion.final,
                             asignacion.total,
                             asignacion.resultado,
                             asignacion.estado_delegado,
                             asignacion.codigo_alumno,
                             asignacion.codigo_prof_curso
                         };
            GridView1.DataSource = profes;
            GridView1.DataBind();
        }

        protected void GridViewCursosDisponibles_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewCursosDisponibles.PageIndex = e.NewPageIndex;
            CargarProfesorCurso();
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int index = GridView1.SelectedIndex;

            // Obtener el valor de la clave primaria (codigo_asignacion) de la fila seleccionada
            int codigoAsignacion = Convert.ToInt32(GridView1.DataKeys[index].Value);

            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                // Obtener los detalles de la asignación seleccionada
                var asignacion = context.Asignacion.FirstOrDefault(a => a.codigo_asignacion == codigoAsignacion);

                if (asignacion != null)
                {
                    // Igualar los valores de la asignación con los TextBox correspondientes
                    TextBoxFechaAsign.Text = asignacion.fecha_asignacion.ToString("yyyy-MM-dd");
                    TextBoxFinal.Text = asignacion.final.ToString();
                    TextBoxResultado.Text = asignacion.resultado;
                    TextBoxCodAlum.Text = asignacion.codigo_alumno.ToString();
                    TextBoxZona.Text = asignacion.zona.ToString();
                    TextBox3.Text = asignacion.total.ToString();
                    CheckBoxDelegado.Checked = asignacion.estado_delegado;
                    TextBoxCodProfCurso.Text = asignacion.codigo_prof_curso.ToString();
                }
                else
                {
                    // Mostrar un mensaje si la asignación no se encuentra
                    ClientScript.RegisterStartupScript(this.GetType(), "showMessageError", "alert('Asignación no encontrada');", true);
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            CargarProfesorCurso();
        }
    }
}