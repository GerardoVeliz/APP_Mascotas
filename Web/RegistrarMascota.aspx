<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarMascota.aspx.cs" Inherits="Web.RegistrarMascota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Registrar Mascota: </h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre : "></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Raza:"></asp:Label>
            <asp:TextBox ID="txtRaza" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Fecha de nacimiento: "></asp:Label>
           <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
            <asp:Calendar ID="calFechaNacimiento" runat="server" OnSelectionChanged="calFechaNacimiento_SelectionChanged"></asp:Calendar>
            <br /><br />
            <asp:Label ID="Label4" runat="server" Text="Foto "></asp:Label>
            <asp:FileUpload ID="fuImagen" runat="server" />
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

            <br />
            <asp:Button ID="btnSubir" Text="Registrar Mascota" runat="server" OnClick="btnSubir_Click" />
            

        </div>
    </form>
</body>
</html>
