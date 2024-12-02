<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarMascota.aspx.cs" Inherits="Web.RegistrarMascota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Mascota</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    <div class="container mt-5">
        <div class="row justify-content-center">
           <form id="formVolver" runat="server">
                <asp:Label ID="lblDueñoNoRegistrado" runat="server" Text="" CssClass="text-danger"></asp:Label> <br />
                <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-secondary mt-3" Visible="false" OnClick="btnVolver_Click" />

    
</form>
            <asp:Panel ID="PanelFormulario" runat="server" CssClass="col-md-6">
                <h1 class="text-center mb-4">Registrar Mascota</h1>
                <form id="form1" runat="server" class="border p-4 shadow-sm rounded bg-light">
                    <asp:Button ID="btnClose" runat="server" Text=" " CssClass="btn-close mt-3" OnClick="btnClose_Click" />
                    <div class="mb-3">
                        <asp:Label ID="Label1" runat="server" Text="Nombre:" AssociatedControlID="txtNombre" class="form-label"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label2" runat="server" Text="Raza:" AssociatedControlID="txtRaza" class="form-label"></asp:Label>
                        <asp:TextBox ID="txtRaza" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label3" runat="server" Text="Fecha de nacimiento:" AssociatedControlID="txtFechaNacimiento" class="form-label"></asp:Label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Calendar ID="calFechaNacimiento" runat="server" CssClass="mt-2" OnSelectionChanged="calFechaNacimiento_SelectionChanged"></asp:Calendar>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="Label4" runat="server" Text="Foto:" AssociatedControlID="fuImagen" class="form-label"></asp:Label>
                        <asp:FileUpload ID="fuImagen" runat="server" CssClass="form-control" />
                    </div>
                    <div class="text-center">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="form-text text-danger"></asp:Label>
                    </div>
                    <div class="text-center">
                        <asp:Button ID="btnSubir" Text="Registrar Mascota" runat="server" CssClass="btn btn-primary mt-3" OnClick="btnSubir_Click" />
                    </div>
                </form>
            </asp:Panel>
        </div>
    </div>
</body>
</html>
