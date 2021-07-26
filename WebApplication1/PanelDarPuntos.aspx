<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanelDarPuntos.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1 style="text-align: center">Gestión de Puntos</h1>
        <!-- Button trigger modal -->

        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" class="table table-hover">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="" HeaderText="ID usuario"/>
                <asp:BoundField DataField="" HeaderText="Nombre de usuario"/>
                <asp:BoundField DataField="" HeaderText="ID usuario"/>
                <asp:BoundField DataField="" HeaderText="Nombre de la Actividad"/>
                <asp:BoundField DataField="" HeaderText="Numero de puntos de Usuario"/>
                <asp:BoundField DataField="" HeaderText="Numero de Puntos a actividad"/>

                <asp:TemplateField HeaderText="Opciones">
                    <ItemTemplate>
                        <asp:CheckBox ID="MarcarPuntos" runat="server" />
                        <asp:Button ID="btAceptarPuntos" class="btn btn-danger" runat="server" Text="Conceder" data-bs-toggle="modal" />                          
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>
    </div>

</asp:Content>

