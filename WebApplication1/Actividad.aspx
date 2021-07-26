<%@ Page Title="Actividades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actividad.aspx.cs" Inherits="WebApplication1.Actividad" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Actividad.css" rel="stylesheet" type="text/css" />
    
    <div class="row">
    <asp:Repeater ID="repPosts" runat="server">
    <ItemTemplate>
        <div class="col-lg-3 col-md-3 col-sm-3 actividades">
            <div class="column">
                <!-- Post-->
                <div class="post-module hover">
                    <!-- Thumbnail-->
                    <div class="thumbnail">
                        <div class="date">
                            <div class="day">
                                <asp:Label ID="lbFecha" runat="server" Text='<%#Eval("FechaActividad","{0:dd/MM/yyyy}") %>'></asp:Label>
                            </div>
                        </div><img src="/Imagenes/playa1.jpg" />
                    </div>
                    <!-- Post Content-->
                    <div class="post-content">
                        <div class="category">
                            <asp:Label ID="lbPuntosCantidad" runat="server" Text='<%#Eval("PuntosActividad") %>'></asp:Label> pts
                        </div>
                        <h1 class="title">
                            <asp:Label ID="lbActividad" runat="server" Text='<%#Eval("NombreActividad") %>'></asp:Label>
                        </h1>
                        <h2 class="sub_title">
                            <asp:Label ID="lbubicacion" runat="server" Text='<%#Eval("UbicacionActividad") %>'></asp:Label>
                        </h2>
                        <p class="description">
                            <asp:Label ID="lbDescripcion" runat="server" Text='<%#Eval("DescripcionActividad") %>'></asp:Label>
                        </p>
                        <div class="post-meta">
                        <span class="timestamp">
                            <i>Aforo: </i>
                            <asp:Label ID="lbAforoCantidad" runat="server" Text='<%#Eval("AforoActividad") %>'></asp:Label>
                        </span>
                        <span class="comments">
                            <a class="apuntarme" href="#">Apuntarme</a></span></div>
                    </div>
                </div>
            </div>                         
        </div>
    </ItemTemplate>
    </asp:Repeater>
    </div>

</asp:Content>
