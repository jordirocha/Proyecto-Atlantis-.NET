<%@ Page Title="Nosotros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nosotros.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <div class="container-fluid">
    <h1>Two Unequal Responsive Columns</h1>
    <p>Resize the browser window to see the effect.</p>
    <p>The columns will automatically stack on top of each other when the screen is less than 576px wide.</p>
    <div class="row">
      <div class="col-sm-6" style="background-color:lavender;">
        <fieldset style="margin: 8px;
                    border: 1px solid silver;
                    padding: 8px;    
                    border-radius: 4px;">
          <legend style="padding:2px;"> Atlantis, una nueva forma de mejorar el mundo </legend>
        </fieldset>



      </div>
      <div class="col-sm-6" style="background-color:lavenderblush;">.col-sm-6</div>
    </div>
  </div>





</asp:Content>
