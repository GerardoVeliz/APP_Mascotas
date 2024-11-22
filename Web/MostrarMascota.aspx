<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarMascota.aspx.cs" Inherits="Web.MostrarMascota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista de Mascotas</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    <div class="container mt-5">
        <h1 class="text-center mb-4">Lista de Mascotas</h1>
        <asp:Repeater ID="rptMascotas" runat="server">
            <HeaderTemplate>
                <div class="row row-cols-1 row-cols-md-3 g-4">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="col">
                    <div class="card h-100 shadow-sm">
                        <img src='<%# ResolveUrl(Eval("urlImagen").ToString().Replace("~", "")) %>' class="card-img-top" alt="Imagen de Mascota">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("nombre") %></h5>
                            <p class="card-text">
                                <strong>Raza:</strong> <%# Eval("raza") %><br />
                                <strong>Fecha de Nacimiento:</strong> <%# Eval("fechaNacimiento", "{0:dd/MM/yyyy}") %>
                            </p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</body>
</html>
