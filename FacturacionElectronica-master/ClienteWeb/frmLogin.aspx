<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="ClienteWeb.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" /><!-- Etiqueta para adaptar a @media -->
    <LINK REL="stylesheet" TYPE="text/css" HREF="Estilos/Estilos.css"><!-- Enlace hoja estilos -->
     <%--<link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet">--%>
    <p></p>
    <h1>LOGUEO</h1>
     <%-- FORMULARIO --%>
    
    <p>
         <%--Id_USuario:--%>
        <asp:Label ID="lblCodigo" runat="server" Text="Usuario:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
        <asp:TextBox runat="server" Id="txtIdusuario" CssClass="form-control"/>   
        <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtIdusuario" ErrorMessage="¡Usuario Requerido!!!!" ValidationGroup="A" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <%--Contraseña:--%>
        <asp:Label ID="Label1" runat="server" Text="Contraseña:" CssClass="form-label col-sm-3" Font-Size="Medium"></asp:Label>
        <asp:TextBox runat="server" Id="txtContraseña" TextMode="Password" CssClass="form-control"/>
        <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ControlToValidate="txtContraseña" ErrorMessage="¡Contraseña requerida!!!" ValidationGroup="A" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:button Text="Ingresar" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" ValidationGroup="A" Width="330px" /></p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="A" />

    

</asp:Content>
