<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Parcial1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Parcial 1</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Header -->
            <header class="py-3 mb-4 border-bottom">
                <div class="container d-flex flex-wrap justify-content-center">
                    <a href="/" class="d-flex align-items-center mb-3 mb-lg-0 me-lg-auto link-body-emphasis text-decoration-none">
                        <span class="fs-4">Ejercicio 1</span>
                    </a>
                    <div class="col-12 col-lg-auto mb-3 mb-lg-0" role="search">
                    </div>
                </div>
            </header>
            <div class="b-example-divider"></div>
            <!-- /////////// -->
            <!-- Formulario -->
            <div class="container">
                <h1>Venta</h1>
                <h2>Datos Cliente</h2>
                <div class="form-group row">
                    <div class="col-md-4 mb-4">
                        <a href="#" data-bs-toggle="modal" data-bs-target="#staticBackdrop">NIT</a>
                        <asp:TextBox ID="TextBoxNIT" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4 mb-4">
                        <asp:Label ID="Label2" runat="server" Text="Nombre:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4 mb-4">
                        <asp:Label ID="Label9" runat="server" Text="Apellido:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="TextBoxApellido" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-md-4 mb-4">
                        <asp:Label ID="Label3" runat="server" Text="Direccion:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4 mb-4">
                        <asp:Label ID="Label5" runat="server" Text="Telefono:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="TextBoxTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="b-example-divider"></div>
                <!-- /////////// -->
                <h2>Detalle Compra</h2>
                <div class="form-group row">
                    <div class="col-md-4 mb-4">
                        <asp:Label ID="Label6" runat="server" Text="Codigo:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="TextBoxCodigoCompra" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4 mb-4">
                        <asp:Label ID="Label7" runat="server" Text="Fecha Compra:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="TextBox6" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="b-example-divider"></div>
                <!-- //////GRIDVIEW///// -->
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" OnRowCommand="GridView1_RowCommand">
                </asp:GridView>
            </div>
        </div>
        <!-- //////MODALS///// -->
        <!-- //////Clientes///// -->
        <div class="modal fade modal-xl" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="staticBackdropLabel">Clientes</h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <!-- Aquí empieza el GridView -->
                        <div class="container">
                            <asp:GridView ID="GridViewClientes" runat="server" CssClass="table table-striped table-bordered">
                                <Columns>
                                    <asp:BoundField DataField="nit" HeaderText="NIT" />
                                    <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                    <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                                    <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                                    <asp:BoundField DataField="fechaNac" HeaderText="Fecha de Nacimiento" DataFormatString="{0:dd/MM/yyyy}" />
                                    <asp:TemplateField HeaderText="Acciones">
                                        <ItemTemplate>
                                            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CssClass="btn btn-primary btn-sm" CommandArgument='<%# Eval("nit") %>' CommandName="Seleccionar" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                        <!-- Aquí termina el GridView -->
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>
</body>
</html>
