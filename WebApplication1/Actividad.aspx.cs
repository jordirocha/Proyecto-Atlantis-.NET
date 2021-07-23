using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = "EEAEE";
            
            ActividadDAL act = new ActividadDAL();
            List<ActividadCls> acts = act.SelectActividad();
            repPosts.DataSource = acts;
            repPosts.DataBind();
        }
    }
}