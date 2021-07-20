<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="Contacto.css" rel="stylesheet" type="text/css" />

    <div class="container contacto">
        <div class="row">
            <div class="col-md-6 izq">
                <h3 class="ubicacion"> UBICACIÓN </h3>
                <div class="mapa">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d748.3376939137514!2d2.1793673292036506!3d41.388188004864446!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a2fc8176ca77%3A0xd56bea85d4c2a133!2sCarrer%20d&#39;En%20Ll%C3%A0stics%2C%202%2C%2008003%20Barcelona!5e0!3m2!1ses!2ses!4v1626788684597!5m2!1ses!2ses" 
                        width="500" height="400" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
                </div>
                <a class="infocontacto">
                    <img src="Icons/ubicacion.png" /> Carrer Llàstics, 2 - 08003 (Barcelona)
                    <br />
                    <img src="Icons/mensaje.png" /> atlantis@atlantisproject.com
                    <br />
                    <img src="Icons/telefono.png" /> (+34) 691 73 13 55
                </a>

            </div>
            <div class="col-md-6 der">
                <h3 class="contactanos">CONTÁCTANOS</h3>

            </div>
        </div>
    </div>
</asp:Content>
