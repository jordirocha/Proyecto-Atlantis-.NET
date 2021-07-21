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
            if (Request.Cookies["userInfo"] != null)
            {
                HttpCookie cookie = new HttpCookie("userInfo");
                cookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("Default.aspx");
        }
    }
}