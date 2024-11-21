<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="Web.altaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Registrar Usuario</h1>

            <asp:Label ID="Label1" runat="server" Text="Ingrese nombre de usuario: "></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Ingrese contraseña: "></asp:Label>
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="lblmsj" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

            
        </div>
    </form>
</body>
</html>
