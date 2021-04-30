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
    public partial class CrearCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                ClientesDAL clienteDAL= new ClientesDAL();
                
                string codigo = txtCodigoCliente.Text.Trim();
                string rut = txtRut.Text;
                string nombre = txtNombre.Text;
                string apellidoP = txtApellidoP.Text;
                string apellidoM = txtApellidoM.Text;
                string correo = txtCorreo.Text;

                Cliente c = new Cliente();
                c.Codigo = codigo;
                c.Rut = rut;
                c.Nombre = nombre;
                c.ApellidoPaterno = apellidoP;
                c.ApellidoMaterno = apellidoM;
                c.Correo = correo;

                if (clienteDAL.Add(c))
                {
                    lblMensaje.CssClass = "text-success h1";
                    lblMensaje.Text = "Cliente Ingresado";
                }
                else
                {
                    lblMensaje.CssClass = "text-danger h1";
                    lblMensaje.Text = "Cliente no ingresado";
                }
                
            }
        }
    }
}