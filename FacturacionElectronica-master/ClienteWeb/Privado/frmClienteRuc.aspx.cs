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
    public partial class frmClienteRuc : System.Web.UI.Page
    {
        private ClienteJ clientej = new ClienteJ();
        private void Listar()
        {
            gvClienteRuc.DataSource = clientej.Listar().Tables[0];
            gvClienteRuc.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            string ruc = txtRuc.Text.Trim();
            string razonsocial = txtRazonSocial.Text.Trim();
            string tele = txtTelefono.Text.Trim();
            string dir = txtDireccion.Text.Trim();
            string email = txtEmail.Text.Trim();
            clientej.Ruc1 = ruc;
            clientej.Raz_soc = razonsocial;
            clientej.Tel = tele;
            clientej.Dir = dir;
            clientej.Email = email;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (clientej.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + clientej.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string ruc = txtRuc.Text.Trim();
            clientej.Ruc1 = ruc;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (clientej.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + clientej.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string ruc = txtRuc.Text.Trim();
            string razonsocial = txtRazonSocial.Text.Trim();
            string tele = txtTelefono.Text.Trim();
            string dir = txtDireccion.Text.Trim();
            string email = txtEmail.Text.Trim();
            clientej.Ruc1 = ruc;
            clientej.Raz_soc = razonsocial;
            clientej.Tel = tele;
            clientej.Dir = dir;
            clientej.Email = email;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (clientej.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + clientej.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvClienteRuc.DataSource = clientej.Buscar(texto, criterio).Tables[0];
            gvClienteRuc.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}