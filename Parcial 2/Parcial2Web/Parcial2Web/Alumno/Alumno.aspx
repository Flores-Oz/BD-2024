<%@ Page Title="" Language="C#" MasterPageFile="~/MasterWebs/SiteAlumno.Master" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="Parcial2Web.Alumno.Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .color1 {
            background: #0F2027; /* fallback for old browsers */
            background: -webkit-linear-gradient(to right, #2C5364, #203A43, #0F2027); /* Chrome 10-25, Safari 5.1-6 */
            background: linear-gradient(to right, #2C5364, #203A43, #0F2027); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        }

        .btn-color {
            background-color: #0e1c36;
            color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="px-4  my-5 text-center">
        <h1 class="display-5 fw-bold text-body-emphasis">Alumno</h1>
        <p class="display-5  text-body-emphasis">Espacio para que puedas Asignarte tus Cursos</p>
    </div>
    <!--Ingreso-->
    <div class="container col-xl-10 col-xxl-8 px-4">
        <div class="row align-items-center g-lg-5 py-1">
            <div class="col-lg-12 text-center text-lg-start">
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6">Cursos Disponibles</h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3 col-md-12 mx-auto color1">
            <div class="row">
              <div class="col">
                     <asp:TextBox ID="TextBox2" placeholder="Buscar Asignacion por Profesor/Ciclo/Curso" OnTextChanged="TextBox2_TextChanged" AutoPostBack="true" CssClass="form-control" runat="server"></asp:TextBox>
                     <asp:GridView ID="GridViewCursosDisponibles" runat="server" CssClass="table table-striped table-bordered table-responsive"
                            DataKeyNames="Codigo" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridViewCursosDisponibles_SelectedIndexChanged"
                            AllowPaging="True" PageSize="3" OnPageIndexChanging="GridViewCursosDisponibles_PageIndexChanging">
                            <HeaderStyle CssClass="table-dark" />
                            <RowStyle CssClass="align-middle" />
                            <AlternatingRowStyle CssClass="table-light" />
                        </asp:GridView>
              </div>
            </div>
        </div>
    </div>
    <br />
    <!--Asignacion de Profesores-->
    <div class="container col-xl-10 col-xxl-8 px-4">
        <div class="row align-items-center g-lg-5 py-1">
            <div class="col-lg-12 text-center text-lg-start">
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6">Cursos Asignados</h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3 col-md-12 mx-auto color1">
    <div class="row">
        <div class="col-12">
            <asp:TextBox ID="TextBox3" placeholder="Buscar Asignacion por el Resultado" OnTextChanged="TextBox3_TextChanged" AutoPostBack="true" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-12 mt-3 " style="overflow-x: auto;">
            <asp:GridView ID="GridViewCursosAsignados" runat="server" CssClass="table table-striped table-bordered table-responsive"
                DataKeyNames="codigo_asignacion"
                AllowPaging="True" PageSize="5" OnPageIndexChanging="GridViewCursosAsignados_PageIndexChanging">
                <HeaderStyle CssClass="table-dark" />
                <RowStyle CssClass="align-middle" />
                <AlternatingRowStyle CssClass="table-light" />
            </asp:GridView>
        </div>
    </div>
</div>

    </div>
    <br />
    <!--Modales-->
    <div id="messageBoxCicloG" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Curso Asignado Correctamente
    </div>
    <div id="messageBoxError" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        El alumno ya está asignado a este curso.
    </div>
    <!--Scripts-->
     <script type="text/javascript">
         function showMessageProfAsign() {
             var messageBox = document.getElementById("messageBoxCicloG");
             messageBox.style.display = "block";
             setTimeout(function () {
                 messageBox.style.display = "none";
             }, 3000); // Ocultar el mensaje después de 3 segundos
         }
     </script>
    <script type="text/javascript">
        function showMessageCursoG() {
            var messageBox = document.getElementById("messageBoxError");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
</asp:Content>
