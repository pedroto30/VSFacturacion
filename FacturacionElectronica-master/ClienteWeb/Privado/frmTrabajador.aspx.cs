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
    public partial class frmTrabajador : System.Web.UI.Page
    {
        private Trabajador trabajador = new Trabajador();
        private Usuario usuario = new Usuario();
        private void Listar()
        {
            gvTrabajador.DataSource = trabajador.Listar().Tables[0];
            gvTrabajador.DataBind();
            CargarDatos(ddlIdUsuario);
        }
        private void CargarDatos(DropDownList ddlIdUsuario1)
        {
            ddlIdUsuario1.DataSource = usuario.Listar();
            ddlIdUsuario1.DataValueField = "ID_U";
            ddlIdUsuario1.DataTextField = "IdUsuario";
            ddlIdUsuario1.DataBind();
            ddlIdUsuario1.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string roltra = ddlRolT.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string genero = ddlGenero.Text.Trim();
            int idusuario = int.Parse(ddlIdUsuario.SelectedValue.Trim());

            trabajador.Dni = dni;
            trabajador.Ape = apellidos;
            trabajador.Nom = nombres;
            trabajador.Rol = roltra;
            trabajador.Tel = telefono;
            trabajador.Dir = direccion;
            trabajador.Gene = genero;
            trabajador.Id_u = idusuario;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (trabajador.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + trabajador.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            trabajador.Id = id;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (trabajador.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + trabajador.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int idt = int.Parse(txtId.Text.Trim());
            string dni = txtDNI.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string roltra = ddlRolT.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string genero = ddlGenero.Text.Trim();
            int idusuario = int.Parse(ddlIdUsuario.SelectedValue.Trim());

            trabajador.Id = idt;
            trabajador.Dni = dni;
            trabajador.Ape = apellidos;
            trabajador.Nom = nombres;
            trabajador.Rol = roltra;
            trabajador.Tel = telefono;
            trabajador.Dir = direccion;
            trabajador.Gene = genero;
            trabajador.Id_u = idusuario;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (trabajador.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + trabajador.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvTrabajador.DataSource = trabajador.Buscar(texto, criterio).Tables[0];
            gvTrabajador.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}