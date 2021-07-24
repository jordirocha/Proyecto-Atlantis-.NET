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
                                <asp:TextBox ID="TxtNomEvento" class="form-control" runat="server" required=""></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Fecha</label>
                                <asp:TextBox ID="TxtFechaEvento" class="form-label" TextMode="DateTimeLocal" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Puntos requeridos</label>
                                <asp:TextBox ID="TxtPuntos" class="form-control" runat="server" TextMode="Number" MinimumValue="0"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Ubicación</label>
                                <asp:TextBox ID="TxtUbicacion" class="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Aforo</label>
                                <asp:TextBox ID="TxtAforo" class="form-control" runat="server" TextMode="Number" MinimumValue="0"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Foto</label>
                                <asp:FileUpload ID="FotoEvento" class="form-control" runat="server" aria-describedby="inputGroupFileAddon03" aria-label="Upload" required="" />
                            </div>
                            <div class="col-md-12">
                                <label for="exampleFormControlTextarea1" class="form-label">Descripción del evento</label>

                                <asp:TextBox ID="TxtDesc" class="form-control" Rows="5" runat="server"></asp:TextBox>
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


        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" class="table table-hover" AllowPaging="True" PageSize="2" DataKeyNames="idEvento" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="idEvento" HeaderText="idEvento" InsertVisible="False" ReadOnly="True" SortExpression="idEvento" />
                 <asp:TemplateField>
                    <ItemTemplate>
                        <div class="container-fluid">
                            <div class="row">
                                <div class="col-lg-10">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("nombre") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                        </div>
                                        <div class="col-auto">
                                            <asp:Label ID="Label8" runat="server" Text='<%# "<strong>Lugar: </strong>" + Eval("ubicacion") %>'></asp:Label>
                                        </div>
                                        <div class="col-auto">
                                            <asp:Label ID="Label15" runat="server" Text='<%# "<strong>Fecha:</strong> "+ Eval("fecha") %>'></asp:Label>
                                        </div>
                                        <div class="col-auto">
                                            <asp:Label ID="Label22" runat="server" Text='<%# "<strong>Puntos:</strong> "+ Eval("puntosRequeridos") %>'></asp:Label>
                                        </div>
                                        <div class="col-auto">

                                            <asp:Label ID="Label4" runat="server" Text='<%# "<strong>Aforo:</strong> "+ Eval("aforo") %>'></asp:Label>
                                        </div>
                                        <div class="col-12">
                                            <asp:Label ID="Label5" runat="server" Text='<%# "<strong>Descripción:</strong> <br/>"+ Eval("descripcion") %>'></asp:Label>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-2">
                                    <asp:Image ID="Image1" runat="server" Width="200px" class="img-fluid" ImageUrl='<%#"data:Image/jpg;base64," + Convert.ToBase64String((byte[])Eval("fotoEvento")) %>' />
                                </div>
                            </div>
                        </div>
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



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AtlantisConnectionString %>"
            SelectCommand="EventosUsuario" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="IdUsuario" SessionField="ID" Type="Int32" />
            </SelectParameters>
            
        </asp:SqlDataSource>

    </div>

</asp:Content>
