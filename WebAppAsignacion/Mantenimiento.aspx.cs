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
            try
            {
                ServicioEquipos.EquipoServiceClient proxy = new ServicioEquipos.EquipoServiceClient();

                gvEquipos.DataSource = proxy.ListarEquipos();

                gvEquipos.DataBind();

                proxy = null;
            }
            catch
            {
                Response.Write("<script language=javascript>alert('Se ha producido un grave error');</script>");
            }
        }

        protected void Paginar(object sender, GridViewPageEventArgs e)
        {
            gvEquipos.PageIndex = e.NewPageIndex;
            listarEquipos();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("WfPanel.aspx?");
        }

    

       

      

       
    }
}