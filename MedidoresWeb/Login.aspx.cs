using MedidoresDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            TrabajadorDAL trabajadorDAL = new TrabajadorDAL();

            bool bandera=trabajadorDAL.VerificarLogin(txtCorreo.Text, txtPassword.Text);
            if (bandera)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMensaje.Text = "Correo o contraseña incorrectas";
            }
        }
    }
}