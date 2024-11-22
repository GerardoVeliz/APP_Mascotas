<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="Web.altaUsuario" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Usuario</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    <form id="form1" runat="server" class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <h1 class="text-center mb-4">Registrar Usuario</h1>

                <div class="mb-3">
                    <label for="txtNombre" class="form-label">Nombre de Usuario:</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Ingrese su nombre de usuario"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <label for="txtPass" class="form-label">Contraseña:</label>
                    <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" TextMode="Password" placeholder="Ingrese su contraseña"></asp:TextBox>
                </div>

                <asp:Label ID="lblmsj" runat="server" CssClass="form-text text-danger"></asp:Label>

                <div class="text-center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary w-100" OnClick="btnAceptar_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
