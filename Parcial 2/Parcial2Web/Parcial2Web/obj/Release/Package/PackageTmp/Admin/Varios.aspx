<%@ Page Title="" Language="C#" MasterPageFile="~/MasterWebs/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Varios.aspx.cs" Inherits="Parcial2Web.Admin.Varios" %>

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
    <div class=" my-5 text-center">
        <h1 class="display-5 fw-bold text-body-emphasis">Varios</h1>
        <div class="col-lg-6 mx-auto">
            <p class="lead mb-4">
                Otros Ingresos Posibles
            </p>
        </div>
    </div>
    <!---->
    <div class="container col-xl-10 col-xxl-8 px-4 ">
        <div class="row align-items-center g-lg-5 py-1">
            <div class="col-lg-12 text-center text-lg-start">
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6">Ingreso de Cursos</h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3  col-md-12 mx-auto color1">
            <div class="row">
                <!-- Izquierda: Grupos de botones o inputs -->
                <div class="col-md-4 ">
                    <div class="mb-3">
                        <asp:Label ID="Label1" CssClass="fs-3 fw-bolder bg-secundary" runat="server" Text="Codigo del Curso"></asp:Label>
                        <asp:TextBox ID="TextBoxCodCurso" placeholder="Codigo del Curso" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label2" runat="server" CssClass="fs-3 fw-bolder bg-secundary" Text="Nombre del Curso"></asp:Label>
                        <asp:TextBox ID="TextBoxNomCurso" placeholder="Nombre del Curso" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Button ID="ButtonGuardar" OnClick="ButtonGuardar_Click" CssClass="btn btn-color px-5 mb-5 w-100" runat="server" Text="Ingresar" />
                    </div>
                </div>

                <!-- Derecha: Bloque grande -->
                <div class="col-md-8">
                    <div class="p-5 rounded-3">
                        <asp:GridView ID="GridViewCursos" runat="server" CssClass="table table-striped table-bordered table-responsive"
                            AutoGenerateColumns="False" DataKeyNames="codigo_curso" OnRowEditing="GridViewCursos_RowEditing"
                            OnRowUpdating="GridViewCursos_RowUpdating" OnRowCancelingEdit="GridViewCursos_RowCancelingEdit"
                            AllowPaging="True" PageSize="3" OnPageIndexChanging="GridViewCursos_PageIndexChanging">

                            <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:BoundField DataField="codigo_curso" HeaderText="Código Curso" ReadOnly="True" SortExpression="codigo_curso" />
                                <asp:TemplateField HeaderText="Nombre Curso">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelNombreCurso" runat="server" Text='<%# Eval("nombre_curso") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBoxNombreCurso" runat="server" Text='<%# Bind("nombre_curso") %>' CssClass="form-control"></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                            <HeaderStyle CssClass="table-dark" />
                            <RowStyle CssClass="align-middle" />
                            <AlternatingRowStyle CssClass="table-light" />
                        </asp:GridView>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <!---->
    <!---->
    <div class="container col-xl-10 col-xxl-8 px-4 ">
        <div class="row align-items-center g-lg-5 py-1">
            <div class="col-lg-12 text-center text-lg-start">
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6">Ingreso de Ciclos</h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3  col-md-12 mx-auto color1">
            <div class="row">
                <!-- Izquierda: Grupos de botones o inputs -->
                <div class="col-md-4 ">
                    <div class="mb-3">
                        <asp:Label ID="Label3" CssClass="fs-3 fw-bolder bg-secundary" runat="server" Text="Ciclo"></asp:Label>
                        <asp:TextBox ID="TextBoxCiclo" placeholder="Ciclo" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label4" runat="server" CssClass="fs-3 fw-bolder bg-secundary" Text="Estado del Ciclo"></asp:Label>
                        <asp:RadioButton ID="RadioButtonEstadoCi" CssClass="form-control" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Button ID="ButtonCicloGuardar" OnClick="ButtonCicloGuardar_Click" CssClass="btn btn-color px-5 mb-5 w-100" runat="server" Text="Ingresar" />
                    </div>
                </div>

                <!-- Derecha: Bloque grande -->
                <div class="col-md-8">
                    <div class="p-5 rounded-3">
                        <!-- Contenido del bloque grande -->
                        <asp:GridView ID="GridViewCiclos" runat="server" CssClass="table table-striped table-bordered table-responsive"
                            AutoGenerateColumns="False" DataKeyNames="codigo_ciclo" AllowPaging="True" PageSize="3"
                            OnPageIndexChanging="GridViewCiclos_PageIndexChanging" OnRowEditing="GridViewCiclos_RowEditing"
                            OnRowUpdating="GridViewCiclos_RowUpdating" OnRowCancelingEdit="GridViewCiclos_RowCancelingEdit">
                            <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:BoundField DataField="codigo_ciclo" HeaderText="codigo_ciclo" ReadOnly="True" SortExpression="ciclo_id" />
                                <asp:TemplateField HeaderText="Ciclo">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelNombreCiclo" runat="server" Text='<%# Eval("nombre_ciclo") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBoxNombreCiclo" runat="server" Text='<%# Bind("nombre_ciclo") %>' CssClass="form-control"></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Estado">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelEstadoCiclo" runat="server" Text='<%# Eval("estado_ciclo") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="CheckBoxEstadoCiclo" runat="server"
                                            Checked='<%# Eval("estado_ciclo").ToString().ToLower() == "activo" %>'
                                            CssClass="form-check-input" />
                                    </EditItemTemplate>
                                </asp:TemplateField>

                            </Columns>

                            <HeaderStyle CssClass="table-dark" />
                            <RowStyle CssClass="align-middle" />
                            <AlternatingRowStyle CssClass="table-light" />
                        </asp:GridView>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <!---->
    <!--Modales-->
    <div id="messageBoxCicloG" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Ciclo Ingresado Correctamente
    </div>
    <div id="messageBoxCursoG" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Curso Ingresado Correctamente
    </div>
    <div id="messageBoxError" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Error: Campos Vacios
    </div>
    <div id="messageBoxErrorC" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Error: Campos Repetidos
    </div>
    <!--Scripts-->
    <script type="text/javascript">
        function showMessageCicloG() {
            var messageBox = document.getElementById("messageBoxCicloG");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
    <script type="text/javascript">
        function showMessageCursoG() {
            var messageBox = document.getElementById("messageBoxCursoG");
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
</asp:Content>
