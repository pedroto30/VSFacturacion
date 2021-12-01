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

    public partial class frmEmpresa : System.Web.UI.Page
    {
        private Empresa empresa = new Empresa();
        private void Listar()
        {
            gvEmpresa.DataSource = empresa.Listar().Tables[0];
            gvEmpresa.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string rucemp = txtRucEmpresa.Text.Trim();
            string razsoc = txtRazonSocial.Text.Trim();
            string dir = txtDireccion.Text.Trim();
            string tel = txtTelefono.Text.Trim();
            string cel = TtxtCelular.Text.Trim();
            string email = txtEmail.Text.Trim();
            string dueno = txtPropietario.Text.Trim();

            empresa.Ruc = rucemp;
            empresa.Raz_soc = razsoc;
            empresa.Dir = dir;
            empresa.Tel = tel;
            empresa.Cel = cel;
            empresa.Email = email;
            empresa.Propieta = dueno;

            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (empresa.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + empresa.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtRucEmpresa.Text.Trim();
            empresa.Ruc = id;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (empresa.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + empresa.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string rucemp = txtRucEmpresa.Text.Trim();
            string razsoc = txtRazonSocial.Text.Trim();
            string dir = txtDireccion.Text.Trim();
            string tel = txtTelefono.Text.Trim();
            string cel = TtxtCelular.Text.Trim();
            string email = txtEmail.Text.Trim();
            string dueno = txtPropietario.Text.Trim();

            empresa.Ruc = rucemp;
            empresa.Raz_soc = razsoc;
            empresa.Dir = dir;
            empresa.Tel = tel;
            empresa.Cel = cel;
            empresa.Email = email;
            empresa.Propieta = dueno;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (empresa.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + empresa.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvEmpresa.DataSource = empresa.Buscar(texto, criterio).Tables[0];
            gvEmpresa.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}