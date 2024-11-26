<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menú Principal</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="Styles.css">
</head>
<body class="body-menu">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    <form id="form1" runat="server">
        <div class="container menu-container text-center">
            <div class="row justify-content-center">
                <div class="col-md-4 menu-item mb-3">
                    <a href="RegistrarMascota.aspx" class="btn">Registrar Mascota</a>
                </div>
                <div class="col-md-4 menu-item mb-3">
                    <a href="RegistrarDueño.aspx" class="btn">Mis Datos</a>
                </div>
                <div class="col-md-4 menu-item mb-3">
                    <a href="MostrarMascota.aspx" class="btn">Ver Mis Mascotas</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
