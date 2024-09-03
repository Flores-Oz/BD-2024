using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Web.Admin
{
    public partial class Profesores : System.Web.UI.Page
    {
        DB.DataClasses1DataContext LINQ = new DB.DataClasses1DataContext(Conexion.CADENA);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Departamentos = from dep in LINQ.Departamento
                                    select dep;
                DropDownListDepa.DataSource = Departamentos;
                DropDownListDepa.DataTextField = "nombre_depto";
                DropDownListDepa.DataValueField = "cod_depto";
                DropDownListDepa.DataBind();
                ///
                var Curso = from dep in LINQ.Curso
                                    select dep;
                DropDownListCurso.DataSource = Curso;
                DropDownListCurso.DataTextField = "nombre_curso";
                DropDownListCurso.DataValueField = "codigo_curso";
                DropDownListCurso.DataBind();
                ///
                var Ciclo = from dep in LINQ.Ciclo
                            where dep.estado_ciclo == true
                            select dep;
                DropDownListCiclo.DataSource = Ciclo;
                DropDownListCiclo.DataTextField = "nombre_ciclo";
                DropDownListCiclo.DataValueField = "codigo_ciclo";
                DropDownListCiclo.DataBind();
                ///
                var Profes = from dep in LINQ.Profesor
                             where dep.estado_profesor == true
                            select new {
                                Codigo = dep.dpi_profesor,
                                Nombre = dep.nombres_profesor+" "+dep.apellidos_profesor
                            };
                DropDownListDPI.DataSource = Profes;
                DropDownListDPI.DataTextField = "Nombre";
                DropDownListDPI.DataValueField = "Codigo";
                DropDownListDPI.DataBind();
                CargarProfesores();
                CargarAsignProfe();
            }
        }

        public void Limpiar()
        {
            TextBoxDPI.Text = "";
            TextBoxNomProf.Text = "";
            TextBoxApeProf.Text = "";
            CheckBoxEstado.Checked = false;
            TextBoxTelefono.Text = "";
            TextBoxPass.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxUsuario.Text = "";
        }

        public void CargarProfesores()
        {
            var profes = from prof in LINQ.VistaProfesores
                          select prof;
            GridViewProfesores.DataSource = profes;
            GridViewProfesores.DataBind();
        }

        public void CargarAsignProfe()
        {
            var profes = from prof in LINQ.VistaAsignaProfe
                         select prof;
            GridView1.DataSource = profes;
            GridView1.DataBind();
        }

        protected void DropDownListDepa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codDepa = Convert.ToInt32(DropDownListDepa.SelectedValue);

            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                // Consulta LINQ para obtener los municipios
                var municipios = from m in context.Municipio
                                 where m.cod_depto == codDepa
                                 select new
                                 {
                                     Codigo = m.cod_municipio,
                                     Municipio = m.nombre_municipio
                                 };

                // Convertir el resultado a una lista y enlazarla al comboBox
                DropDownListMuni.DataSource = municipios.ToList();
                DropDownListMuni.DataTextField = "Municipio";
                DropDownListMuni.DataValueField = "Codigo";
                DropDownListMuni.DataBind();
            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (TextBoxDPI.Text != "" && TextBoxNomProf.Text != "" && TextBoxApeProf.Text != ""
              && TextBoxTelefono.Text != "" && TextBoxPass.Text != ""
              && TextBoxDireccion.Text != "" && TextBoxUsuario.Text != "" && DropDownListMuni.Text != "" && DropDownListDepa.Text != "")
            {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    // Verificar si el codigo_curso ya existe en la base de datos
                    var CodigoExistente = context.Profesor
                                               .FirstOrDefault(c => c.dpi_profesor == TextBoxDPI.Text);

                    if (CodigoExistente == null) // Si no existe, se puede insertar el nuevo 
                    {
                        DB.Profesor prof = new DB.Profesor
                        {
                            dpi_profesor = TextBoxDPI.Text,
                            nombres_profesor = TextBoxNomProf.Text,
                            apellidos_profesor = TextBoxApeProf.Text,
                            estado_profesor = CheckBoxEstado.Checked,
                            direccion_profesor = TextBoxDireccion.Text,
                            telefono_profesor = TextBoxTelefono.Text,
                            usuario_profesor = TextBoxUsuario.Text,
                            contrasenia = TextBoxPass.Text,
                            cod_municipio = DropDownListMuni.SelectedValue
                        };

                        context.Profesor.InsertOnSubmit(prof);
                        context.SubmitChanges();

                        // Limpiar los campos de texto
                        Limpiar();
                        CargarProfesores();

                        // Mostrar mensaje de éxito
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageCursoG", "showMessageCursoG();", true);
                    }
                    else
                    {
                        // Mostrar mensaje de error si el Alumno ya existe
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageErrorCursoExistente", "showMessageErrorCursoExistente();", true);
                    }
                }
            }
            else
            {
                // Mostrar mensaje de error si los campos están vacíos
                ClientScript.RegisterStartupScript(this.GetType(), "showMessageError", "showMessageError();", true);
            }
        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (TextBoxDPI.Text != "" && TextBoxNomProf.Text != "" && TextBoxApeProf.Text != ""
                && TextBoxTelefono.Text != "" && TextBoxPass.Text != ""
                && TextBoxDireccion.Text != "" && TextBoxUsuario.Text != ""
                && DropDownListMuni.Text != "" && DropDownListDepa.Text != "")
            {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    // Verificar si el profesor ya existe en la base de datos
                    var profesorExistente = context.Profesor
                                                   .FirstOrDefault(c => c.dpi_profesor == TextBoxDPI.Text);

                    if (profesorExistente != null) // Si existe, actualizamos el registro
                    {
                        profesorExistente.nombres_profesor = TextBoxNomProf.Text;
                        profesorExistente.apellidos_profesor = TextBoxApeProf.Text;
                        profesorExistente.estado_profesor = CheckBoxEstado.Checked;
                        profesorExistente.direccion_profesor = TextBoxDireccion.Text;
                        profesorExistente.telefono_profesor = TextBoxTelefono.Text;
                        profesorExistente.usuario_profesor = TextBoxUsuario.Text;
                        profesorExistente.contrasenia = TextBoxPass.Text;
                        profesorExistente.cod_municipio = DropDownListMuni.SelectedValue;

                        context.SubmitChanges();

                        // Mostrar mensaje de éxito en la edición
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageCursoEditado", "showMessageCursoEditado();", true);

                        // Limpiar los campos de texto y recargar los datos
                        Limpiar();
                        CargarProfesores();
                    }
                    else
                    {
                        // Mostrar mensaje de error si el profesor no existe
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageErrorAlumnoNoExistente", "showMessageErrorAlumnoNoExistente();", true);
                    }
                }
            }
            else
            {
                // Mostrar mensaje de error si los campos están vacíos
                ClientScript.RegisterStartupScript(this.GetType(), "showMessageError", "showMessageError();", true);
            }

        }

        protected void TextBoxBuscarProfesor_TextChanged(object sender, EventArgs e)
        {
            string filtro = TextBoxBuscarProfesor.Text;
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var profes = from cliente in LINQ.VistaProfesores
                               where cliente.DPI.ToLower().Contains(filtro.ToLower()) ||
                                     cliente.Nombres.ToLower().Contains(filtro.ToLower()) ||
                                     cliente.Apellidos.ToLower().Contains(filtro.ToLower())
                               select cliente;

                GridViewProfesores.DataSource = profes.ToList();
                GridViewProfesores.DataBind();
            }
        }

        protected void GridViewProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridViewProfesores.SelectedIndex;

            // Obtener el DPI del profesor desde la clave primaria de la fila seleccionada
            string dpiProfesor = GridViewProfesores.DataKeys[selectedIndex].Value.ToString();

            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                // Buscar el profesor en la base de datos usando el DPI
                var profesor = context.Profesor.FirstOrDefault(p => p.dpi_profesor == dpiProfesor);

                if (profesor != null)
                {
                    // Cargar los datos del profesor en los controles correspondientes
                    TextBoxDPI.Text = profesor.dpi_profesor;
                    TextBoxNomProf.Text = profesor.nombres_profesor;
                    TextBoxApeProf.Text = profesor.apellidos_profesor;
                    TextBoxDireccion.Text = profesor.direccion_profesor;
                    TextBoxTelefono.Text = profesor.telefono_profesor;
                    TextBoxUsuario.Text = profesor.usuario_profesor;
                    TextBoxPass.Text = profesor.contrasenia;
                    CheckBoxEstado.Checked = profesor.estado_profesor;

                    // Seleccionar el valor correcto en los DropDownLists
                    DropDownListMuni.SelectedValue = profesor.cod_municipio.ToString();
                }
            }

        }

        protected void GridViewProfesores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewProfesores.PageIndex = e.NewPageIndex;
            CargarProfesores();
        }

        protected void ButtonAsignaProf_Click(object sender, EventArgs e)
        {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    // Verificar si el codigo_curso ya existe en la base de datos
                    var Curso = context.Profesor_Curso
                                               .FirstOrDefault(c => c.codigo_curso == DropDownListCurso.SelectedValue && c.dpi_profesor == DropDownListDPI.SelectedValue);

                    if (Curso == null) // Si no existe, se puede insertar el nuevo 
                    {
                        DB.Profesor_Curso prof = new DB.Profesor_Curso
                        {
                            fecha_asignacion = Convert.ToDateTime(TextBoxFechaAsign.Text),
                            codigo_ciclo = Convert.ToInt16(DropDownListCiclo.SelectedValue),
                            dpi_profesor = DropDownListDPI.SelectedValue,
                            codigo_curso = DropDownListCurso.SelectedValue
                        };

                        context.Profesor_Curso.InsertOnSubmit(prof);
                        context.SubmitChanges();

                        // Limpiar los campos de texto
                        CargarAsignProfe();

                        // Mostrar mensaje de éxito
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageProfAsign", "showMessageProfAsign();", true);
                    }
                    else
                    {
                        // Mostrar mensaje de error si el Alumno ya existe
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageErrorCursoExistente", "showMessageErrorCursoExistente();", true);
                    }
                }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = TextBox1.Text;
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var profes = from cliente in LINQ.VistaAsignaProfe
                             where cliente.Profesor.ToLower().Contains(filtro.ToLower()) ||
                                   cliente.nombre_curso.ToLower().Contains(filtro.ToLower()) ||
                                   cliente.nombre_ciclo.ToLower().Contains(filtro.ToLower())
                             select cliente;

                GridView1.DataSource = profes.ToList();
                GridView1.DataBind();
            }
        }
    }
}