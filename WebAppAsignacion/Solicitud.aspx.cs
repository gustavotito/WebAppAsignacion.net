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
            verificarColaboradorKey();
            listarColaboradorXPendiente();
        }

        void listarColaboradorXPendiente()
        {
            try
            {
                ServicioColaborador.ColaboradorServiceClient proxy = new ServicioColaborador.ColaboradorServiceClient();

                gvColaborador.DataSource = proxy.ListarColaboradorXPendiente();

                gvColaborador.DataBind();

                proxy = null;
            }
            catch 
            {
                Response.Write("<script language=javascript>alert('Se ha producido un grave error');</script>");
            }
        }

        void verificarColaboradorKey()
        {
            string str_colaborador = null;
            str_colaborador = Request.QueryString["id"];

            if (str_colaborador != null)
            {
                try
                {
                    ServicioColaborador.ColaboradorServiceClient proxy = new ServicioColaborador.ColaboradorServiceClient();
                    ServicioColaborador.Colaborador colaborador = proxy.ObtenerColaborador(Convert.ToInt32(str_colaborador));
                    registrarSolicitud(colaborador);
                    actualizarColaborador(colaborador);
                    colaborador = null;
                    str_colaborador = null;
                }
                catch
                {
                    Response.Write("<script language=javascript>alert('Se ha producido un grave error');</script>");
                }
            }                        
        }

        void registrarSolicitud(ServicioColaborador.Colaborador colaborador)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnectionR = new System.Data.SqlClient.SqlConnection("Data Source=305a4753-766f-4c06-b100-a60c0046e39d.sqlserver.sequelizer.com;Database=db305a4753766f4c06b100a60c0046e39d;Initial Catalog=db305a4753766f4c06b100a60c0046e39d;User Id=oytjmyrazbvivilj; Password=ToLz4HuFLd3g7XqckzCHPQc6QPYDsgzupYqpUqQ8KpTzdHcfTXjyZZNdkPSnSYnE");
                DateTime date = DateTime.Now;
                int id_colaborador = Convert.ToInt32(colaborador.Id);
                string s_nombres = Convert.ToString(colaborador.Nombres);
                string s_apellidos = Convert.ToString(colaborador.Apellidos);
                string s_area = Convert.ToString(colaborador.Area);
                string s_fech_registro = date.ToString("dd/MM/yyyy");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO T_Solicitud(id_colaborador,s_nombres,s_apellidos,s_area,s_fech_registro,id_estado) VALUES(" + id_colaborador + ",'" + s_nombres + "','" + s_apellidos + "','" + s_area + "','" + s_fech_registro + "'," + 4 + ")";
                cmd.Connection = sqlConnectionR;
                sqlConnectionR.Open();
                cmd.ExecuteNonQuery();
                sqlConnectionR.Close();
                Response.Write("<script language=javascript>alert('Se ha creado la solicitud exitosamente');</script>");
            }
            catch
            {
                Response.Write("<script language=javascript>alert('Error al intentar crear Solicitud!!!!!!');</script>");
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                

        }

        void actualizarColaborador(ServicioColaborador.Colaborador colaborador)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnectionR = new System.Data.SqlClient.SqlConnection("Data Source=305a4753-766f-4c06-b100-a60c0046e39d.sqlserver.sequelizer.com;Database=db305a4753766f4c06b100a60c0046e39d;Initial Catalog=db305a4753766f4c06b100a60c0046e39d;User Id=oytjmyrazbvivilj; Password=ToLz4HuFLd3g7XqckzCHPQc6QPYDsgzupYqpUqQ8KpTzdHcfTXjyZZNdkPSnSYnE");
                int id_colaborador = Convert.ToInt32(colaborador.Id);

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE T_Colaborador SET id_estado= 5 WHERE id_colaborador =" + id_colaborador;
                cmd.Connection = sqlConnectionR;
                sqlConnectionR.Open();
                cmd.ExecuteNonQuery();
                sqlConnectionR.Close();
            }
            catch
            {
                Response.Write("<script language=javascript>alert('Error al intentar actualizar Colaborador!!!!!!');</script>");
            }

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