<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="Contacto.css" rel="stylesheet" type="text/css" />

    <div class="container contacto">
        <div class="row">
            <div class="col-md-6 izq">
                <h3 class="ubicacion"> UBICACIÓN </h3>
                <div class="mapa">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d748.3376939137514!2d2.1793673292036506!3d41.388188004864446!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a2fc8176ca77%3A0xd56bea85d4c2a133!2sCarrer%20d&#39;En%20Ll%C3%A0stics%2C%202%2C%2008003%20Barcelona!5e0!3m2!1ses!2ses!4v1626788684597!5m2!1ses!2ses" 
                        width="520" height="400" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
                </div>
                <p class="infocontacto">
                    <img src="Icons/ubicacion.png" /> Carrer Llàstics, 2 - 08003 (Barcelona)
                    <br />
                    <img src="Icons/mensaje.png" /> atlantis@atlantisproject.com
                    <br />
                    <img src="Icons/telefono.png" /> (+34) 691 73 13 55
                </p>

            </div>
            <div class="col-md-6 der">
                <h3 class="contactanos">CONTÁCTANOS</h3>
                <asp:TextBox ID="TextEmail" class="form-control" type="email" placeholder="E-mail" autofocus="" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextAsunto" class="form-control" type="text" placeholder="Asunto" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextMensaje" class="form-control" TextMode="multiline" placeholder="Mensaje" Columns="50" Rows="8" runat="server" />
                <asp:Button ID="ButContacto" class="form-control btn btn-lg btn-primary btn-block float-right" runat="server" Text="Enviar" OnClick="ButFormContacto" />
                <br />
                <asp:Label ID="TxtFormEnviado" class="text-success" Style="text-align: start !important; font-weight: bold;" runat="server" Text=""></asp:Label>
                <asp:Label ID="TxtFormEnviado2" class="text-danger" Style="text-align: start !important; font-weight: bold;" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="row">
                <p class="recibiremail"> ¡Si quieres recibir lo último en actividades y eventos, déjanos tu email aquí!</p>
                <div class="recibiremails">   
                    <asp:TextBox ID="TextEmail2" class="TextEmail2 form-control" type="email" placeholder="E-mail" runat="server"></asp:TextBox>
                    <asp:Button ID="ButSuscripcion" class="btn btn-lg btn-primary" runat="server" Text="Suscribirse" OnClick="ButSuscripcionEmail" />
                </div>
                <asp:Label ID="TxtSuscripcionEnviada" class="text-success" Style="text-align: center !important; font-weight: bold;" runat="server" Text=""></asp:Label>
                <asp:Label ID="TxtSuscripcionEnviada2" class="text-danger" Style="text-align: center !important; font-weight: bold;" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
