using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButCerrarSesion(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Cookies["email"].Expires = DateTime.Now.AddMinutes(-1);
            Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(-1);
            Response.Redirect("Default.aspx");
        }
    }
}