using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAsignacion
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        public static string str_equipo;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarEquiposKey();
        }


        void cargarEquiposKey()
        {
            try
            {
                str_equipo = Request.QueryString["id"];

                ServicioEquipos.EquipoServiceClient proxy = new ServicioEquipos.EquipoServiceClient();

                ServicioEquipos.Equipos equipo = proxy.ObtenerEquipos(str_equipo);


                lblCodigox.Text = Convert.ToString(equipo.Id);
                lblNombrex.Text = Convert.ToString(equipo.Tipo);
                lblDescripcionx.Text = Convert.ToString(equipo.Descripcion);
                lblMarcax.Text = Convert.ToString(equipo.Modelo);
                lblAreax.Text = Convert.ToString(equipo.Area);
                lblFechax.Text = Convert.ToString(equipo.FechaReg);
                lblEstadox.Text = Convert.ToString(equipo.Estado);

                proxy = null;
            }
            catch
            {
                Response.Write("<script language=javascript>alert('Se ha producido un grave error');</script>");
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mantenimiento.aspx?");
        }
       
    }
}