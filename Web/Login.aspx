<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Binevenido a el login: </h1> 

    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingrese nombre de usuario: "></asp:Label>
    <asp:TextBox ID="TxtbNombreUsuario" runat="server"></asp:TextBox><br />
    <asp:Label Text="Ingrese Contraseña: " runat="server" />
    <asp:TextBox ID="txtbContraseña" runat="server" /><br />
    <asp:Button Text="Aceptar" runat="server" OnClick="Unnamed3_Click" />
    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>

        
    </form>
</body>
</html>
