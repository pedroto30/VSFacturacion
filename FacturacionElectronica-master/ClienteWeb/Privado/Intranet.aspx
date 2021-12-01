<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intranet.aspx.cs" Inherits="ClienteWeb.Privado.Intranet" %>

<!DOCTYPE html>
<link rel="stylesheet" TYPE="text/css" href="../lib/twitter-bootstrap/css/StyleSheet1.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <%--<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">--%>
    <%-- Cambiooo librerias locales bootstrap --%>
    <link href="../lib/twitter-bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../lib/twitter-bootstrap/css/style.css" rel="stylesheet" />
    <%-- Linck de Iconos --%>
    <%--<link href="https://unpkg.com/ionicons@4.5.10-0/dist/css/ionicons.min.css" rel="stylesheet">--%>
    <%-- Linck de Fonts --%>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" /><!-- Etiqueta para adaptar a @media -->
    <link href="../lib/twitter-bootstrap/css/Estilos.css" rel="stylesheet" /><!-- Enlace hoja estilos -->
</head>
  <body>
      <form id="form1" runat="server">
      <%-- Inicio menu lateral derecho bootstrap --%>
      <div class="d-flex">
          <div id="sidebar-container" class="bg-primary">
              <div class="logo">
                  <h4 class="text-light font-weight-bold" >Menu</h4>
              </div>
              <div class="menu">
                  <a href="frmUsuarios.aspx" target="formularios" class="d-block text-light p-2"><img src="../Content/img/Usuariow.png" class="mr-2" />Usuarios</a>
                  <a href="frmTrabajador.aspx" target="formularios" class="d-block text-light p-2"><img src="../Content/img/trabajadorw.png" class="mr-2"/>Trabajador</a>
                  <a href="frmCategoria.aspx" target="formularios" class="d-block text-light p-2"><img src="../Content/img/catew.png" class="mr-2"/>Categoria</a>
                  <a href="frmProducto.aspx" target="formularios" class="d-block text-light p-2"><img src="../Content/img/productow.png" class="mr-2"/>Producto</a>
                  <a href="frmEmpresa.aspx" target="formularios" class="d-block text-light p-2"><img src="../Content/img/emprew.png" class="mr-2"/>Empresa</a>
                  <a href="frmLocal.aspx" target="formularios" class="d-block text-light p-2"><img src="../Content/img/localw.png" class="mr-2"/>Local</a>
                  <a href="frmFactura" target="formularios" class="d-block text-light p-2"><img src="../Content/img/facturaw.png" class="mr-2"/>Factura</a>
                  <a href="frmBoleta" target="formularios" class="d-block text-light p-2"><img src="../Content/img/bolew.png" class="mr-2"/>Boleta</a>
                  <a href="frmClienteRuc" target="formularios" class="d-block text-light p-2"><img src="../Content/img/clienteRucw.png" class="mr-2"/>Cliente RUC</a>
                  <a href="frmClienteNat" target="formularios" class="d-block text-light p-2"><img src="../Content/img/clientew.png" class="mr-2"/>Cliente Boleta</a>
              </div>
          </div>
   <%-- Inicio navegador de Busqueda Boostrap --%>
  <div class="w-100">
  <nav class="navbar navbar-expand-lg navbar-light bg-light border-bottom">
  <div class="container">
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" 
      aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <button class="btn btn-search popover-header" type="submit"><img src="../Content/img/buscar16.png" class="mr-2"/></button>
  <input class="form-control ml-sm-2" type="search" placeholder="Buscar" aria-label="Buscar">
  <img src="../Content/img/Usuario.png" class="img-fluid rounded-circle avatar mr-2"/>  
  <asp:LoginName id="LoginName1" runat="server" FormatString ="Bienvenido... {0}" />  
  </div>
  </nav>
  <%-- Fin navegador de Busqueda Boostrap --%>
  <%-- Iframe de carga de paginas web --%>  
      <iframe style="height:100%; width:99%" name="formularios"  onscroll=""/> 
      <div id="content">
      </div>
</div>
           
          
  <%-- Fin Navegador Busqueda Boostrap --%>
</div>
 <%-- Fin menu lateral derecho bootstrap --%>    

    <!-- Optional JavaScript; choose one of the two! -->

    <!-- Option 1: Bootstrap Bundle with Popper -->
    <%--<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>--%>
    <%-- Cambiooo --%>
    <script src="../lib/twitter-bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Option 2: Separate Popper and Bootstrap JS -->
    <!--
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    -->
      </form>
  </body>
</html>
