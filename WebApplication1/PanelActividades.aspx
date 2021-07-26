<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanelActividades.aspx.cs" Inherits="WebApplication1.PanelActividades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1 style="text-align: center">Gestión de actividades</h1>
        <!-- Button trigger modal -->

        <asp:Button ID="Button2" runat="server" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" Text="Añadir actividad" />
        <!-- Modal -->
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Nuevo evento</h5>
                        <!--<button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>-->
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Nombre actividad</label>
                                <asp:TextBox ID="TxtNomAct" class="form-control" runat="server" required=""></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Fecha</label><br />
                                <asp:TextBox ID="TxtFechaAct" class="form-label" TextMode="Date" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="exampleFormControlInput1" class="form-label">Puntos adquirir</label>
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
                                <asp:FileUpload ID="FotoAct" class="form-control" runat="server" aria-describedby="inputGroupFileAddon03" aria-label="Upload" required="" />
                            </div>
                            <div class="col-md-12">
                                <label for="exampleFormControlTextarea1" class="form-label">Descripción de la actividad</label>
                                <asp:TextBox ID="TxtDesc" class="form-control" Rows="5" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="Button3" runat="server" class="btn btn-secondary" data-bs-dismiss="modal" Text="Salir" />
                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Añadir" OnClick="ButAnyadirNuevoAct" />
                    </div>
                </div>
            </div>
        </div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idActividad" DataSourceID="SqlDataSource1" OnRowDeleting="ActividadEliminada" AllowPaging="True" PageSize="5" class="table table-hover">
            <Columns>
                <asp:BoundField DataField="idActividad" HeaderText="idActividad" InsertVisible="False" ReadOnly="True" SortExpression="idActividad" />
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
                                            <asp:Label ID="Label22" runat="server" Text='<%# "<strong>Puntos:</strong> "+ Eval("puntosAdquiridos") %>'></asp:Label>
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
                                    <asp:Image ID="Image1" runat="server" Width="200px" class="img-fluid" ImageUrl='<%#"data:Image/jpg;base64," + Convert.ToBase64String((byte[])Eval("imagenActividad")) %>' />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass="btn btn-danger"  />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AtlantisConnectionString %>" DeleteCommand="BorrarActividad" DeleteCommandType="StoredProcedure" SelectCommand="ActividadesUsuario" SelectCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="idActividad" Type="Int32" />
            </DeleteParameters>
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="IdUsuario" SessionField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
      
    </div>
</asp:Content>
