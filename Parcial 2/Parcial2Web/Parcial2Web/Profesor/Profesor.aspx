<%@ Page Title="" Language="C#" MasterPageFile="~/MasterWebs/SiteProfesor.Master" AutoEventWireup="true" CodeBehind="Profesor.aspx.cs" Inherits="Parcial2Web.Profesor.Profesor" %>
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
        <p class="display-5  text-body-emphasis">Modulo para ver Administrar Cursos</p>
    </div>
    <!--Ingreso-->
    <div class="container col-xl-10 col-xxl-8 px-4">
        <div class="row align-items-center g-lg-5 py-1">
            <div class="col-lg-12 text-center text-lg-start">
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6">Cursos a Impartir</h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3 col-md-12 mx-auto color1">
            <div class="row">
                <!-- GridView -->
                  <div class="container mt-5 p-4 p-md-5 rounded-3 col-md-12 mx-auto color1">
            <div class="row">
              <div class="col">
                 <asp:TextBox ID="TextBox2" placeholder="Buscar Asignacion por Curso" OnTextChanged="TextBox2_TextChanged"  AutoPostBack="true" CssClass="form-control" runat="server"></asp:TextBox>
                  <div style="overflow-x: auto;">
                     <asp:GridView ID="GridViewCursosDisponibles" runat="server" CssClass="table table-striped table-bordered table-responsive"
                            DataKeyNames="codigo_prof_curso" 
                            AllowPaging="True" PageSize="3" OnPageIndexChanging="GridViewCursosDisponibles_PageIndexChanging">
                            <HeaderStyle CssClass="table-dark" />
                            <RowStyle CssClass="align-middle" />
                            <AlternatingRowStyle CssClass="table-light" />
                        </asp:GridView>
                      </div>
              </div>
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
                <h1 class="display-4 fw-bold lh-1 text-body-emphasis mb-6"><asp:HyperLink ID="HyperLink2" data-bs-toggle="modal" data-bs-target="#staticBackdrop1" runat="server">Asignacion de Notas</asp:HyperLink></h1>
            </div>
        </div>

        <div class="container mt-5 p-4 p-md-5 rounded-3 col-md-12 mx-auto color1">
            <div class="row">
                <!-- Izquierda: Grupos de botones o inputs -->
                <div class="col-md-6">
                     <div class="mb-3">
                        <asp:Label ID="Label7" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Codigo Asignacion"></asp:Label>
                        <asp:TextBox ID="TextBoxCodAsig" Enabled="false" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label1" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Fecha Asignacion"></asp:Label>
                        <asp:TextBox ID="TextBoxFechaAsign" Enabled="false"  TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label5" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Final"></asp:Label>
                        <asp:TextBox ID="TextBoxFinal" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <div class="mb-3">
                        <asp:Label ID="Label2" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Resultado"></asp:Label>
                        <asp:TextBox ID="TextBoxResultado" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                      <div class="mb-3">
                        <asp:Label ID="Label4" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Codigo Alumno"></asp:Label>
                        <asp:TextBox ID="TextBoxCodAlum" Enabled="false"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- Derecha: Campos adicionales -->
                <div class="col-md-6">
                    <div class="mb-3">
                        <asp:Label ID="Label14" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Zona"></asp:Label>
                        <asp:TextBox ID="TextBoxZona" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label15" CssClass="fs-3 fw-bolder text-white" runat="server" Text="Total"></asp:Label>
                        <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <div class="mb-3">
                        <asp:Label ID="Label3" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Estado Delegado"></asp:Label>
                         <asp:CheckBox ID="CheckBoxDelegado" CssClass="form-control" runat="server" />
                    </div>
                      <div class="mb-3">
                        <asp:Label ID="Label6" CssClass="fs-3 fw-bolder  text-white" runat="server" Text="Codigo Profesor del Curso"></asp:Label>
                        <asp:TextBox ID="TextBoxCodProfCurso" Enabled="false"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                 <div class="text-center">
                                    <asp:Button ID="ButtonLogin" CssClass="btn btn-color px-5 mb-5 w-100" runat="server" Text="Modificar" OnClick="ButtonLogin_Click" />
                  </div>
            </div>
        </div>
    </div>
    <br />
    <!--MODAL-->
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
                    </div>
                    <div style="overflow-x: auto;">
                        <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-responsive"
                            DataKeyNames="codigo_asignacion" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                            AllowPaging="True" PageSize="3" OnPageIndexChanging="GridView1_PageIndexChanging" >
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
        Asignacion Actualizada Correctamente
    </div>
    <div id="messageBoxError" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Asignación no encontrada
    </div>
    <div id="messageBoxErrorC" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
        Código de asignación inválido
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
    <script type="text/javascript">
        function showMessageError() {
            var messageBox = document.getElementById("messageBoxErrorC");
            messageBox.style.display = "block";
            setTimeout(function () {
                messageBox.style.display = "none";
            }, 3000); // Ocultar el mensaje después de 3 segundos
        }
    </script>
</asp:Content>
