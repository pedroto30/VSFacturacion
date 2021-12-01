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
    public partial class frmFactura : System.Web.UI.Page
    {
        private Factura factura = new Factura();
        private Trabajador trabajador = new Trabajador();
        private Local local = new Local();
        private ClienteJ clientej = new ClienteJ();
        private Empresa empresa = new Empresa();

        private void Listar()
        {
            gvFactura.DataSource = factura.Listar().Tables[0];
            gvFactura.DataBind();
            CargarTrabajador(ddlIdTrabajador);
            CargarLocal(ddlIdLocal);
            CargarCliente(ddlBuscarCliente);
            CargarCliente1(ddlBuscarCliente1);
            CargarEmpresa(ddlEmpresaRuc);
        }
        private void CargarTrabajador(DropDownList ddlId1)
        {
            ddlId1.DataSource = trabajador.Listar();
            ddlId1.DataValueField = "ID_T";
            ddlId1.DataTextField = "Apellidos";
            ddlId1.DataBind();
            ddlId1.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }
        private void CargarLocal(DropDownList ddlId2)
        {
            ddlId2.DataSource = local.Listar();
            ddlId2.DataValueField = "ID_L";
            ddlId2.DataTextField = "NombreLocal";
            ddlId2.DataBind();
            ddlId2.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }
        private void CargarCliente(DropDownList ddlId4)
        {
            ddlId4.DataSource = clientej.Listar();
            ddlId4.DataValueField = "RUC_CJ";
            ddlId4.DataTextField = "Razon_Social";
            ddlId4.DataBind();
            ddlId4.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }
        private void CargarCliente1(DropDownList ddlId5)
        {
            ddlId5.DataSource = clientej.Listar();
            ddlId5.DataValueField = "RUC_CJ";
            ddlId5.DataTextField = "Razon_Social";
            ddlId5.DataBind();
            ddlId5.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }
        private void CargarEmpresa(DropDownList ddlId3)
        {
            ddlId3.DataSource = empresa.Listar();
            ddlId3.DataValueField = "RucEmpresa";
            ddlId3.DataTextField = "RazonSocial";
            ddlId3.DataBind();
            ddlId3.Items.Insert(0, new ListItem("Seleccione...", "0"));
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
                cFecha.Visible = false;
        }

        

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtClientej.Text.Trim();
            string criterio = ddlClienteJ.SelectedValue;
            gvClientej1.DataSource = clientej.Buscar(texto, criterio).Tables[0];
            gvClientej1.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal ValorIGV = Convert.ToDecimal(0.18);
            txtIGV.Text = "ValorIGV";
            int idtrab = int.Parse(ddlIdTrabajador.SelectedValue.Trim());
            int idlocal = int.Parse(ddlIdLocal.SelectedValue.Trim());
            DateTime fecha = DateTime.Parse(txtCalendar.Text.Trim());
            decimal subt = decimal.Parse(txtSubTotal.Text.Trim());
            txtTotal.Enabled = false;
            decimal total = decimal.Parse(txtTotal.Text.Trim());
            txtIGV.Enabled = false;
            decimal igv = decimal.Parse(txtIGV.Text.Trim());
            decimal desc = decimal.Parse(txtDescuento.Text.Trim());
            decimal pordesct = decimal.Parse(txtDescuentopor.Text.Trim());
            decimal sstotal = Convert.ToDecimal((ValorIGV * subt) + subt);
            string clienteruc = ddlBuscarCliente1.SelectedValue.Trim();
            string rucempresa = ddlEmpresaRuc.SelectedValue.Trim();
            decimal ttotal1 = Convert.ToDecimal((sstotal * pordesct) - sstotal);
            
            factura.Id_t = idtrab;
            factura.Id_l = idlocal;
            factura.Fecha = fecha;
            factura.Subt = subt;
            factura.Tot = ttotal1;
            factura.Igv = igv;
            factura.Desc = desc;
            factura.Por_desc = pordesct;
            factura.RucCJ1 = rucempresa;
            factura.RucEmp1 = rucempresa;
            
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (factura.Agregar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + factura.Mensaje + "');</script>");
        }

        protected void btnCalendar_Click(object sender, EventArgs e)
        {
            cFecha.Visible = !cFecha.Visible;
        }

        protected void cFecha_SelectionChanged(object sender, EventArgs e)
        {
            //txtCalendar.Text = cFecha.SelectedDate.ToString();
            txtCalendar.Text = cFecha.SelectedDate.ToShortDateString();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string idfat = txtId.Text.Trim();
            factura.Id_f = idfat;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (factura.Eliminar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + factura.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string idfact = txtId.Text.Trim();
            decimal ValorIGV = Convert.ToDecimal(0.18);
            txtIGV.Text = "ValorIGV";
            int idtrab = int.Parse(ddlIdTrabajador.SelectedValue.Trim());
            int idlocal = int.Parse(ddlIdLocal.SelectedValue.Trim());
            DateTime fecha = DateTime.Parse(txtCalendar.Text.Trim());
            decimal subt = decimal.Parse(txtSubTotal.Text.Trim());
            txtTotal.Enabled = false;
            decimal total = decimal.Parse(txtTotal.Text.Trim());
            txtIGV.Enabled = false;
            decimal igv = decimal.Parse(txtIGV.Text.Trim());
            decimal desc = decimal.Parse(txtDescuento.Text.Trim());
            decimal pordesct = decimal.Parse(txtDescuentopor.Text.Trim());
            decimal sstotal = Convert.ToDecimal((ValorIGV * subt) + subt);
            string clienteruc = ddlBuscarCliente1.SelectedValue.Trim();
            string rucempresa = ddlEmpresaRuc.SelectedValue.Trim();
            decimal ttotal1 = Convert.ToDecimal((sstotal * pordesct) - sstotal);

            factura.Id_f = idfact;
            factura.Id_t = idtrab;
            factura.Id_l = idlocal;
            factura.Fecha = fecha;
            factura.Subt = subt;
            factura.Tot = ttotal1;
            factura.Igv = igv;
            factura.Desc = desc;
            factura.Por_desc = pordesct;
            factura.RucCJ1 = rucempresa;
            factura.RucEmp1 = rucempresa;
            // Llamamos a agregar y este es un (bool true y false), Pero tb deviuelve un valor de mensaje
            if (factura.Actualizar() == true)
                Listar();
            // Mostrar el mensaje del PA
            Response.Write("<script>alert('" + factura.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // capturamos las caja de texto 
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvFactura.DataSource = factura.Buscar(texto, criterio).Tables[0];
            gvFactura.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Intranet.aspx");
        }
    }
}