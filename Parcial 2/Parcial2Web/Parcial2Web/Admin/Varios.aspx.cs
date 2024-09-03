using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Web.Admin
{
    public partial class Varios : System.Web.UI.Page
    {
        DB.DataClasses1DataContext LINQ = new DB.DataClasses1DataContext(Conexion.CADENA);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCiclos();
                CargarCursos();
            }
        }
        public void CargarCiclos()
        {
            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var ciclos = from ci in context.Ciclo
                             select ci;

                GridViewCiclos.DataSource = ciclos.ToList();
                GridViewCiclos.DataBind();
            }
        }

        public void CargarCursos()
        {
            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var curso = from ci in context.Curso
                             select ci;

                GridViewCursos.DataSource = curso;
                GridViewCursos.DataBind();
            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (TextBoxCodCurso.Text != "" && TextBoxNomCurso.Text != "")
            {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    // Verificar si el codigo_curso ya existe en la base de datos
                    var cursoExistente = context.Curso
                                               .FirstOrDefault(c => c.codigo_curso == TextBoxCodCurso.Text);

                    if (cursoExistente == null) // Si no existe, se puede insertar el nuevo curso
                    {
                        DB.Curso curso = new DB.Curso
                        {
                            codigo_curso = TextBoxCodCurso.Text,
                            nombre_curso = TextBoxNomCurso.Text
                        };

                        context.Curso.InsertOnSubmit(curso);
                        context.SubmitChanges();

                        // Limpiar los campos de texto
                        TextBoxCodCurso.Text = "";
                        TextBoxNomCurso.Text = "";

                        // Mostrar mensaje de éxito
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageCursoG", "showMessageCursoG();", true);
                    }
                    else
                    {
                        // Mostrar mensaje de error si el curso ya existe
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageErrorCursoExistente", "showMessageErrorCursoExistente();", true);
                    }
                }

                // Recargar la lista de cursos
                CargarCursos();
            }
            else
            {
                // Mostrar mensaje de error si los campos están vacíos
                ClientScript.RegisterStartupScript(this.GetType(), "showMessageError", "showMessageError();", true);
            }

        }

        protected void ButtonCicloGuardar_Click(object sender, EventArgs e)
        {
            if (TextBoxCiclo.Text != "")
            {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    // Verificar si el codigo_curso ya existe en la base de datos
                    var CicloExistente = context.Ciclo
                                               .FirstOrDefault(c => c.nombre_ciclo == TextBoxCiclo.Text);

                    if (CicloExistente == null) // Si no existe, se puede insertar el nuevo curso
                    {
                        DB.Ciclo curso = new DB.Ciclo
                        {
                            nombre_ciclo = TextBoxCiclo.Text,
                            estado_ciclo = RadioButtonEstadoCi.Checked
                        };

                        context.Ciclo.InsertOnSubmit(curso);
                        context.SubmitChanges();

                        // Limpiar los campos de texto
                        TextBoxCiclo.Text = "";

                        // Mostrar mensaje de éxito
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageCicloG", "showMessageCicloG();", true);
                    }
                    else
                    {
                        // Mostrar mensaje de error si el curso ya existe
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageErrorCursoExistente", "showMessageErrorCursoExistente();", true);
                    }
                }

                // Recargar la lista de cursos
                CargarCiclos();
            }
            else
            {
                // Mostrar mensaje de error si los campos están vacíos
                ClientScript.RegisterStartupScript(this.GetType(), "showMessageError", "showMessageError();", true);
            }
        }

        protected void GridViewCursos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewCursos.EditIndex = e.NewEditIndex;
            CargarCursos();
        }

        protected void GridViewCursos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewCursos.EditIndex = -1; 
            CargarCursos();
        }

        protected void GridViewCursos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string codigoCurso = GridViewCursos.DataKeys[e.RowIndex].Value.ToString();

            // Encuentra el TextBox que contiene el nombre del curso
            TextBox txtNombreCurso = (TextBox)GridViewCursos.Rows[e.RowIndex].FindControl("TextBoxNombreCurso");

            if (txtNombreCurso != null)
            {
                string nombreCurso = txtNombreCurso.Text;

                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    var curso = context.Curso.FirstOrDefault(c => c.codigo_curso == codigoCurso);
                    if (curso != null)
                    {
                        curso.nombre_curso = nombreCurso;
                        context.SubmitChanges();
                    }
                }

                GridViewCursos.EditIndex = -1; // Sale del modo de edición
                CargarCursos(); // Recargar los datos actualizados
            }
        }

        protected void GridViewCursos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewCursos.PageIndex = e.NewPageIndex;
            CargarCursos();
        }

        protected void GridViewCiclos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewCiclos.PageIndex = e.NewPageIndex;
            CargarCiclos();
        }

        protected void GridViewCiclos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewCiclos.EditIndex = e.NewEditIndex;
            CargarCiclos();
        }

        protected void GridViewCiclos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            int cicloId = Convert.ToInt32(GridViewCiclos.DataKeys[e.RowIndex].Value);

            // Encuentra los controles en la fila que se está actualizando
            TextBox txtNombreCiclo = (TextBox)GridViewCiclos.Rows[e.RowIndex].FindControl("TextBoxNombreCiclo");
            RadioButton rbActivo = (RadioButton)GridViewCiclos.Rows[e.RowIndex].FindControl("RadioButtonEstadoActivo");
            RadioButton rbInactivo = (RadioButton)GridViewCiclos.Rows[e.RowIndex].FindControl("RadioButtonEstadoInactivo");

            if (txtNombreCiclo != null && (rbActivo != null || rbInactivo != null))
            {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    var ciclo = context.Ciclo.FirstOrDefault(ci => ci.codigo_ciclo == cicloId);
                    if (ciclo != null)
                    {
                        ciclo.nombre_ciclo = txtNombreCiclo.Text;
                        ciclo.estado_ciclo = rbActivo.Checked; // Asigna el valor basado en el RadioButton
                        context.SubmitChanges();
                    }
                }

                GridViewCiclos.EditIndex = -1; // Sal del modo de edición
                CargarCiclos(); // Recarga los datos actualizados
            }
        }

        protected void GridViewCiclos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewCiclos.EditIndex = -1; // Cancela la edición
            CargarCiclos();
        }
    }
}