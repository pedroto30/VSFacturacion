using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//llamamos a la capa negocio previa llamada de referencia 
using CapaNegocio;

namespace ClienteWeb.Privado
{
    public partial class frmProducto : System.Web.UI.Page
    {
        private Producto producto = new Producto();
        private Categoria categoria = new Categoria();
        private void Listar()
        {
            gvProducto.DataSource = producto.Listar().Tables[0];
            gvProducto.DataBind();
            CargarDatos(ddlIdCategoria);
        }
        private void CargarDatos(DropDownList ddlCategoria1)
        {
            ddlCategoria1.DataSource = categoria.Listar();
            ddlCategoria1.DataValueField = "ID_C";
            ddlCategoria1.DataTextField = "Descripcion";
            ddlCategoria1.DataBind();
            ddlCategoria1.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombprod = txtNombreProducto.Text.Trim();
            string descripprod = txtDescripcion.Text.Trim();
            decimal precio = decimal.Parse(txtPrecio.Text.Trim());
            int idcat = int.Parse(ddlIdCategoria.SelectedValue.Trim());
            //Response.Write(idcat.ToString());
            producto.Nom = nombprod;
            producto.Descrip = descripprod;
            producto.Precio = precio;
            producto.Id_c = idcat;

            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (producto.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + producto.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idprod = int.Parse(txtIdProducto.Text.Trim());
            producto.Id = idprod;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (producto.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + producto.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int idprod = int.Parse(txtIdProducto.Text.Trim());
            string nombprod = txtNombreProducto.Text.Trim();
            string descripprod = txtDescripcion.Text.Trim();
            decimal precio = decimal.Parse(txtPrecio.Text.Trim());
            int idcat = int.Parse(ddlIdCategoria.Text.Trim());

            producto.Id = idprod;
            producto.Nom = nombprod;
            producto.Descrip = descripprod;
            producto.Precio = precio;
            producto.Id_c = idcat;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (producto.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + producto.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvProducto.DataSource = producto.Buscar(texto, criterio).Tables[0];
            gvProducto.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}