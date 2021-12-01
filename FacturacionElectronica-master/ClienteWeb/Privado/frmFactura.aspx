<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmFactura.aspx.cs" Inherits="ClienteWeb.Privado.frmFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" /><!-- Etiqueta para adaptar a @media -->
    <LINK REL="stylesheet" TYPE="text/css" HREF="../Estilos/Estilos.css"><!-- Enlace hoja estilos -->
     <%--<link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet">--%>
    <script src="../Scripts/Jsutil.js"></script>
    <script>
        function Limpiar()
        {
            data.txtId.value = "";
            data.txtSubTotal.value = "";
            data.txtTotal.value = "";
            data.txtNombres.value = "";
            data.txtTelefono.value = "";
            data.txtDireccion.value = "";
            
        }
    </script>
    <p></p>
    <h1>CRUD DE LA TABLA FACTURA</h1>
    
        <%-- FORMULARIO --%>
            
            <p>
                <%--IdFactura--%>
                <asp:Label ID="IdFactura" runat="server" Text="ID_Factura:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control"  />
            </p>
            <p>
             <%--IdTrabajador:--%>
            <asp:Label ID="lblID_Trabajador" runat="server" Text="Seleccione Trabajador:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlIdTrabajador" Width="192px" CssClass="form-control" >
                
            </asp:DropDownList>
            </p>
            <p>
           <%--IdLocal:--%>
            <asp:Label ID="lblLocal" runat="server" Text="Seleccione Local:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlIdLocal" Width="192px" CssClass="form-control" >
                
            </asp:DropDownList>
            </p></p>
                <%--Fecha--%>
                <asp:Button Text="Calendar" runat="server" ID="btnCalendar" Style="background-image:url('../Content/img/new.png'); background-repeat:no-repeat" OnClick="btnCalendar_Click" />
                <asp:Calendar ID="cFecha" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="cFecha_SelectionChanged" Width="220px">
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
</asp:Calendar>
                <asp:TextBox runat="server" ID="txtCalendar"/>
            <p></p>
                <%--SubTotal:--%>
                <asp:Label ID="lblSubTotal" runat="server" Text="SubTotal:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtSubTotal" CssClass="form-control"/>
            
            <p>
                <%--Total:--%>
                <asp:Label ID="lblTotal" runat="server" Text="Total:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtTotal" CssClass="form-control"/>
            </p>
            <p>
                <%--IGV:--%>
                <asp:Label ID="lblIGV" runat="server" Text="IGV:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtIGV" CssClass="form-control"/>
            </p>
            <p>
                <%--Descuento:--%>
                <asp:Label ID="lblDescuento" runat="server" Text="Descuento:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtDescuento" CssClass="form-control"/>
            </p>
            <p>
                <%--%:--%>
                <asp:Label ID="Label1" runat="server" Text="Descuento %:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtDescuentopor" CssClass="form-control"/>
            </p>
            <p>
                <%--RUC_Cliente:--%>
                <asp:Label ID="lblCliente" runat="server" Text="RUC Cliente:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtRucCliente" CssClass="form-control"/>
                <a data-toggle="modal" href="#myModal" class="btn btn-primary btn-lg">Buscar Cliente</a>
            </p>
            <%-- MOdal ventana Emergente --%> 
            <div id="myModal" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModal" aria-hidden="true">
                <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLongTitle">Buscar Cliente</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">×</span>
                        </button>
                        </div>
                        <div class="modal-body">
                            
                            <%--Buscar:--%>
                            <asp:Label ID="Label2" runat="server" Text="Campo a Buscar:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                            <asp:TextBox runat="server" ID="txtClientej" CssClass="form-control" />
                            <asp:Label ID="Label3" runat="server" Text="Criterio de Busqueda:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlClienteJ" Height="36px" Width="192px" CssClass="form-control">
                            <asp:ListItem Text="RUC" />
                            <asp:ListItem Text="Razon_Social" />
                            </asp:DropDownList>
                            <p></p>
                            <asp:Button Text="Buscar Cliente" runat="server" ID="btnBuscarCliente" OnClick="btnBuscarCliente_Click" Style="background-image:url('../Content/img/buscar.png'); background-repeat:no-repeat" OnDataBinding="btnBuscarCliente_Click"/>
                            <p></p>
                            <asp:GridView runat="server" ID="gvClientej1" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#00CC00" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" Width="100%">
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="Green" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                            <asp:DropDownList runat="server" ID="ddlBuscarCliente" Height="36px" Width="192px" CssClass="form-control">
                            
                            </asp:DropDownList>
                            <%-- Fin buscar --%>
                            
                        </div>
      <         <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                <button type="button" class="btn btn-primary" id="btnSeleccionar" onclick="btnSeleccionar_Click">Seleccionar</button>
                </div>
                </div>
              </div>
            </div>
            <%--fin modal--%>           
                
                
            <p>
                <asp:Label ID="lblCliente1" runat="server" Text="Seleccione Cliente:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:DropDownList runat="server" ID="ddlBuscarCliente1" Height="36px" Width="192px" CssClass="form-control">
                </asp:DropDownList>
            </p>   

            <p>
                <%--RucEmpresa:--%>
                <asp:Label ID="lblEmpresa" runat="server" Text="Seleccione Empresa:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:DropDownList runat="server" ID="ddlEmpresaRuc" Width="192px" CssClass="form-control" >
                
                </asp:DropDownList>
                </p>
            <p>
            <asp:Button Text="Nuevo" runat="server" ID="btnNuevo" Style="background-image:url('../Content/img/new.png'); background-repeat:no-repeat" />
            <asp:Button Text="Agregar" runat="server" ID="btnAgregar" Style="background-image:url('../Content/img/save.png'); background-repeat:no-repeat" OnClick="btnAgregar_Click" />
            <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" Style="background-image:url('../Content/img/delete.png'); background-repeat:no-repeat" OnClick="btnEliminar_Click" />
            <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" Style="background-image:url('../Content/img/refresh.png'); background-repeat:no-repeat" OnClick="btnActualizar_Click" />
            
        </p>
        <p>
            <%--Buscar:--%>
            <asp:Label ID="lblBuscar" runat="server" Text="Campo a Buscar:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control" />
            <asp:Label ID="lblCriterio" runat="server" Text="Criterio de Busqueda:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlCriterio" Height="36px" Width="192px" CssClass="form-control">
                <asp:ListItem Text="Id" />
                <asp:ListItem Text="Fecha" />
            </asp:DropDownList>
            <p></p>
            <asp:Button Text="Buscar" runat="server" ID="btnBuscar" Style="background-image:url('../Content/img/buscar.png'); background-repeat:no-repeat" OnClick="btnBuscar_Click"/>
            
        
        <p>
            <asp:GridView runat="server" ID="gvFactura" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#00CC00" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" Width="100%">
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="Green" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <p>
                
            
        </p>
</asp:Content>
