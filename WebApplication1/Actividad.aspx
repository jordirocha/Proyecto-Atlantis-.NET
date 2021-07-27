﻿<%@ Page Title="Actividades" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Actividad.aspx.cs" Inherits="WebApplication1.Actividad" %>

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
                                </div>
                                <!--<img src="/Imagenes/playa1.jpg" />-->
                                <asp:Image ID="Image1" class="imagenevento" runat="server" ImageUrl='<%#"data:Image/jpg;base64," + Convert.ToBase64String((byte[])Eval("Imagen")) %>' />
                            </div>
                            <!-- Post Content-->
                            <div class="post-content">
                                <div class="category">
                                    <asp:Label ID="lbPuntosCantidad" runat="server" Text='<%#Eval("PuntosActividad") %>'></asp:Label>
                                    pts
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
                                        <h6>
                                            <asp:Label ID="lbIdActividad" runat="server" Visible="false" Text='<%#Eval("IdActividad") %>'>
                                            </asp:Label></h6>
                                    </span>
                                    <span class="comments">
                                        <a class="apuntarme" href="#">
                                            <asp:LinkButton ID="btnApuntarse" runat="server" Text="Apuntarse" OnClick="btnApuntarse_Click" />
                                        </a></span>
                                    </h6>
                                <h6>
                                    <asp:Label ID="lbApuntado" runat="server" Visible="false" Text="Ya te has apuntado a esta Actividad"></asp:Label></h6>
                                    <h6>
                                        <asp:Label ID="lbRegistrado" runat="server" Visible="false" Text="Registrado en la actividad">
                                        </asp:Label></h6>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <!-- <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>-->
    </div>

</asp:Content>
