<%@ Page Title="Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="WebApplication1.Evento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Evento.css" rel="stylesheet" type="text/css" />

    <div class="row">
        <asp:Repeater ID="repPosts" runat="server">
            <ItemTemplate>
                <div class="col-lg-3 col-md-3 col-sm-3 eventos">
                    <div class="column">
                        <!-- Post-->
                        <div class="post-module hover">
                            <!-- Thumbnail-->
                            <div class="thumbnail">
                                <div class="date">
                                    <div class="day">
                                        <asp:Label ID="lbFecha" runat="server" Text='<%#Eval("Fecha","{0:dd/MM/yyyy}") %>'></asp:Label>
                                    </div>
                                </div>
                                <asp:Image ID="Image1" class="imagenevento" runat="server" ImageUrl='<%#"data:Image/jpg;base64," + Convert.ToBase64String((byte[])Eval("fotoEvento")) %>'/>
                            </div>
                            <!-- Post Content-->
                            <div class="post-content">
                                <div class="category">
                                    <asp:Label ID="lbPuntosCantidad" runat="server" Text='<%#Eval("PuntosRequeridos") %>'></asp:Label> pts
                                </div>
                                <h1 class="title">
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("NombreEvento") %>'></asp:Label>
                                </h1>
                                <h2 class="sub_title">
                                    <asp:Label ID="lbubicacion" runat="server" Text='<%#Eval("Ubicacion") %>'></asp:Label>
                                </h2>
                                <p class="description">
                                    <asp:Label ID="lbDescripcion" runat="server" Text='<%#Eval("Descripcion") %>'></asp:Label>
                                </p>
                                <div class="post-meta">
                                    <span class="timestamp">
                                    <i>Aforo: </i>
                                        <asp:Label ID="lbAforoCantidad" runat="server" Text='<%#Eval("Aforo") %>'></asp:Label>
                                        <h6><asp:Label ID="lbIdEvento" runat="server" Visible="false" Text='<%#Eval("idEvento") %>'>
                                        </asp:Label></h6>
                                    </span>
                                    <span class="comments">
                                        <a class="apuntarme" href="#">
                                            <asp:LinkButton ID="btnApuntarse" runat="server" Text="Apuntarse" OnClick="btnApuntarse_Click" />
                                        </h6>
                                <h6>
                                    <asp:Label ID="lbApuntado" runat="server" Visible="false" Text="Ya te has apuntado a este evento"></asp:Label></h6>
                                            <h6>
                                                <asp:Label ID="lbRegistrado" runat="server" Visible="false" Text="Registrado en el evento">
                                                </asp:Label></h6>
                                            <h6>
                                                <asp:Label ID="lbPuntosInsuficientes" runat="server" Visible="false" Text="Puntos insuficientes">
                                                </asp:Label></h6>
                                        </a></span>
                                </div>
                            </div>
                        </div>
                    </div>                         
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
