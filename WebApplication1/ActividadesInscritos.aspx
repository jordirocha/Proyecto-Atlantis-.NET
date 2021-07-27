<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActividadesInscritos.aspx.cs" Inherits="WebApplication1.ActividadesInscritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
         <br />
         <h1 style="text-align:center">Acticidades inscritos</h1>
         <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" class="table table-hover" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="Actividad" SortExpression="nombre" />
                <asp:BoundField DataField="fechaInscripcion" HeaderText="Fecha inscripción" SortExpression="fechaInscripcion" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AtlantisConnectionString %>" SelectCommand="ActividadesInscritosUsuario" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="IdUser" SessionField="id" Type="Int32" />
            </SelectParameters>
         </asp:SqlDataSource>
        </div>
</asp:Content>
