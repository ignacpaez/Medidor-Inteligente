using MedidoresDAL;
using MedidoresDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class CrearDirecciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Region> regiones = new RegionesDAL().GetAll();
                List<Cliente> clientes = new ClientesDAL().GetAll();
                List<Medidor> medidores = new MedidorDAL().GetAll();
                ddlRegion.DataSource = regiones;
                ddlRegion.DataValueField = "CodigoRegion";
                ddlRegion.DataTextField = "Nombre";
                ddlRegion.DataBind();
                ddlCliente.DataSource = clientes;
                ddlCliente.DataTextField = "Codigo";
                ddlCliente.DataBind();
                ddlMedidor.DataSource = medidores;
                ddlMedidor.DataTextField = "Id";
                ddlMedidor.DataBind();

                
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCrearDir_Click(object sender, EventArgs e)
        {
            DireccionesDAL dirDal = new DireccionesDAL();
            string descripcion = txtDescripcion.Text;
            int numero = Convert.ToInt32(txtNumero.Text);
            string codigoRegion = ddlRegion.SelectedValue;
            string codigoCliente = ddlCliente.SelectedValue;
            int idMedidor = Convert.ToInt32(ddlMedidor.SelectedValue);

            Direccion d = new Direccion();
            d.Descripcion = descripcion;
            d.Numero = numero;
            d.CodigoRegion = codigoRegion;
            d.CodigoCliente = codigoCliente;
            d.IdMedidor = idMedidor;

            if (dirDal.Add(d))
            {
                lblMensaje.CssClass = "text-success h1";
                lblMensaje.Text = "Direccion Ingresada";
                txtDescripcion.Text = "";
                txtNumero.Text =null;
            }
            else
            {
                lblMensaje.CssClass = "text-danger h1";
                lblMensaje.Text = "Direccion no ingresada";
                txtDescripcion.Text = "";
                txtNumero.Text = null;
            }

        }
    }
}