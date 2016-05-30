using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAsignacion
{
    public partial class Solicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listarColaboradorXPendiente();
        }

        void listarColaboradorXPendiente()
        {
            ServicioColaborador.ColaboradorServiceClient proxy = new ServicioColaborador.ColaboradorServiceClient();

            gvColaborador.DataSource = proxy.ListarColaboradorXPendiente();

            gvColaborador.DataBind();

            proxy = null;
        }

        protected void Paginar(object sender, GridViewPageEventArgs e)
        {
            gvColaborador.PageIndex = e.NewPageIndex;
            listarColaboradorXPendiente();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("WfPanel.aspx?");
        }
    }
}