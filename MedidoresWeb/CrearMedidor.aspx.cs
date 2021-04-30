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
    public partial class CrearMedidor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            //Se ejecuta SOLO la primera vez
            if (!IsPostBack)
            {
                txtIdentificador.Text = "";
                
            }
        }

        protected void ID_CV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string ID = txtIdentificador.Text.Trim();
            if (ID == string.Empty)
            {
                ID_CV.ErrorMessage = "Debe Ingresar el identificador";
                args.IsValid = false;
            }
            else
            {
                
                if (ID.Length != 7)
                {
                    ID_CV.ErrorMessage = "El identificador debe tener un largo de 7 caracteres";
                            
                    args.IsValid = false;
                    
                }
                else
                {
                    args.IsValid = true;
                }
            }
        }

        protected void btnCrearMedidor_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int identificador = Convert.ToInt32(txtIdentificador.Text.Trim());
                string tipo = rblTipo.SelectedValue;
                Medidor m = new Medidor();
                m.Id = identificador;
                m.Tipo = tipo;
                MedidorDAL medidorDAL = new MedidorDAL();
                medidorDAL.Add(m);
                lblMensaje.Text = "Medidor Ingresado";
            }
            
        }
    }
}