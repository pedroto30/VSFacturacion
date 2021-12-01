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
    public partial class frmUsuarios : System.Web.UI.Page
    {
        private Usuario usuario = new Usuario();
        private void Listar()
        {
            gvUsuario.DataSource = usuario.Listar().Tables[0];
            gvUsuario.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string Idusuario = txtIdUsuario.Text.Trim();
            string pass = txtcontrasena.Text.Trim();
            usuario.Idusu1 = Idusuario;
            usuario.Contra = pass;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (usuario.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + usuario.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            string Idusuario = txtIdUsuario.Text.Trim();
            usuario.Id = id;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (usuario.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + usuario.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int idu = int.Parse(txtId.Text.Trim());
            string Idusuario = txtIdUsuario.Text.Trim();
            string pass = txtcontrasena.Text.Trim();

            usuario.Id = idu;
            usuario.Idusu1 = Idusuario;
            usuario.Contra = pass;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (usuario.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + usuario.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvUsuario.DataSource = usuario.Buscar(texto, criterio).Tables[0];
            gvUsuario.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}