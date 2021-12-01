<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmUsuarios.aspx.cs" Inherits="ClienteWeb.Privado.frmUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" /><!-- Etiqueta para adaptar a @media -->
    <LINK REL="stylesheet" TYPE="text/css" HREF="../Estilos/Estilos.css"><!-- Enlace hoja estilos -->
     <%--<link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet">--%>
    <script>
        function Limpiar()
        {
            data.txtId.value = "";
            data.txtIdUsuario.value = "";
            data.txtcontrasena.value = "";
            data.txtcontrasena1.value = "";
        }
    </script>
    <p></p>
    <h1>CRUD DE LA TABLA USUARIO</h1>
        <formview id="data" runat="server">
        <%-- FORMULARIO --%>
        <p>
                
                <%--Id:--%>
                <asp:Label ID="lblId" runat="server" Text="Id:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control"  />
            </p>
            <p>
                <%--Id_USuario:--%>
                <asp:Label ID="lblIdUSuario" runat="server" Text="Id-Usuario:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtIdUsuario" CssClass="form-control"/>
            </p>
            <p>
                <%--Contraseña:--%>
                <asp:Label ID="lblContraseña" runat="server" Text="Contraseña:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtcontrasena" CssClass="form-control" TextMode="Password" ValidationGroup="A"/>
            </p>
    <p>
                <%--Contraseña02:--%>        
                <asp:Label ID="Label1" runat="server" Text="Reingrese Contraseña :" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
                <asp:TextBox runat="server" ID="txtcontrasena1" CssClass="form-control" TextMode="Password" ValidationGroup="A"/>
            </p>
           
        <p>
            <asp:Button Text="Nuevo" runat="server" ID="btnNuevo" Style="background-image:url('../Content/img/new.png'); background-repeat:no-repeat" OnClientClick="Limpiar()"/>
            <asp:Button Text="Agregar" runat="server" ID="btnAgregar" ValidationGroup="A" Style="background-image:url('../Content/img/save.png'); background-repeat:no-repeat" OnClick="btnAgregar_Click" />
            <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" Style="background-image:url('../Content/img/delete.png'); background-repeat:no-repeat" OnClick="btnEliminar_Click"  />
            <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" Style="background-image:url('../Content/img/refresh.png'); background-repeat:no-repeat" OnClick="btnActualizar_Click"/>
            
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Los Valores no coinciden " ControlToCompare="txtcontrasena" ControlToValidate="txtcontrasena1" ForeColor="Red" ValidationGroup="A">*</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIdUsuario" ErrorMessage="Ingrese Campos" ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcontrasena" ErrorMessage="Ingrese Campos " ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="A" />
        <p>
            <%--Buscar:--%>
            <asp:Label ID="lblBuscar" runat="server" Text="Campo a Buscar:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control" />
            <asp:Label ID="lblCriterio" runat="server" Text="Criterio de Busqueda:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlCriterio" Height="36px" Width="192px" CssClass="form-control">
                <asp:ListItem Text="Id" />
                <asp:ListItem Text="Id_Usuario" />
            </asp:DropDownList>
            <p></p>
            <asp:Button Text="Buscar" runat="server" ID="btnBuscar" Style="background-image:url('../Content/img/buscar.png'); background-repeat:no-repeat" OnClick="btnBuscar_Click"  />
            
        
        <p>
            <asp:GridView runat="server" ID="gvUsuario" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#00CC00" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" Width="535px">
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
            
              
            
        </p>
</formview>
</asp:Content>
