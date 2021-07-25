<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="WebApplication1.Evento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

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
                                        <asp:Label ID="lbFecha" runat="server" Text='<%#Eval("Fecha") %>'></asp:Label>
                                    </div>
                                </div>
                                <asp:Image ID="Image1" runat="server" Height="125px" ImageUrl='<%#"data:Image/jpg;base64," + Convert.ToBase64String((byte[])Eval("fotoEvento")) %>'/>
                    <div class="card">
                        <div class="card-header">
                            
                        </div>
                        <div class="card-body">
                            <h2 class="card-title">
                                <asp:Label ID="lbEvento" runat="server" Text='<%#Eval("NombreEvento") %>'>
                                </asp:Label></h2>
                            <h4>
                                <asp:Label ID="lbDescripcion" runat="server" Text='<%#Eval("Descripcion") %>'>
                                </asp:Label></h4>
                            <h4>
                                <asp:Label ID="lbubicacion" runat="server" Text='<%#Eval("Ubicacion") %>'>
                                </asp:Label></h4>
                            <h5>
                                </h5>
                            <h6>
                                <asp:Label ID="lbPuntos" runat="server" Text="Puntos: ">
                                </asp:Label>
                                <asp:Label ID="lbPuntosCantidad" runat="server" Text='<%#Eval("PuntosRequeridos") %>'>
                                </asp:Label></h6>
                            <h6>
                                <asp:Label ID="lbAforo" runat="server" Text="Aforo: ">
                                </asp:Label>
                                <asp:Label ID="lbAforoCantidad" runat="server" Text='<%#Eval("Aforo") %>'>
                                </asp:Label></h6>
                        </div>
                        <div class="card-footer">
                            <asp:Button ID="btnApuntarse" class="btn btn-primary" runat="server" Text="Apuntarse" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
