using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Manejo de Seguridad de entorno web 
using System.Web.Security;
//Llamamos a la capa negocio
using CapaNegocio;
//Bufer de Memoria
using System.Data;

namespace ClienteWeb
{
    public partial class frmLogin : System.Web.UI.Page
    {
        private Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usu = txtIdusuario.Text.Trim();
            string Pws = txtContraseña.Text.Trim();
            usuario.Idusu1 = Usu;
            usuario.Contra = Pws;
            if (usuario.Login_User() == true)
            {
                FormsAuthentication.RedirectFromLoginPage(Usu, false);
                //mvEjemplo.ActiveViewIndex = 1;
                //Response.Redirect("frmMenu.aspx");
                Response.Write("<script>alert('" + usuario.Mensaje + "');</script>");
            }
            else
            { Response.Write("<script>alert('" + usuario.Mensaje + "');</script>"); }
        }
    }
}