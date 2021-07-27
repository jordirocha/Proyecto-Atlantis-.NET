using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Evento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            DALEvento act = new DALEvento();
            List<EventoCls> acts = act.SelectActividad();
            repPosts.DataSource = acts;
            repPosts.DataBind();
        }

        protected void btnApuntarse_Click(object sender, EventArgs e)
        {
            int idUsuario = Int32.Parse(Session["id"].ToString());
            int idEvento = Int32.Parse((((sender as LinkButton).NamingContainer as RepeaterItem).FindControl("lbIdEvento") as Label).Text);

            LinkButton btnApuntarse = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)btnApuntarse.NamingContainer;
            Label lbApuntado = (Label)item.FindControl("lbApuntado");
            Label lbRegistrado = (Label)item.FindControl("lbRegistrado");
            Label lbPuntosInsuficientes = (Label)item.FindControl("lbPuntosInsuficientes");

            DALEvento ev = new DALEvento();
            if (ev.usuarioApuntadoEvento(idEvento, idUsuario) == true)
            {
                lbApuntado.Visible = true;
                lbRegistrado.Visible = false;
                lbPuntosInsuficientes.Visible = false;
            }
            else
            {
                if (ev.usuarioPuntosEvento(idEvento, idUsuario) == true)
                {
                    ev.usuarioApuntarse(idEvento, idUsuario, DateTime.Now);
                    lbRegistrado.Visible = true;
                    lbApuntado.Visible = false;
                    lbPuntosInsuficientes.Visible = false;
                }
                else
                {
                    lbPuntosInsuficientes.Visible = true;
                }
            }
        }
    }
}