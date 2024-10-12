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
                    <!-- Columna para el formulario de venta -->
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-header text-center bg-primary text-white">
                                <h2>Venta</h2>
                            </div>
                            <div class="card-body">
                                <div class="mb-3">
                                    <asp:Label runat="server" Text="NIT" AssociatedControlID="txtNIT" data-bs-toggle="modal" data-bs-target="#staticBackdrop" />
                                    <asp:TextBox runat="server" ID="txtNIT" CssClass="form-control" Enabled="false" />
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <asp:Label runat="server" Text="Codigo Producto" AssociatedControlID="TextBoxCodP" data-bs-toggle="modal" data-bs-target="#staticBackdrop1" />
                                        <asp:TextBox runat="server" ID="TextBoxCodP" Enabled="false" CssClass="form-control" />
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <asp:Label runat="server" Text="Producto" AssociatedControlID="txtNombreProducto" />
                                        <asp:TextBox runat="server" Enabled="false" ID="txtNombreProducto" CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <asp:Label runat="server" Text="Precio" AssociatedControlID="txtPrecioVenta" />
                                        <asp:TextBox runat="server" Enabled="false" ID="txtPrecioVenta" CssClass="form-control" />
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <asp:Label runat="server" Text="Cantidad" AssociatedControlID="txtCantidad" />
                                        <asp:TextBox runat="server" ID="txtCantidad" CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="mb-3">
                                    <asp:Button ID="BttnAgregar" OnClick="BttnAgregar_Click" runat="server" Text="Agregar" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Columna para la lista de productos -->
                    <div class="col-md-6">
                        <div class="card">
                            <div class="card-header text-center bg-primary text-white">
                                <h2>Lista de Productos</h2>
                            </div>
                            <div class="card-body">
                                <asp:GridView ID="GridViewListaProductos" AutoGenerateColumns="false" OnRowDeleting="GridViewListaProductos_RowDeleting" runat="server" CssClass="table table-striped">
                                    <Columns>
                                        <asp:BoundField DataField="codigo_producto" HeaderText="Código" />
                                        <asp:BoundField DataField="nombre_producto" HeaderText="Nombre" />
                                        <asp:BoundField DataField="precio_costo" HeaderText="Precio" />
                                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                        <asp:BoundField DataField="subtotal" HeaderText="Subtotal" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                    </Columns>
                                </asp:GridView>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <asp:Label ID="Label2" runat="server" Text="Cantidad Total"></asp:Label>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <asp:Label ID="LabelCantTotal" runat="server" Text="0"></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <asp:Label ID="LabelTotal" runat="server" Text="0"></asp:Label>
                                    </div>
                                </div>
                            </div>
                            <div class="mb-3">
                                <asp:Button ID="ButtonComprar" OnClick="ButtonComprar_Click" runat="server" Text="Realizar Compra" CssClass="form-control" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!----->
            <!--Formularios Modal--->
            <!--Cliente--->
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
                                <asp:TextBox ID="TextBoxBuscarNit" placeholder="Buscar Cliente por DPI" CssClass="form-control" OnTextChanged="TextBoxBuscarNit_TextChanged" runat="server"></asp:TextBox>
                            </div>
                            <div style="overflow-x: auto;">
                                <asp:GridView ID="GridViewClientes" DataKeyNames="nit_cliente" runat="server" CssClass="table table-striped table-bordered table-responsive"
                                    AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridViewClientes_SelectedIndexChanged">
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
            <!--Cliente--->
            <div class="modal fade" id="staticBackdrop1" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                <div class="modal-dialog modal-xl">
                    <div class="modal-content color1">
                        <div class="modal-header">
                            <h1 class="modal-title fs-5 text-white" id="staticBackdropLabel1">Clientes</h1>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <!---->
                            <div class="d-flex justify-content-center align-items-center">
                                <asp:TextBox ID="TxtBuscarPro" placeholder="Buscar Producto" OnTextChanged="TxtBuscarPro_TextChanged" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div style="overflow-x: auto;">
                                <asp:GridView ID="GridViewProducto" AutoGenerateColumns="false" DataKeyNames="codigo_producto,nombre_producto,precio_costo,existencia_producto,nombre_marca" OnSelectedIndexChanged="GridViewProducto_SelectedIndexChanged" runat="server" CssClass="table table-striped table-bordered table-responsive"
                                    AutoGenerateSelectButton="true">
                                    <HeaderStyle CssClass="table-dark" />
                                    <RowStyle CssClass="align-middle" />
                                    <AlternatingRowStyle CssClass="table-light" />
                                    <Columns>
                                        <asp:BoundField DataField="codigo_producto" HeaderText="Código Producto" SortExpression="codigo_producto" />
                                        <asp:BoundField DataField="nombre_producto" HeaderText="Nombre Producto" SortExpression="nombre_producto" />
                                        <asp:BoundField DataField="precio_costo" HeaderText="Precio" SortExpression="precio_costo" DataFormatString="{0:C}" />
                                        <asp:BoundField DataField="existencia_producto" HeaderText="Existencia" SortExpression="existencia_producto" />
                                        <asp:BoundField DataField="nombre_marca" HeaderText="Marca" SortExpression="nombre_marca" />

                                    </Columns>
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
                <!-- Modales -->
        <div id="messageBoxSuccess" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
            Compra Realizada correctamente.
        </div>
        <!-- Scripts para mostrar los modales -->
        <script type="text/javascript">
            function showSuccessMessage() {
                var messageBox = document.getElementById("messageBoxSuccess");
                messageBox.style.display = "block";
                setTimeout(function () {
                    messageBox.style.display = "none";
                }, 3000); // Ocultar el mensaje después de 3 segundos
            }
        </script>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>
</body>
</html>
