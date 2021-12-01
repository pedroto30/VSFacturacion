<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmClienteRuc.aspx.cs" Inherits="ClienteWeb.Privado.frmClienteRuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" /><!-- Etiqueta para adaptar a @media -->
    <script src="../lib/twitter-bootstrap/js/jsutil.js"></script>
    <LINK REL="stylesheet" TYPE="text/css" HREF="../Estilos/Estilos.css"><!-- Enlace hoja estilos -->
     <%--<link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet">--%>
    <script src="../lib/twitter-bootstrap/js/jsutil.js"></script>
    <p></p>
    <h1>CRUD DE LA TABLA CLIENTE RUC</h1>
    
        <%-- FORMULARIO --%>
            
            <p>
                <%--RUC--%>
                <asp:Label ID="lblruc" runat="server" Text="RUC:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtRuc" CssClass="form-control" onKeyPress="return ValidartxtNumeros(event)" />
            </p>
            <p>
                
                <%--Razon Social--%>
                <asp:Label ID="lblRazonSocial" runat="server" Text="Razon Social:" CssClass="form-label col-sm-3" Font-Size="Medium" ></asp:Label>
                <asp:TextBox runat="server" ID="txtRazonSocial" CssClass="form-control"/>
            </p>
    <p>
                <%--Telefono:--%>
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" onKeyPress="return ValidartxtNumeros(event)" />
            </p>
            <p>
                <%--Dirección:--%>        
                <asp:Label ID="lblDireccion" runat="server" Text="Dirección:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"/>
            </p>
            <p>
                <%--E_mail:--%>
                <asp:Label ID="lblEmail" runat="server" Text="E_mail:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"/>
            </p>
        <p>
            <asp:Button Text="Nuevo" runat="server" ID="btnNuevo" Style="background-image:url('../Content/img/new.png'); background-repeat:no-repeat" OnClientClick="Limpiar()"/>
            <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click1" Style="background-image:url('../Content/img/save.png'); background-repeat:no-repeat" />
            <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" Style="background-image:url('../Content/img/delete.png'); background-repeat:no-repeat" />
            <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" Style="background-image:url('../Content/img/refresh.png'); background-repeat:no-repeat" />
            
        </p>
        <p>
            <%--Buscar:--%>
            <asp:Label ID="lblBuscar" runat="server" Text="Campo a Buscar:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control" />
            <asp:Label ID="lblCriterio" runat="server" Text="Criterio de Busqueda:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlCriterio" Height="36px" Width="192px" CssClass="form-control">
                <asp:ListItem Text="RUC" />
                <asp:ListItem Text="Razon_Social" />
            </asp:DropDownList>
            <p></p>
            <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" Style="background-image:url('../Content/img/buscar.png'); background-repeat:no-repeat"/>
            
        
        <p>
            <asp:GridView runat="server" ID="gvClienteRuc" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#00CC00" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" Width="100%">
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
