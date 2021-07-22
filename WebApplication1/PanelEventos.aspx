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
                                <label for="exampleFormControlInput1" class="form-label">Nombre del evento</label>
                                <asp:TextBox ID="TextBox1" class="form-control" runat="server" required></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Fecha</label>
                                <asp:TextBox ID="TextBox3" textmode="DateTimeLocal" runat="server" class="form-label"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Puntos requeridos</label>
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
                                <asp:FileUpload ID="FileUpload1" class="form-control" runat="server" aria-describedby="inputGroupFileAddon03" aria-label="Upload" required />
                            </div>
                            <div class="col-md-12">
                                <label for="exampleFormControlTextarea1" class="form-label">Descripción del evento</label>
                                <textarea class="form-control" id="exampleFormControlTextarea1" rows="3" required></textarea>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Salir</button>
                        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Guardar" OnClick="ButInsertEvento" />
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
        <asp:Label ID="Label1" runat="server" Text="Label">

            <div class="col-md-3" id="Alerta">
            <svg xmlns="http://www.w3.org/2000/svg" style="display: none;">
            <symbol id="check-circle-fill" fill="currentColor" viewBox="0 0 16 16">
                <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z" />
            </symbol>
            <symbol id="info-fill" fill="currentColor" viewBox="0 0 16 16">
                <path d="M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z" />
            </symbol>
            <symbol id="exclamation-triangle-fill" fill="currentColor" viewBox="0 0 16 16">
                <path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z" />
            </symbol>
        </svg>
        <div class="alert alert-success d-flex align-items-center" role="alert">
            <svg class="bi flex-shrink-0 me-2" width="24" height="24" role="img" aria-label="Success:">
                <use xlink:href="#check-circle-fill" />
            </svg>
            <div>
                ¡Nuevo evento insertado!
            </div>
        </div>
        </div>

        </asp:Label>


    </div>

</asp:Content>
