using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAsignacion
{
    public partial class Mantenimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            listarEquipos();
        }

        void listarEquipos()
        {
            ServicioEquipos.EquipoServiceClient proxy = new ServicioEquipos.EquipoServiceClient();

            gvdatos.DataSource = proxy.ListarEquipos();

            gvdatos.DataBind();

            proxy = null;
        }

        protected void Paginar(object sender, GridViewPageEventArgs e)
        {
            gvdatos.PageIndex = e.NewPageIndex;
            listarEquipos();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("WfPanel.aspx?");
        }

    

       

      

       
    }
}