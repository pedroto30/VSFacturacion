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
    public partial class frmCategoria : System.Web.UI.Page
    {
        private Categoria categoria = new Categoria();
        private void Listar()
        {
            gvCategoria.DataSource = categoria.Listar().Tables[0];
            gvCategoria.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nomcat = txtNombreCategoria.Text.Trim();
            string descrip = txtDescripcion.Text.Trim();
            categoria.Nom_c = nomcat;
            categoria.Descr = descrip;

            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (categoria.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + categoria.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idcat = int.Parse(txtidCategoria.Text.Trim());
            categoria.Id = idcat;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (categoria.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + categoria.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int idcat = int.Parse(txtidCategoria.Text.Trim());
            string nomcat = txtNombreCategoria.Text.Trim();
            string descrip = txtDescripcion.Text.Trim();
            categoria.Id = idcat;
            categoria.Nom_c = nomcat;
            categoria.Descr = descrip;

            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (categoria.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + categoria.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvCategoria.DataSource = categoria.Buscar(texto, criterio).Tables[0];
            gvCategoria.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}