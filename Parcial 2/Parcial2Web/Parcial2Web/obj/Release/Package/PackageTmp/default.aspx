<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Parcial2Web._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <style>
        .btn-color {
            background-color: #0e1c36;
            color: #fff;
        }

        .profile-image-pic {
            height: 200px;
            width: 200px;
            object-fit: cover;
        }

        body {
            background: #7F7FD5; /* fallback for old browsers */
            background: -webkit-linear-gradient(to right, #91EAE4, #86A8E7, #7F7FD5); /* Chrome 10-25, Safari 5.1-6 */
            background: linear-gradient(to right, #91EAE4, #86A8E7, #7F7FD5); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        }

        .cardbody-color {
            background-color: #ebf2fa;
        }

        a {
            text-decoration: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!---->
            <div class="container">
                <div class="row">
                    <div class="col-md-6 offset-md-3">
                        <h2 class="text-center text-dark mt-5">Bienvenido al Sistema</h2>
                        <div class="text-center mb-5 text-dark">Ingresa tus Creedenciales</div>
                        <div class="card my-5">

                            <div class="card-body cardbody-color p-lg-5">

                                <div class="text-center">
                                    <img src="https://cdn.pixabay.com/photo/2016/03/31/19/56/avatar-1295397__340.png" class="img-fluid profile-image-pic img-thumbnail rounded-circle my-3"
                                        alt="profile" />
                                </div>

                                <div class="mb-3">
                                    <asp:TextBox ID="TextBoxUser" CssClass="form-control" placeholder="Usuario" runat="server"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:TextBox ID="TextBoxPass" placeholder="Contraseña" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                                </div>
                                <div class="text-center">
                                    <asp:Button ID="ButtonLogin" CssClass="btn btn-color px-5 mb-5 w-100" runat="server" Text="Ingresar" OnClick="ButtonLogin_Click" />
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <!---->
        </div>
        <!--Modales-->
        <div id="messageBoxCicloG" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #4CAF50; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
            Por favor, ingrese usuario y contraseña.
        </div>
        <div id="messageBoxError" style="display: none; position: fixed; top: 60px; right: 20px; background-color: #eb0909; color: white; padding: 10px; border-radius: 5px; z-index: 1000;">
            Usuario o contraseña incorrectos.
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
    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>
</body>
</html>
