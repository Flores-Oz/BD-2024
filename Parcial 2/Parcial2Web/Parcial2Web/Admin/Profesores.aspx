﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterWebs/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="Parcial2Web.Admin.Profesores" %>

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
        <h1 class="display-5 fw-bold text-body-emphasis">Profesores</h1>
        <p class="display-5  text-body-emphasis">Modulo para el Manjeo de Profesores</p>
    </div>
    <!--Ingreso-->
    <div class="container col-xl-10 col-xxl-8 px-4">
        <div class="row align-items-center g-lg-5 py-1">
            <div class="col-lg-12 text-center text-lg-start">
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6">Ingreso de Profesores</h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3 col-md-12 mx-auto color1">
            <div class="row">
                <!-- Izquierda: Grupos de botones o inputs -->
                <div class="col-md-6">
                    <div class="mb-3">
                        <asp:HyperLink ID="HyperLink1" CssClass="fs-3 fw-bolder text-white" data-bs-toggle="modal" data-bs-target="#staticBackdrop" runat="server">DPI Profesor</asp:HyperLink>
                        <asp:TextBox ID="TextBoxDPI" placeholder="DPI" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <asp:Label ID="Label3" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Apellidos del Profesor"></asp:Label>
                        <asp:TextBox ID="TextBoxApeProf" placeholder="Apellidos del Profesor" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label10" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Estado del Profesor"></asp:Label>>
                        <asp:CheckBox ID="CheckBoxEstado" CssClass="form-control" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label11" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Telefono"></asp:Label>
                        <asp:TextBox ID="TextBoxTelefono" placeholder="00000000" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label12" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox ID="TextBoxPass" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                </div>

                <!-- Derecha: Campos adicionales -->
                <div class="col-md-6">
                    <div class="mb-3">
                        <asp:Label ID="Label2" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Nombres del Profesor"></asp:Label>
                        <asp:TextBox ID="TextBoxNomProf" placeholder="Nombres del Profesor" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label4" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Direccion"></asp:Label>
                        <asp:TextBox ID="TextBoxDireccion" placeholder="# Av. Zona #" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label6" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Usuario"></asp:Label>
                        <asp:TextBox ID="TextBoxUsuario" placeholder="User" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label7" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Departamento"></asp:Label>
                        <asp:DropDownList ID="DropDownListDepa" OnSelectedIndexChanged="DropDownListDepa_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label8" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Municipio"></asp:Label>
                        <asp:DropDownList ID="DropDownListMuni" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <!---->
                <div class="col">
                    <div class="d-grid gap-2">
                        <asp:Button ID="ButtonGuardar" OnClick="ButtonGuardar_Click" CssClass="btn btn-color " runat="server" Text="Ingresar Profesor" />
                        <asp:Button ID="ButtonEditar" OnClick="ButtonEditar_Click" CssClass="btn btn-color" runat="server" Text="Modificar Profesor" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <!--Asignacion de Profesores-->
    <div class="container col-xl-10 col-xxl-8 px-4">
        <div class="row align-items-center g-lg-5 py-1">
            <div class="col-lg-12 text-center text-lg-start">
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6"><asp:HyperLink ID="HyperLink2" data-bs-toggle="modal" data-bs-target="#staticBackdrop1" runat="server">Asignacion Profesores</asp:HyperLink></h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3 col-md-12 mx-auto color1">
            <div class="row">
                <!-- Izquierda: Grupos de botones o inputs -->
                <div class="col-md-6">
                    <div class="mb-3">
                        <asp:Label ID="Label1" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Fecha Asignacion"></asp:Label>
                        <asp:TextBox ID="TextBoxFechaAsign" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label5" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Profesor"></asp:Label>
                        <asp:DropDownList ID="DropDownListDPI"  CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>

                <!-- Derecha: Campos adicionales -->
                <div class="col-md-6">
                    <div class="mb-3">
                        <asp:Label ID="Label14" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Ciclo"></asp:Label>
                        <asp:DropDownList ID="DropDownListCiclo"  CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label15" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Curso"></asp:Label>
                        <asp:DropDownList ID="DropDownListCurso"  CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <!---->
                <div class="col">
                    <div class="d-grid gap-2">
                        <asp:Button ID="ButtonAsignaProf" OnClick="ButtonAsignaProf_Click" CssClass="btn btn-color " runat="server" Text="Asignar Profesor" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <!--MODAL-->
    <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
        <div class="modal-dialog modal-xl">
            <div class="modal-content color1">
                <div class="modal-header">
                    <h1 class="modal-title fs-5 text-white" id="staticBackdropLabel">Profesores</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <!---->
                    <div class="d-flex justify-content-center align-items-center">
                        <asp:TextBox ID="TextBoxBuscarProfesor" placeholder="Buscar Profesor por Nombre/Apellido/DPI" OnTextChanged="TextBoxBuscarProfesor_TextChanged" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div style="overflow-x: auto;">
                        <asp:GridView ID="GridViewProfesores" runat="server" CssClass="table table-striped table-bordered table-responsive"
                            DataKeyNames="DPI" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridViewProfesores_SelectedIndexChanged"
                            AllowPaging="True" PageSize="3" OnPageIndexChanging="GridViewProfesores_PageIndexChanging">
                            <HeaderStyle CssClass="table-dark" />
                            <RowStyle CssClass="align-middle" />
                            <AlternatingRowStyle CssClass="table-light" />
                        </asp:GridView>
                    </div>
                    <!---->
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <!---->
        <div class="modal fade" id="staticBackdrop1" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
        <div class="modal-dialog modal-xl">
            <div class="modal-content color1">
                <div class="modal-header">
                    <h1 class="modal-title fs-5 text-white" id="staticBackdropLabel1">Profesores Asignados</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <!---->
                    <div class="d-flex justify-content-center align-items-center">
                        <asp:TextBox ID="TextBox1" placeholder="Buscar Asignacion por Profesor/Ciclo/Curso" OnTextChanged="TextBox1_TextChanged" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div style="overflow-x: auto;">
                        <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-responsive"
                            DataKeyNames="codigo_prof_curso" AutoGenerateSelectButton="true"
                            AllowPaging="True" PageSize="3" OnPageIndexChanging="GridView1_PageIndexChanging">
                            <HeaderStyle CssClass="table-dark" />
                            <RowStyle CssClass="align-middle" />
                            <AlternatingRowStyle CssClass="table-light" />
                        </asp:GridView>
                    </div>
                    <!---->
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <!--Modales-->
    <div id="messageBoxCicloG" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Profesor Ingresado Correctamente
    </div>
    <div id="messageBoxError" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Error: Campos Vacios
    </div>
    <div id="messageBoxErrorC" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Error: Campos Repetidos
    </div>
    <div id="messageBoxEditarAlum" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Profesor Modificado Correctamente
    </div>
    <div id="messageBoxAlumNoExistente" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Profesor No Existente
    </div>
      <div id="messageBoxProfeAsign" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Profesor Asignado Correctamente
    </div>
    <!--Scripts-->
     <script type="text/javascript">
         function showMessageProfAsign() {
             var messageBox = document.getElementById("messageBoxProfeAsign");
             messageBox.style.display = "block";
             setTimeout(function () {
                 messageBox.style.display = "none";
             }, 3000); // Ocultar el mensaje después de 3 segundos
         }
     </script>
    <script type="text/javascript">
        function showMessageCursoG() {
            var messageBox = document.getElementById("messageBoxCicloG");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
    <script type="text/javascript">
        function showMessageError() {
            var messageBox = document.getElementById("messageBoxError");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
    <script type="text/javascript">
        function showMessageErrorCursoExistente() {
            var messageBox = document.getElementById("messageBoxErrorC");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
    <script type="text/javascript">
        function showMessageCursoEditado() {
            var messageBox = document.getElementById("messageBoxEditarAlum");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
    <script type="text/javascript">
        function showMessageErrorAlumnoNoExistente() {
            var messageBox = document.getElementById("messageBoxAlumNoExistente");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
</asp:Content>
