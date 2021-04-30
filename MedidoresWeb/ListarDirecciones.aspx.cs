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
    public partial class ListarDirecciones : System.Web.UI.Page
    {
        private void CargarTabla(List<Direccion> listaDirecciones)
        {
            GridDirecciones.DataSource = listaDirecciones;
            GridDirecciones.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {               
                CargarTabla(new DireccionesDAL().GetAll());
            }
        }
    }
}