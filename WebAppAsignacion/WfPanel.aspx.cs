using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAsignacion
{
    public partial class WfPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script language=javascript>alert('Trabajando!!!!!!');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            //Button2.Attributes.Add("onclick", "return confirm('¿desea ir a estos datos?')");
            Response.Redirect("Mantenimiento.aspx?"); 
        }
    }
}