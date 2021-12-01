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
    public partial class frmClienteNat : System.Web.UI.Page
    {
        private ClienteN clienten = new ClienteN();
        private void Listar()
        {
            gvClienteNat.DataSource = clienten.Listar().Tables[0];
            gvClienteNat.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string nom = txtNombres.Text.Trim();
            string ape = txtApellidos.Text.Trim();
            string tele = txtTelefono.Text.Trim();
            string dir = txtDireccion.Text.Trim();
            string email = txtEmail.Text.Trim();
            clienten.Dni1 = dni;
            clienten.Nomb = nom;
            clienten.Ape = ape;
            clienten.Tel = tele;
            clienten.Dir = dir;
            clienten.Email = email;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (clienten.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + clienten.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string ruc = txtDNI.Text.Trim();
            clienten.Dni1 = ruc;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (clienten.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + clienten.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string nom = txtNombres.Text.Trim();
            string ape = txtApellidos.Text.Trim();
            string tele = txtTelefono.Text.Trim();
            string dir = txtDireccion.Text.Trim();
            string email = txtEmail.Text.Trim();
            clienten.Dni1 = dni;
            clienten.Nomb = nom;
            clienten.Ape = ape;
            clienten.Tel = tele;
            clienten.Dir = dir;
            clienten.Email = email;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (clienten.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + clienten.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvClienteNat.DataSource = clienten.Buscar(texto, criterio).Tables[0];
            gvClienteNat.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}