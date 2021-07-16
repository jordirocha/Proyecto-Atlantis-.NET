<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication1.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio sesión</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <link href="css/login.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form class="form-signin" runat="server">
        <a href="~/" runat="server">
            <asp:Image ID="Image1" ImageUrl="~/Icons/logo.png" Height="170" runat="server" /></a>
        <h1 class="h3 mb-3 font-weight-normal">Saludos, inicia sesión</h1>
        <asp:TextBox ID="TextBox1" type="email" class="form-control" placeholder="Correo" required="" autofocus="" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" type="password" class="form-control" placeholder="Contraseña" required="" runat="server"></asp:TextBox>
        <asp:Label ID="TxtLogInFailed" class="text-danger" style="text-align: start !important" runat="server" Text=""></asp:Label>
        <div class="checkbox mb-3" style="text-align: start !important">
            <label>
                <input type="checkbox" value="remember-me" />
                Recordarme 
            </label>
        </div>

        <asp:Button ID="Button2" class="btn btn-lg btn-primary btn-block" Style="width: 100%" runat="server" Text="Iniciar sesión" OnClick="ButIniciarSesion" />

        <p class="mt-5 mb-3 text-muted">© Atlantis 2021-2022</p>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

</body>
</html>
