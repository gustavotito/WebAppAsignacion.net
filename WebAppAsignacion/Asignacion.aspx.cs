using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAsignacion
{
    public partial class Asignacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listarSolicitud();
        }

        void listarSolicitud()
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnectionR = new System.Data.SqlClient.SqlConnection("Data Source=305a4753-766f-4c06-b100-a60c0046e39d.sqlserver.sequelizer.com;Database=db305a4753766f4c06b100a60c0046e39d;Initial Catalog=db305a4753766f4c06b100a60c0046e39d;User Id=oytjmyrazbvivilj; Password=ToLz4HuFLd3g7XqckzCHPQc6QPYDsgzupYqpUqQ8KpTzdHcfTXjyZZNdkPSnSYnE");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;               
                cmd.CommandText = "SELECT nro_solicitud,id_colaborador,s_nombres,s_apellidos,s_area,s_fech_registro,ES.e_descripcion AS estado FROM T_Solicitud AS SO INNER JOIN T_Estado AS ES ON SO.id_estado= ES.id_estado";
                cmd.Connection = sqlConnectionR;

                sqlConnectionR.Open();

                DataTable datos = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(cmd);
                a.Fill(datos);

                gvSolicitud.DataSource = datos;
                gvSolicitud.DataBind();

                sqlConnectionR.Close();
            }
            catch
            {
                Response.Write("<script language=javascript>alert('Error al cargar las solicitudes!!!!!!');</script>");
            }
        }

        protected void Paginar(object sender, GridViewPageEventArgs e)
        {
            gvSolicitud.PageIndex = e.NewPageIndex;
            listarSolicitud();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("WfPanel.aspx?");
        }
    }
}