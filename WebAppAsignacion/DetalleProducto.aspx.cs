﻿using System;
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
        public static int str_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarEquiposKey();
        }


        void cargarEquiposKey()
        {
            str_equipo = Request.QueryString["id"];
            str_id = Convert.ToInt32(str_equipo);

            ServicioEquipos.EquipoServiceClient proxy = new ServicioEquipos.EquipoServiceClient();

            ServicioEquipos.Equipos equipo = proxy.ObtenerEquipos(str_id);


            lblCodigox.Text = Convert.ToString(equipo.Id);
            lblNombrex.Text = Convert.ToString(equipo.Nombre);
            lblDescripcionx.Text = Convert.ToString(equipo.Descripcion);
            lblMarcax.Text = Convert.ToString(equipo.Marca);
            lblAreax.Text = Convert.ToString(equipo.Area);
            lblPreciox.Text = Convert.ToString(equipo.Precio);
            lblFechax.Text = Convert.ToString(equipo.Fecha);
            lblEstadox.Text = Convert.ToString(equipo.Estado);

            proxy = null;
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mantenimiento.aspx?");
        }
       
    }
}