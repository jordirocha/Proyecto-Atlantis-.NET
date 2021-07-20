<%@ Page Title="Iniciar sesión" Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication1.LogIn" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio sesión</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <link href="login.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form class="form-signin" runat="server">
        <a href="~/" runat="server">
            <asp:Image ID="Image1" ImageUrl="~/Icons/logofinal.png" Height="185" runat="server" />
        </a>
        <h1 class="h3 mb-3 font-weight-normal">Iniciar sesión</h1>
        <asp:TextBox ID="TextEmail" type="email" class="form-control" placeholder="E-mail" required="" autofocus="" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextPass" type="password" class="form-control" placeholder="Contraseña" required="" runat="server"></asp:TextBox>
        <asp:Label ID="TxtLogInFailed" class="text-danger" Style="text-align: start !important" runat="server" Text=""></asp:Label>
        <div class="checkbox mb-3" style="text-align: start !important">
            <label>
                <asp:CheckBox ID="CheckCookies" runat="server" value="remember-me" />
                Recordarme 
            </label>
        </div>

        <asp:Button ID="Button2" class="btn btn-lg btn-primary btn-block" Style="width: 100%" runat="server" Text="Iniciar sesión" OnClick="ButIniciarSesion" />
        <p class="fraseregistro">¿Todavía no tienes cuenta? Regístrate <a href="#">aquí</a>. </p>
        <p class="mt-5 mb-3 text-muted">&copy; <%: DateTime.Now.Year %> - ATLANTIS</p>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

</body>
</html>
