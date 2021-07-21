<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanelEventos.aspx.cs" Inherits="WebApplication1.PanelEventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1 style="text-align: center">Gestión de eventos</h1>
        <!-- Button trigger modal -->
        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
            Añadir evento
        </button>
        
        <!-- Modal -->
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Nuevo evento</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Email address</label>
                                <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com" required>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Fecha</label>
                                <input type="date" class="form-control" required>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Puntos</label>
                                <input type="text" class="form-control" required>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Ubicación</label>
                                <input type="text" class="form-control" required>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Aforo</label>
                                <input type="text" class="form-control" required>
                            </div>

                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Foto</label>
                                <input type="file" class="form-control" id="inputGroupFile03" aria-describedby="inputGroupFileAddon03" aria-label="Upload" required>
                            </div>
                            <div class="col-md-12">
                                <label for="exampleFormControlTextarea1" class="form-label">Descripción del evento</label>
                                <textarea class="form-control" id="exampleFormControlTextarea1" rows="3" required></textarea>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>

                        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Guardar" />
                    </div>
                </div>
            </div>
        </div>
        

        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" class="table table-hover">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Eliminar" ShowHeader="True" Text="Eliminar" />
                <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Editar" ShowHeader="True" Text="Editar" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>

    </div>

</asp:Content>
