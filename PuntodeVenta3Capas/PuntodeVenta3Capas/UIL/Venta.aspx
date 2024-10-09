<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Venta.aspx.cs" Inherits="PuntodeVenta3Capas.UIL.Venta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Punto Venta</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Formulario -->
            <div class="container mt-5">
                <div class="row">
                    <!-- Columna para el formulario -->
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-header text-center color1 text-white">
                                <h2>Venta</h2>
                            </div>
                            <div class="card-body">
                                <div class="container">
                                    <div class="mb-3">
                                        <asp:Label runat="server" Text="NIT" AssociatedControlID="txtNIT" data-bs-toggle="modal" data-bs-target="#staticBackdrop" />
                                        <asp:TextBox runat="server" ID="txtNIT" CssClass="form-control" Enabled="false" />
                                    </div>
                                    <div class="mb-3">
                                        <asp:Label runat="server" Text="Nombre del Producto" AssociatedControlID="txtNombreProducto" />
                                        <asp:TextBox runat="server" ID="txtNombreProducto" CssClass="form-control" />
                                    </div>
                                    <div class="mb-3">
                                        <div class="col">
                                        <asp:Label runat="server" Text="Precio de Costo" AssociatedControlID="txtPrecioCosto" />
                                        <asp:TextBox runat="server" ID="txtPrecioCosto" CssClass="form-control" />
                                        </div>
                                        <div class="col">
                                            <asp:Label runat="server" Text="Precio de Venta" AssociatedControlID="txtPrecioVenta" />
                                        <asp:TextBox runat="server" ID="txtPrecioVenta" CssClass="form-control" />
                                   </div>
                                      </div>
                                    <div class="mb-3">
                                    </div>
                                    <div class="mb-3">
                                        <asp:Label runat="server" Text="Estado" AssociatedControlID="chkEstado" />
                                        <asp:CheckBox runat="server" ID="chkEstado" CssClass="form-check-input" />
                                    </div>
                                    <div class="mb-3">
                                        <asp:Label runat="server" Text="Categoría" AssociatedControlID="ddlCategoria" />
                                        <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Columna para el formulario -->
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-header text-center color1 text-white">
                                <h2>Venta</h2>
                            </div>
                            <div class="card-body">
                                <div class="container">
                                    <asp:GridView ID="GridViewListaProductos" runat="server"></asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!----->
            <!--Formularios Modal--->
            <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                <div class="modal-dialog modal-xl">
                    <div class="modal-content color1">
                        <div class="modal-header">
                            <h1 class="modal-title fs-5 text-white" id="staticBackdropLabel">Clientes</h1>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <!---->
                            <div class="d-flex justify-content-center align-items-center">
                                <asp:TextBox ID="TextBoxBuscarNit" placeholder="Buscar Cliente por DPI" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div style="overflow-x: auto;">
                                <asp:GridView ID="GridViewClientes" runat="server" CssClass="table table-striped table-bordered table-responsive"
                                    AutoGenerateSelectButton="true">
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
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>
</body>
</html>
