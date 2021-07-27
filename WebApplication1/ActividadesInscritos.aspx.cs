using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ActividadesInscritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] == null || Session["rol"].ToString() != "user")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void CancelarActividad(object sender, EventArgs e)
        {
            var puntos = GridView1.SelectedRow.Cells[0].Text;
            int id = int.Parse(Session["id"].ToString());
            DALUsuario usu = new DALUsuario();
            usu.CancelarActividad(id, puntos);
            Response.Redirect("ActividadesInscritos.aspx");
        }
    }
}