using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Web.Alumno
{
    public partial class Alumno : System.Web.UI.Page
    {
        DB.DataClasses1DataContext LINQ = new DB.DataClasses1DataContext(Conexion.CADENA);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatosCursos();
                CargarCursosAsignados();
            }
        }

        private void CargarDatosCursos()
        {
            var profes = from prof in LINQ.VistaAsignaProfe
                         select new
                         {
                             Codigo_Ciclo = prof.codigo_ciclo,
                             Ciclo = prof.nombre_ciclo,
                             Codigo_Curso = prof.codigo_curso,
                             Curso = prof.nombre_curso,
                             Codigo = prof.codigo_curso,
                             Profesor = prof.Profesor
                         };

            GridViewCursosDisponibles.DataSource = profes;
            GridViewCursosDisponibles.DataBind();
        }

        private void CargarCursosAsignados()
        {
            int cod = Convert.ToInt32(Session["Carne"]);
            var profes = from prof in LINQ.Asignacion
                         where Convert.ToInt32(prof.codigo_alumno) == cod
                         select prof;
            GridViewCursosAsignados.DataSource = profes;
            GridViewCursosAsignados.DataBind();
        }


        protected void GridViewCursosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int index = GridViewCursosDisponibles.SelectedIndex;

            // Obtener el valor de la clave primaria (codigo_prof_curso) de la fila seleccionada
            int codigoProfCurso = Convert.ToInt32(GridViewCursosDisponibles.DataKeys[index].Value);
            int carneAlumn = Convert.ToInt32(Session["Carne"]);

            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                // Verificar si el alumno ya está asignado a este curso
                var asignacionExistente = context.Asignacion
                    .FirstOrDefault(a => a.codigo_prof_curso == codigoProfCurso && a.codigo_alumno == carneAlumn.ToString());

                if (asignacionExistente != null)
                {
                    // Si ya existe la asignación, mostrar un mensaje de error
                    ClientScript.RegisterStartupScript(this.GetType(), "showMessageError", "alert('El alumno ya está asignado a este curso.');", true);
                }
                else
                {
                    // Crear un nuevo objeto de la entidad que deseas guardar
                    var nuevaAsignacion = new DB.Asignacion
                    {
                        codigo_prof_curso = codigoProfCurso,
                        codigo_alumno = carneAlumn.ToString(),
                        fecha_asignacion = DateTime.Now,
                        resultado = "0"
                    };

                    // Guardar los datos en la base de datos
                    context.Asignacion.InsertOnSubmit(nuevaAsignacion);
                    context.SubmitChanges();

                    // Mostrar un mensaje de éxito
                    ClientScript.RegisterStartupScript(this.GetType(), "showMessageSuccess", "alert('Datos guardados exitosamente');", true);
                }
            }

        }

        protected void GridViewCursosDisponibles_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewCursosDisponibles.PageIndex = e.NewPageIndex;
            CargarDatosCursos();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string filtro = TextBox2.Text;
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var profes = from prof in LINQ.VistaAsignaProfe
                             where prof.Profesor.ToLower().Contains(filtro.ToLower()) ||
                                   prof.nombre_ciclo.ToLower().Contains(filtro.ToLower()) ||
                                   prof.nombre_curso.ToLower().Contains(filtro.ToLower())
                             select new
                             {
                                 Codigo_Ciclo = prof.codigo_ciclo,
                                 Ciclo = prof.nombre_ciclo,
                                 Codigo_Curso = prof.codigo_curso,
                                 Curso = prof.nombre_curso,
                                 Profesor = prof.Profesor
                             };

                GridViewCursosDisponibles.DataSource = profes.ToList();
                GridViewCursosDisponibles.DataBind();
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string filtro = TextBox2.Text;
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var profes = from prof in LINQ.Asignacion
                             where prof.resultado.ToLower().Contains(filtro.ToLower())
                             select prof;

                GridViewCursosAsignados.DataSource = profes.ToList();
                GridViewCursosAsignados.DataBind();
            }
        }

        protected void GridViewCursosAsignados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewCursosAsignados.PageIndex = e.NewPageIndex;
            CargarCursosAsignados();
        }

    }
}