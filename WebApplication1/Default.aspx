<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Default.css" rel="stylesheet" type="text/css" />

    <div class="jumbotron">
        <!-- Slider -->
        <div id="slider">
            <div class="slides">
                <div class="slider">
                    <div class="legend"></div>
                    <div class="content">
                        <div class="content-txt">
                            <h1>Atlantis
                                <br />
                                ¡Help nature, Win prices!</h1>
                        </div>
                    </div>
                    <div class="image">
                        <img src="Imagenes/slider6.jpg" class="img-fluid">
                    </div>
                </div>
                <div class="slider">
                    <div class="legend"></div>
                    <div class="content">
                        <div class="content-txt">
                            <h1>Ayúdanos a descontaminar</h1>
                        </div>
                    </div>
                    <div class="image">
                        <img src="Imagenes/slider8.jpg" class="img-fluid">
                    </div>
                </div>
                <div class="slider">
                    <div class="legend"></div>
                    <div class="content">
                        <div class="content-txt">
                            <h1>Obtendrás muchas recompensas</h1>
                        </div>
                    </div>
                    <div class="image">
                        <img src="Imagenes/slider7.jpg" class="img-fluid">
                    </div>
                </div>
                <div class="slider">
                    <div class="legend"></div>
                    <div class="content">
                        <div class="content-txt">
                            <h1>Y sobretodo...
                                <br />
                                ¡mucha diversión!</h1>
                        </div>
                    </div>
                    <div class="image">
                        <img src="Imagenes/slider4.jpg" class="img-fluid">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container overflow-hidden">
        <div class="row">
            <div class="col-md-4">
                <h2>Get more libraries</h2>
                <p>
                    NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
                </p>
            </div>
            <div class="col-md-4">
                <h2>Web Hosting</h2>
                <p>
                    You can easily find a web hosting company that offers the right mix of features and price for your applications.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
                </p>
            </div>
        </div>
    </div>

</asp:Content>
