using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2Web.Admin
{
    public partial class Alumnos : System.Web.UI.Page
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
                DropDownListDepa.SelectedIndex = -1;
                ///
                CargarAlumnos();
            }
        }

        public void CargarAlumnos()
        {
            var Alumnos = from alum in LINQ.VistaAlumno
                          select alum;
            GridViewAlumnos.DataSource = Alumnos;
            GridViewAlumnos.DataBind();
        }

        protected void GridViewAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewAlumnos.PageIndex = e.NewPageIndex;
            CargarAlumnos();
        }

        protected void TextBoxBuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            string filtro = TextBoxBuscarAlumno.Text;
            using (var milinq = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                var clientes = from cliente in LINQ.VistaAlumno
                               where cliente.Codigo.ToLower().Contains(filtro.ToLower()) ||
                                     cliente.Nombres.ToLower().Contains(filtro.ToLower()) ||
                                     cliente.Apellidos.ToLower().Contains(filtro.ToLower())
                               select cliente;

                GridViewAlumnos.DataSource = clientes.ToList();
                GridViewAlumnos.DataBind();
            }
        }

        protected void GridViewAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridViewAlumnos.SelectedIndex;

            // Obtener el código del alumno desde la clave primaria de la fila seleccionada
            string codigoAlumno = GridViewAlumnos.DataKeys[selectedIndex].Value.ToString();

            using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
            {
                // Buscar el alumno en la base de datos usando el código
                var alumno = context.VistaAlumno.FirstOrDefault(a => a.Codigo == codigoAlumno);

                if (alumno != null)
                {
                    // Cargar los datos del alumno en los controles correspondientes
                    TextBoxCodAlumno.Text = alumno.Codigo;
                    TextBoxNomAlum.Text = alumno.Nombres;
                    TextBoxApeAlum.Text = alumno.Apellidos;
                    TextBoxFechaNac.Text = alumno.Fecha_Nacimiento.ToString("yyyy-MM-dd");
                    TextBoxDireccion.Text = alumno.Direccion;
                    TextBoxCorreo.Text = alumno.Correo;
                    TextBoxTelefono.Text = alumno.Telefono;
                    TextBoxUsuario.Text = alumno.Usuario;
                    TextBoxPass.Text = alumno.Contraseña;
                    DropDownListDepa.SelectedIndex = Convert.ToInt16(alumno.Codigo_Departamento);
                    DropDownListMuni.SelectedIndex = Convert.ToInt16(alumno.Codigo_Municipio);
                    
                }
            }
        }

        public void Limpiar()
        {
            TextBoxCodAlumno.Text = "";
            TextBoxNomAlum.Text = "";
            TextBoxApeAlum.Text = "";
            TextBoxFechaNac.Text = "";
            TextBoxTelefono.Text = "";
            TextBoxPass.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxUsuario.Text = "";
            TextBoxCorreo.Text = "";
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (TextBoxCodAlumno.Text != "" && TextBoxNomAlum.Text != "" && TextBoxApeAlum.Text != ""
                && TextBoxFechaNac.Text != "" && TextBoxTelefono.Text != "" && TextBoxPass.Text != ""
                && TextBoxDireccion.Text != "" && TextBoxUsuario.Text != ""  && DropDownListMuni.Text != "" && DropDownListDepa.Text != "")
            {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    // Verificar si el codigo_curso ya existe en la base de datos
                    var CodigoExistente = context.Alumno
                                               .FirstOrDefault(c => c.codigo_alumno == TextBoxCodAlumno.Text);

                    if (CodigoExistente == null) // Si no existe, se puede insertar el nuevo 
                    {
                        DB.Alumno alum = new DB.Alumno
                        {
                            codigo_alumno = TextBoxCodAlumno.Text,
                            nombres = TextBoxNomAlum.Text,
                            apellidos = TextBoxApeAlum.Text,
                            fecha_nac = Convert.ToDateTime(TextBoxFechaNac.Text),
                            direccion = TextBoxDireccion.Text,
                            correo = TextBoxCorreo.Text,
                            telefono = TextBoxTelefono.Text,
                            usuario_alumno = TextBoxUsuario.Text,
                            contrasenia = TextBoxPass.Text,
                            cod_municipio = DropDownListMuni.SelectedValue
                        };

                        context.Alumno.InsertOnSubmit(alum);
                        context.SubmitChanges();

                        // Limpiar los campos de texto
                        Limpiar();
                        CargarAlumnos();

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
            if (TextBoxCodAlumno.Text != "" && TextBoxNomAlum.Text != "" && TextBoxApeAlum.Text != ""
                && TextBoxFechaNac.Text != "" && TextBoxTelefono.Text != "" && TextBoxPass.Text != ""
                && TextBoxDireccion.Text != "" && TextBoxUsuario.Text != "")
            {
                using (var context = new DB.DataClasses1DataContext(Conexion.CADENA))
                {
                    // Buscar el alumno existente por su código
                    var alumnoExistente = context.Alumno
                                                 .FirstOrDefault(a => a.codigo_alumno == TextBoxCodAlumno.Text);

                    if (alumnoExistente != null) // Si existe, actualizar los datos
                    {
                        // Actualizar los campos con los nuevos valores
                        alumnoExistente.nombres = TextBoxNomAlum.Text;
                        alumnoExistente.apellidos = TextBoxApeAlum.Text;
                        alumnoExistente.fecha_nac = Convert.ToDateTime(TextBoxFechaNac.Text);
                        alumnoExistente.direccion = TextBoxDireccion.Text;
                        alumnoExistente.correo = TextBoxCorreo.Text;
                        alumnoExistente.telefono = TextBoxTelefono.Text;
                        alumnoExistente.usuario_alumno = TextBoxUsuario.Text;
                        alumnoExistente.contrasenia = TextBoxPass.Text;
                        alumnoExistente.cod_municipio = DropDownListMuni.SelectedValue;

                        // Guardar los cambios en la base de datos
                        context.SubmitChanges();

                        // Limpiar los campos de texto
                        Limpiar();
                        CargarAlumnos();

                        // Mostrar mensaje de éxito
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageCursoEditado", "showMessageCursoEditado();", true);
                    }
                    else
                    {
                        // Mostrar mensaje de error si el alumno no existe (opcional)
                        ClientScript.RegisterStartupScript(this.GetType(), "showMessageErrorAlumnoNoExistente", "showMessageErrorAlumnoNoExistente();", true);
                    }
                }
            }

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
    }
}