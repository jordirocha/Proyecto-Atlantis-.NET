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
            ActividadDAL act = new ActividadDAL();
            List<ActividadCls> acts = act.SelectActividad();
            repPosts.DataSource = acts;
            repPosts.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = (((sender as LinkButton).NamingContainer as RepeaterItem).FindControl("lbFecha") as Label).Text;

        }

    }
}