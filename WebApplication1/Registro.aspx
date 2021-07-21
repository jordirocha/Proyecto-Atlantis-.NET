<%@ Page Title="Registro" Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebApplication1.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Registrarse </title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <link href="Registro.css" rel="stylesheet" />
    <script
      src="https://use.fontawesome.com/releases/v5.15.3/js/all.js"
      data-auto-a11y="true"
    ></script>

</head>
<body>
    
    <form class="form-signin" onsubmit="verificarContra()" runat="server">
        <asp:ScriptManager ID="sm1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/Registro.js" />
	        </Scripts>
         </asp:ScriptManager>
        <a href="~/" runat="server">
            <asp:Image ID="Image1" ImageUrl="~/Icons/logofinal.png" Height="185" runat="server" />
        </a>

        <h1 class="h3 mb-3 font-weight-normal">Registrarse</h1>

        <asp:TextBox id="TextNombrereg" type="text" class="form-control" placeholder="Nombre completo" required="" autofocus="" runat="server"></asp:TextBox>
        <asp:TextBox id="TextEmailreg" type="email" class="form-control" placeholder="E-mail" required="" runat="server"></asp:TextBox>
        <asp:TextBox id="TextPassreg" type="password" class="form-control" placeholder="Contraseña" required="" runat="server"></asp:TextBox>
        <asp:TextBox id="TextPass2reg" type="password" class="form-control" placeholder="Repetir contraseña" required="" runat="server"></asp:TextBox>
        
        
        

        <asp:Button ID="Button2" class="btn btn-lg btn-primary btn-block" type="submit" Style="width: 100%" runat="server" Text="Registrarse" />
        <p class="fraselogin">¿Ya tienes cuenta? Inicia sesión <a href="LogIn.aspx">aquí</a>. </p>
        <p class="mt-5 mb-3 text-muted">&copy; <%: DateTime.Now.Year %> - ATLANTIS</p>
    </form>
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
