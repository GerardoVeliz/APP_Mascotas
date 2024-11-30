<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarDueño.aspx.cs" Inherits="Web.RegistrarDueño" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="Styles.css">
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">

                <form id="form1" runat="server" class="border p-4 shadow-sm rounded bg-light">
                    <asp:Button ID="btnClose" runat="server" Text=" " CssClass="btn-close mt-3" OnClick="btnClose_Click" />
                    <div class="mb-3">
                        <h1 class="mt-3">Mis datos:  </h1>
                        <asp:Label ID="Label1" runat="server" Text="Ingrese nombre: " CssClass="form-label"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtbNombre" runat="server" CssClass="form-control"></asp:TextBox><br />
                        <asp:Label ID="Label2" runat="server" Text="Ingrese apellido: " CssClass="form-label"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox><br />
                        <asp:Label ID="Label3" runat="server" Text="Telefono: " CssClass="form-label"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtbTelefono" runat="server" CssClass="form-control"></asp:TextBox><br />
                        <asp:Label ID="Label4" runat="server" Text="Mail: " CssClass="form-label"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtbMail" runat="server" CssClass="form-control"></asp:TextBox><br />
                        <asp:Label ID="Label5" runat="server" Text="Direccion: " CssClass="form-label"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtbDireccion" runat="server" CssClass="form-control"></asp:TextBox><br />

                        <br />

                        <asp:Label ID="lblmsj" runat="server" Text="" CssClass="form-label"></asp:Label>
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />

                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
