using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Actividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            ActividadDAL act = new ActividadDAL();
            List<ActividadCls> acts = act.SelectActividad();
            repPosts.DataSource = acts;
            repPosts.DataBind();
        }

        protected void btnApuntarse_Click(object sender, EventArgs e)
        {
            int idUsuario = Int32.Parse(Session["id"].ToString());
            int idActividad = Int32.Parse((((sender as LinkButton).NamingContainer as RepeaterItem).FindControl("lbIdActividad") as Label).Text);

            LinkButton btnApuntarse = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)btnApuntarse.NamingContainer;
            Label lbApuntado = (Label)item.FindControl("lbApuntado");
            Label lbRegistrado = (Label)item.FindControl("lbRegistrado");

            ActividadDAL act = new ActividadDAL();
            if (act.usuarioApuntadoActividad(idActividad, idUsuario) == true)
            {
                lbApuntado.Visible = true;
                lbRegistrado.Visible = false;
            }
            else
            {
                act.usuarioApuntarse(idActividad, idUsuario, DateTime.Now);
                lbRegistrado.Visible = true;
                lbApuntado.Visible = false;
            }
        }

    }
}