<%@ Page Title="Nosotros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nosotros.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Nosotros.css" rel="stylesheet" />

    <div class="container-fluid">
    <div class="row">
      <div class="col-sm-6">
        <div class="card">
            <h5 class="card-header">Atlantis, una nueva forma de mejorar el mundo</h5>
            <div class="card-body">                
                <p class="card-text">Todo comienza con una idea. 
                    Tal vez quieras escuchar música en vivo de tu cantante o grupo favorito 
                    pero no quieres gastar mucho. O bien, es posible que quieras ayudar a 
                    proteger la vida marina y obtener una recompensa por ello. Sea como sea, 
                    la manera en la que quieras, puede marcar la diferencia.</p>
            </div>
        </div>
      </div>
      <div class="col-sm-6">
          
          <div class="testimonios"> 
              <h1 class="testi">TESTIMONIOS</h1>   
            <div class="testimonial-quote group right">
                <img src="/Icons/user1.png">
                <div class="quote-container">
                    <div>
                        <blockquote>

                            <p>Este método me pareció increíble, puedo ir a conciertos de forma gratuita 
                                ayudando a nuestro planeta, es IMPRESIONANTE.</p>
                        </blockquote>  
                        <cite><span>Alberto Sanchez</span><br>
                            Estudiante de Psicologia<br>
                            UAB Barcelona
                        </cite>
                    </div>
                </div>
            </div>     

            <hr style="margin: 5px auto; opacity: .5;">

            <div class="testimonial-quote group right">
                <img src="/Icons/user1.png">
                <div class="quote-container">
                    <div>
                        <blockquote>

                            <p>Este método me pareció increíble, puedo ir a conciertos de forma gratuita 
                                ayudando a nuestro planeta, es IMPRESIONANTE.</p>
                        </blockquote>  
                        <cite><span>Alberto Sanchez</span><br>
                            Estudiante de Psicologia<br>
                            UAB Barcelona
                        </cite>
                    </div>
                </div>
            </div>


        </div>
     </div>
    </div>
    <div class="row">
      <div class="col-sm-6">
        <div class="card ue">
            <h5 class="card-header ue">DATOS DE LA UE</h5>
            <div class="card-body">
                <p class="card-title"> En 2050 podría haber más plástico que peces en el océano. </p>
                <div class="card-text">
                    <div class="row">
                        <div class="datos col-sm-3">
                            <img class="datosimg" src="/Icons/dinero.png"/>
                        </div>
                        <div class="datos col-sm-3">
                            <img class="datosimg" src="/Icons/reciclar.png"/>
                        </div>
                        <div class="datos col-sm-3">
                            <img class="datosimg" src="/Icons/boligrafo.png"/>
                        </div>
                        <div class="datos col-sm-3">
                            <img class="datosimg" src="/Icons/estadisticas.png"/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="datos col-sm-3">
                            <p class="datosue">
                                Gracias a las organizaciones que nos financian se ha creado este gran proyecto 
                            </p>
                        </div>
                        <div class="datos col-sm-3">
                            <p class="datosue">
                                10 millones de toneladas de basura se vierten en nuestro océano cada año
                            </p>
                        </div>
                        <div class="datos col-sm-3">
                            <p class="datosue">                            
                                España es el segundo país que más plástico vierte en el mar Mediterráneo
                            </p>
                        </div>
                        <div class="datos col-sm-3">
                            <p class="datosue">
                                Objetivo de la UE: Reducir un 30% la basura marina que se encuentra en las playas
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
      </div>
  </div>





</asp:Content>
