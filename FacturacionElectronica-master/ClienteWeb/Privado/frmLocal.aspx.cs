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
    public partial class frmLocal : System.Web.UI.Page
    {
        private Local local = new Local();
        private void Listar()
        {
            gvLocal.DataSource = local.Listar().Tables[0];
            gvLocal.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nomblocal = txtNombreLocal.Text.Trim();
            string tel = txtTelefono.Text.Trim();
            string dir = txtDireccion.Text.Trim();

            local.Nom_l = nomblocal;
            local.Tel = tel;
            local.Dir = dir;

            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (local.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + local.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idlocal = int.Parse(txtidLocal.Text.Trim());
            local.Id = idlocal;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (local.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + local.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int idlocal = int.Parse(txtidLocal.Text.Trim());
            string nomblocal = txtNombreLocal.Text.Trim();
            string tel = txtTelefono.Text.Trim();
            string dir = txtDireccion.Text.Trim();

            local.Id = idlocal;
            local.Nom_l = nomblocal;
            local.Tel = tel;
            local.Dir = dir;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (local.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + local.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvLocal.DataSource = local.Buscar(texto, criterio).Tables[0];
            gvLocal.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}