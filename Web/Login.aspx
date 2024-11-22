<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <h1 class="text-center mb-4">Bienvenido al Login</h1>
                <form id="form1" runat="server" class="border p-4 shadow-sm rounded bg-light">
                    <div class="mb-3">
                        <asp:Label ID="Label1" runat="server" Text="Ingrese nombre de usuario:" class="form-label"></asp:Label>
                        <asp:TextBox ID="TxtbNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label Text="Ingrese Contraseña:" runat="server" class="form-label"></asp:Label>
                        <asp:TextBox ID="txtbContraseña" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="text-center">
                        <asp:Button Text="Aceptar" runat="server" CssClass="btn btn-primary" OnClick="Unnamed3_Click" />
                    </div>
                    <div class="mt-3 text-center">
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" class="form-text"></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </div>

</body>
</html>