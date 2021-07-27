﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventosInscritos.aspx.cs" Inherits="WebApplication1.EventosInscritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
         <br />
         <h1 style="text-align:center">Eventos inscritos</h1>
         <br />
         <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  class="table table-hover" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="CancelarEvento">
             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             <Columns>
                 <asp:BoundField DataField="nombre" HeaderText="Evento" SortExpression="nombre" />
                 <asp:BoundField DataField="fechaInscripcion" HeaderText="Fecha inscripción" SortExpression="fechaInscripcion" />
                 <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Cancelar" ShowHeader="True" Text="Cancelar" />
             </Columns>
             <EditRowStyle BackColor="#999999" />
             <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#E9E7E2" />
             <SortedAscendingHeaderStyle BackColor="#506C8C" />
             <SortedDescendingCellStyle BackColor="#FFFDF8" />
             <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
         </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AtlantisConnectionString %>" SelectCommand="EventosInscritosUsuario" SelectCommandType="StoredProcedure">
             <SelectParameters>
                 <asp:SessionParameter DefaultValue="0" Name="IdUser" SessionField="id" Type="Int32" />
             </SelectParameters>
         </asp:SqlDataSource>
     </div>
</asp:Content>
