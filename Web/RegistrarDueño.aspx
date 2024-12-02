<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarDueño.aspx.cs" Inherits="Web.RegistrarDueño" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRegistrado" runat="server" Text=""></asp:Label>
            <asp:Panel ID="panelFormulario" runat="server">
            <h1>Mis datos:  </h1> <br />   <br />  
            <asp:Label ID="Label1" runat="server" Text="Ingrese nombre: "></asp:Label> <br />
            <asp:TextBox ID="txtbNombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Ingrese apellido: "></asp:Label> <br />
              <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Telefono: "></asp:Label> <br />
              <asp:TextBox ID="txtbTelefono" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label4" runat="server" Text="Mail: "></asp:Label> <br />
              <asp:TextBox ID="txtbMail" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Direccion: "></asp:Label> <br />
              <asp:TextBox ID="txtbDireccion" runat="server"></asp:TextBox><br />

            <br />

            <asp:Label ID="lblmsj" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                </asp:Panel>
        </div>
    </form>
</body>
</html>
