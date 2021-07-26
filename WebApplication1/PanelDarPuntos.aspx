<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanelDarPuntos.aspx.cs" Inherits="WebApplication1.PanelDarPuntos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="FilaSeleccionada">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="IdUsuario" HeaderText="ID usuario" InsertVisible="False" ReadOnly="True" SortExpression="IdUsuario" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                <asp:BoundField DataField="puntosActuales" HeaderText="Puntos" SortExpression="puntosActuales" />
                <asp:BoundField DataField="idActividad" HeaderText="ID Actividad" InsertVisible="False" ReadOnly="True" SortExpression="idActividad" />
                <asp:BoundField DataField="nombre1" HeaderText="Actividad" SortExpression="nombre1" />
                <asp:BoundField DataField="puntosAdquiridos" HeaderText="Puntos actividad" SortExpression="puntosAdquiridos" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Conceder" ShowHeader="True" Text="Conceder puntos" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AtlantisConnectionString %>" SelectCommand="ListarUserActividad" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="IdUser" SessionField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
</asp:Content>
