﻿<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link href="Default.css" rel="stylesheet" type="text/css" />
<link href='https://fonts.googleapis.com/css?family=Quicksand:300,400,700' rel='stylesheet' type='text/css'>
<link href='https://fonts.googleapis.com/css?family=Lato:400,300' rel='stylesheet' type='text/css'>

    <div class="jumbotron">
        <!-- Slider -->
        <div id="slider">
          <div class="slides">
            <div class="slider">
              <div class="legend"></div>
              <div class="content">
                <div class="content-txt">
                  <h1>Atlantis <br /> ¡Help nature, Win prices!</h1>
                </div>
              </div>
              <div class="image">
                <img src="Imagenes/slider1.jpg">
              </div>
            </div>
            <div class="slider">
              <div class="legend"></div>
              <div class="content">
                <div class="content-txt">
                  <h1>Ayudando al planeta...</h1>
                </div>
              </div>
              <div class="image">
                <img src="Imagenes/slider2.jpg">
              </div>
            </div>
            <div class="slider">
              <div class="legend"></div>
              <div class="content">
                <div class="content-txt">
                  <h1>Obtendrás increíbles recompensas</h1>
                </div>
              </div>
              <div class="image">
                <img src="Imagenes/slider3.jpg">
              </div>
            </div>
            <div class="slider">
              <div class="legend"></div>
              <div class="content">
                <div class="content-txt">
                  <h1>Y sobretodo... <br /> ¡mucha diversión!</h1>
                </div>
              </div>
              <div class="image">
                <img src="Imagenes/slider4.jpg">
              </div>
            </div>
          </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <p class="logobienvenidap">
                    <asp:Image class="logobienvenida" ImageUrl="~/Icons/logofinal.png" runat="server" />
                </p>
            </div>
            <div class="col-md-6">
                <h2 class="bienvenida">¡Bienvenidos a Atlantis!</h2>
                <p class="txtbienvenida">
                    Nuestros océanos son enormes, cubren casi las tres cuartas partes de nuestro planeta. 
                    Pero hoy en día hay miles de partículas de desechos de plásticos en cada kilómetro cuadrado de mar. 
                    Estamos destruyendo el legado de las futuras generaciones. Los recursos naturales de la tierra 
                    son parte de su futuro. Impulsados ​​por la idea de que todo el mundo es parte del problema y 
                    de la solución, queremos aportar nuestro granito de arena. Por esta razón, convertimos nuestro 
                    amor por las playas, los océanos y la música, en la puesta en marcha de nuestro proyecto.
                    Un proyecto en el que cualquier persona es bienvenida, y además, si te gusta vivir la música en directo, 
                    ayudando en esta lucha contra la destrucción de nuestros océanos, obtendrás entradas totalmente gratuitas.
                </p>
                <p class="leermas">
                    <a class="nosotros btn btn-default" href="Nosotros.aspx">Más sobre nosotros &raquo;</a>
                </p>
            </div>
        </div>

        <div class="data">
				<ul>
					<li>
                        <asp:Label id="registrostotal" class="numerodatos" runat="server" Text=""></asp:Label>
						<span>Registros</span>
					</li>
					<li class="datosactiv">
						<asp:Label id="actividadestotal" class="numerodatos" runat="server" Text=""></asp:Label>
						<span>Actividades</span>
					</li>
					<li>
						<asp:Label id="eventostotal" class="numerodatos" runat="server" Text=""></asp:Label>
						<span>Eventos</span>
					</li>
				</ul>
			</div>

    </div>

</asp:Content>
